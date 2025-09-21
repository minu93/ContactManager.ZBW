using ContactManager.Application.Abstractions;
using ContactManager.Domain.Entities;
using ContactManager.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Text.Json;

namespace ContactManager.Infrastructure.Persistence
{
    public sealed class EmployeeRepository : IEmployeeRepository
    {
        private readonly ContactManagerDbContext _db;
        private readonly IContactHistoryRepository _contactHistoryRepo;

        public EmployeeRepository(ContactManagerDbContext db, IContactHistoryRepository contactHistory)
        {
            _db = db;
            _contactHistoryRepo = contactHistory;

        }

        public async Task<IReadOnlyList<Employee>> GetAllAsync()
            => await _db.Employees
                        .AsNoTracking()
                        .OrderBy(e => e.LastName).ThenBy(e => e.FirstName)
                        .ToListAsync();

        public async Task<IReadOnlyList<Employee>> GetEmployeesOnlyAsync()
            => await _db.Employees
                        .AsNoTracking()
                        .Where(e => !(e is Trainee))
                        .OrderBy(e => e.LastName).ThenBy(e => e.FirstName)
                        .ToListAsync();

        public async Task<IReadOnlyList<Trainee>> GetTraineesAsync()
            => await _db.Set<Trainee>()
                        .AsNoTracking()
                        .OrderBy(t => t.LastName).ThenBy(t => t.FirstName)
                        .ToListAsync();

        public async Task AddAsync(Employee entity)
        {
            if (entity.EmployeeNumber <= 0)
            {
                var last = await _db.Employees
                                    .AsNoTracking()
                                    .OrderByDescending(e => e.EmployeeNumber)
                                    .Select(e => (int?)e.EmployeeNumber)
                                    .FirstOrDefaultAsync() ?? 0;

                entity.SetEmployeeNumber(last + 1);
            }

            _db.Employees.Add(entity);
            await _db.SaveChangesAsync();


            await _contactHistoryRepo.AddAsync(new ContactChange
            {
                PersonId = entity.Id,
                PersonType = "Employee",
                Action = ChangeAction.Created,
                Summary = "Erstellt",
                DataJson = JsonSerializer.Serialize(entity)
            });
        }

        public async Task UpdateAsync(Employee entity)
        {
            var before = await _db.Employees.AsNoTracking()
                                            .FirstOrDefaultAsync(x => x.Id == entity.Id);


            var tracked = await _db.Employees.FirstOrDefaultAsync(x => x.Id == entity.Id);
            if (tracked is null)
                throw new InvalidOperationException($"Employee {entity.Id} not found.");

            _db.Entry(tracked).CurrentValues.SetValues(entity);

            await _db.SaveChangesAsync();

            var summary = BuildDiffSummary(before, tracked);
            if (!string.IsNullOrWhiteSpace(summary))
            {
                await _contactHistoryRepo.AddAsync(new ContactChange
                {
                    PersonId = tracked.Id,
                    PersonType = "Employee",
                    Action = ChangeAction.Updated,
                    Summary = summary,
                    DataJson = JsonSerializer.Serialize(tracked)
                });
            }

        }

        public async Task DeleteAsync(Employee entity)
        {

            var snapshot = await _db.Employees.AsNoTracking()
                                              .FirstOrDefaultAsync(x => x.Id == entity.Id) ?? entity;

            var tracked = await _db.Employees.FirstOrDefaultAsync(x => x.Id == entity.Id);
            if (tracked is null)
            {
                tracked = new Employee { Id = entity.Id };
                _db.Attach(tracked);
            }

            _db.Remove(tracked);
            await _db.SaveChangesAsync();

            await _contactHistoryRepo.AddAsync(new ContactChange
            {
                PersonId = snapshot.Id,
                PersonType = "Employee",
                Action = ChangeAction.Deleted,
                Summary = $"Gelöscht: {snapshot.FirstName} {snapshot.LastName}".Trim(),
                DataJson = JsonSerializer.Serialize(snapshot)
            });
        }


        private static string BuildDiffSummary(Employee? oldVal, Employee newVal)
        {
            if (oldVal == null) return "Erstellt";
            var props = GetComparableProps(newVal.GetType());
            var changes = new List<string>();

            foreach (var p in props)
            {
                var a = p.GetValue(oldVal);
                var b = p.GetValue(newVal);
                if (!EqualsNormalized(a, b))
                    changes.Add($"{p.Name}: {ToText(a)} → {ToText(b)}");
            }

            return string.Join("; ", changes);
        }

        private static IEnumerable<PropertyInfo> GetComparableProps(Type t)
        {

            bool IsSimple(Type tt)
            {
                tt = Nullable.GetUnderlyingType(tt) ?? tt;
                return tt.IsPrimitive || tt.IsEnum || tt == typeof(string) || tt == typeof(DateTime) || tt == typeof(Guid) || tt == typeof(decimal);
            }

            return t.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                    .Where(p => p.CanRead && p.CanWrite
                                && p.Name != nameof(Person.Id)
                                && IsSimple(p.PropertyType));
        }

        private static bool EqualsNormalized(object? x, object? y)
        {
            if (x is DateTime dx && y is DateTime dy) return dx.Date == dy.Date;
            return string.Equals(ToText(x), ToText(y), StringComparison.Ordinal);
        }

        private static string ToText(object? v)
        {
            if (v == null) return "∅";
            if (v is DateTime d) return d.ToString("yyyy-MM-dd");
            if (v is bool b) return b ? "True" : "False";
            return v.ToString() ?? "";
        }
    }
}
