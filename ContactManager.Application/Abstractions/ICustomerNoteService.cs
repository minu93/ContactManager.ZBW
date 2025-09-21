using ContactManager.Domain.Entities;


namespace ContactManager.Application.Abstractions
{
    public interface ICustomerNoteService
    {
        Task CreateAsync(CustomerNote note);

        Task UpdateAsync(CustomerNote note);

        Task DeleteAsync(CustomerNote note);
    }
}
