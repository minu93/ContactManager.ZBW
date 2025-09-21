using ContactManager.Domain.Errors;

namespace ContactManager.Domain.Entities
{
    public class CustomerNote
    {
        public Guid Id { get; private set; } = Guid.NewGuid();

        public Guid CustomerId { get; private set; }


        public Customer Customer { get; private set; } = default!;

        public DateTime CreatedAt { get; private set; }

        public string Note { get; private set; } = string.Empty;


        public void SetNote(string? note)
        {
            var val = (note ?? string.Empty).Trim();
            if (val.Length == 0)
                throw new DomainValidationException("Notiz darf nicht leer sein.", "Note");
            if (val.Length > 2000)
                throw new DomainValidationException("Notiz ist zu lang (max. 2000 Zeichen).", "Note");

            Note = val;
        }

        public void AssignToCustomer(Guid customerId)
        {
            if (customerId == Guid.Empty)
                throw new DomainValidationException("Ungültige Kundenzuordnung.", "CustomerId");
            CustomerId = customerId;
        }

        public void StampCreated(DateTime? utcNow = null)
            => CreatedAt = (utcNow ?? DateTime.UtcNow);

    }
}
