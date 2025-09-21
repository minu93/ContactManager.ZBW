using ContactManager.Domain.Enums;

namespace ContactManager.Domain.Entities
{

    public class ContactChange
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid PersonId { get; set; }
        public string PersonType { get; set; } = ""; // "Customer", "Employee" or "Trainee"
        
        public ChangeAction Action { get; set; }

        public DateTime OccurredAt { get; set; } = DateTime.UtcNow;

        public string? Summary { get; set; }
        public string? DataJson { get; set; }

    }
}
