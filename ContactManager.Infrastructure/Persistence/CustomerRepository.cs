using ContactManager.Application.Abstractions;
using ContactManager.Domain.Entities;
using ContactManager.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Text.Json;

namespace ContactManager.Infrastructure.Persistence;

public sealed class CustomerRepository : ICustomerRepository
{
    private readonly ContactManagerDbContext _db;
    private readonly IContactHistoryRepository _contactHistoryRepo;

    public CustomerRepository(ContactManagerDbContext db, IContactHistoryRepository history)
    {
        _db = db;
        _contactHistoryRepo = history;
    }

    public async Task<IReadOnlyList<Customer>> GetAllAsync()
        => await _db.Customers
                    .OrderBy(c => c.LastName).ThenBy(c => c.FirstName)
                    .ToListAsync();

    public async Task AddAsync(Customer entity)
    {
        _db.Customers.Add(entity);
        await _db.SaveChangesAsync();

        await _contactHistoryRepo.AddAsync(new ContactChange
        {
            PersonId = entity.Id,
            PersonType = "Customer",
            Action = ChangeAction.Created,
            Summary = "Erstellt",
            DataJson = JsonSerializer.Serialize(entity)
        });

    }

    public async Task UpdateAsync(Customer entity)
    {
        var before = await _db.Customers.AsNoTracking().FirstOrDefaultAsync(x => x.Id == entity.Id);

        var tracked = await _db.Customers.FirstOrDefaultAsync(x => x.Id == entity.Id);
        if (tracked is null)
            throw new InvalidOperationException($"Customer {entity.Id} not found.");

        _db.Entry(tracked).CurrentValues.SetValues(entity);

        await _db.SaveChangesAsync();


        var summary = BuildDiffSummary(before, entity);
        if (!string.IsNullOrWhiteSpace(summary))
        {
            await _contactHistoryRepo.AddAsync(new ContactChange
            {
                PersonId = entity.Id,
                PersonType = "Customer",
                Action = ChangeAction.Updated,
                Summary = summary,
                DataJson = JsonSerializer.Serialize(entity)
            });
        }

    }

    public async Task DeleteAsync(Customer entity)
    {
        var snapshot = await _db.Customers.AsNoTracking().FirstOrDefaultAsync(x => x.Id == entity.Id) ?? entity;

        var tracked = await _db.Customers.FirstOrDefaultAsync(x => x.Id == entity.Id);
        if (tracked is null)
        {
            tracked = new Customer { Id = entity.Id };
            _db.Attach(tracked);
        }


        _db.Customers.Remove(entity);
        await _db.SaveChangesAsync();


        await _contactHistoryRepo.AddAsync(new ContactChange
        {
            PersonId = snapshot.Id,
            PersonType = "Customer",
            Action = ChangeAction.Deleted,
            Summary = $"Gelöscht: {snapshot.FirstName} {snapshot.LastName}".Trim(),
            DataJson = JsonSerializer.Serialize(snapshot)
        });

    }

    public async Task<bool> ExistsDuplicateAsync(Customer c)
    {
        var q = _db.Customers.AsNoTracking().Where(x => x.Id != c.Id);


        if (!string.IsNullOrWhiteSpace(c.Email))
        {
            var email = c.Email.Trim().ToLower();
            if (await q.AnyAsync(x => x.Email != null && x.Email.ToLower() == email))
                return true;
        }

        if (!string.IsNullOrWhiteSpace(c.FirstName) &&
            !string.IsNullOrWhiteSpace(c.LastName) &&
            c.DateOfBirth.HasValue)
        {
            var fn = c.FirstName.Trim();
            var ln = c.LastName.Trim();
            var dob = c.DateOfBirth.Value.Date;

            if (await q.AnyAsync(x =>
                x.FirstName == fn &&
                x.LastName == ln &&
                x.DateOfBirth.HasValue &&
                x.DateOfBirth.Value.Date == dob))
                return true;
        }

        if (!string.IsNullOrWhiteSpace(c.CompanyName))
        {
            var company = c.CompanyName.Trim();
            if (await q.AnyAsync(x => x.CompanyName != null && x.CompanyName == company))
                return true;
        }

        return false;
    }

    private static string BuildDiffSummary(Customer? oldVal, Customer newVal)
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
