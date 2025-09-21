using ContactManager.Domain.Errors;

namespace ContactManager.Domain.Entities
{
    public class Customer : Person
    {
        public string? CompanyName { get; private set; }

        public char? CustomerType { get; private set; }

        public string? CompanyContact {  get; private set; }

        public void SetCompany(string? name, string? contact, char? type)
        {
            var n = string.IsNullOrWhiteSpace(name) ? null : name.Trim();
            var c = string.IsNullOrWhiteSpace(contact) ? null : contact.Trim();

            if (n is null || c is null || type is null)
                throw new DomainValidationException("Firmenname, Ansprechpartner und Kundentyp müssen gesetzt sein.");

            CompanyName = n;
            CompanyContact = c;
            CustomerType = type;
        }


    }
}
