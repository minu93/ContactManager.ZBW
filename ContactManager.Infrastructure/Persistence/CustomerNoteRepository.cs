using ContactManager.Application.Abstractions;
using ContactManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ContactManager.Infrastructure.Persistence;


public sealed class CustomerNoteRepository : ICustomerNoteRepository
{
    private readonly ContactManagerDbContext _db;

    public CustomerNoteRepository(ContactManagerDbContext db)
    {
        _db = db;
        _db.Database.EnsureCreated();
    }

    public async Task<IReadOnlyList<CustomerNote>> GetAllAsync()
        => await _db.CustomerNotes
                    .AsNoTracking()
                    .Include(n => n.Customer)
                    .OrderByDescending(n => n.CreatedAt)
                    .ToListAsync();

    public async Task<IReadOnlyList<CustomerNote>> GetForCustomerAsync(Guid customerId)
        => await _db.CustomerNotes
                    .AsNoTracking()
                    .Where(n => n.CustomerId == customerId)
                    .OrderByDescending(n => n.CreatedAt)
                    .ToListAsync();

    public async Task AddAsync(CustomerNote entity)
    {
        if (entity == null) throw new ArgumentNullException(nameof(entity));
        _db.CustomerNotes.Add(entity);
        await _db.SaveChangesAsync();
    }

    public async Task UpdateAsync(CustomerNote entity)
    {
        if (entity == null) throw new ArgumentNullException(nameof(entity));
        await _db.CustomerNotes
                 .Where(n => n.Id == entity.Id)
                 .ExecuteUpdateAsync(set => set
                     .SetProperty(n => n.Note, entity.Note)
                     .SetProperty(n => n.CreatedAt, entity.CreatedAt));
    }

    public async Task DeleteAsync(CustomerNote entity)
    {
        if (entity == null) throw new ArgumentNullException(nameof(entity));
        await _db.CustomerNotes
                 .Where(n => n.Id == entity.Id)
                 .ExecuteDeleteAsync();
    }
}
