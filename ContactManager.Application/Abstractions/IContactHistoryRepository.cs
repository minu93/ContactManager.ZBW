using ContactManager.Domain.Entities;

namespace ContactManager.Application.Abstractions
{
    public interface IContactHistoryRepository
    {
        Task AddAsync(ContactChange change);
        Task<IReadOnlyList<ContactChange>> GetByPersonAsync(Guid personId);

    }
}
