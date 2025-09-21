using ContactManager.Domain.Errors;
using System.Text.RegularExpressions;


namespace ContactManager.Domain.Entities
{
    public class Person
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string? Salutation { get; set; }        
        public string FirstName { get; set; } = string.Empty;   
        public string LastName { get; set; } = string.Empty;     
        public DateTime? DateOfBirth { get; set; }                
        public bool Gender { get; set; }                        
        public string? Title { get; set; }                        
        public string? SocialSecurityNumber { get; set; }      
        public string? PhoneNumberPrivate { get; set; }            
        public string? PhoneNumberMobile { get; set; }             
        public string? PhoneNumberBusiness { get; set; }           
        public string? Email { get; set; }                        
        public bool Status { get; set; } = true;                   
        public string? Nationality { get; set; }                  
        public string? Street { get; set; }                        
        public string? StreetNumber { get; set; }                 
        public int? ZipCode { get; set; }                         
        public string? Place { get; set; }


        public void SetTitle(string title)
        {
            Title = title;
        }

        public void SetSalutation(string salutation) {
            
            Salutation = salutation;
        }

        public void SetName(string firstName, string lastName)
        {
            var fn = (firstName ?? "").Trim();
            var ln = (lastName ?? "").Trim();
            if (fn.Length == 0 || ln.Length == 0)
                throw new DomainValidationException("Vor- und Nachname sind erforderlich.");

            FirstName = fn;
            LastName = ln;
        }

        public void SetEmail(string? email)
        {
            if (string.IsNullOrWhiteSpace(email)) throw new DomainValidationException("E-Mail ist erforderlich.", "Email");
            var val = email.Trim();
            if (!Regex.IsMatch(val, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new DomainValidationException("E-Mail ist ungültig.", "Email");
            Email = val;
        }

        public void SetBirthdate(DateTime? date)
        {

            var d = date.Value.Date;
            var today = DateTime.Today;

            if (d > today)
                throw new DomainValidationException("Geburtsdatum darf nicht in der Zukunft liegen.", "DateOfBirth");

            // min 14 years old we dont support child labour
            var min = today.AddYears(-14);
            if (d > min)
                throw new DomainValidationException("Person muss mindestens 12 Jahre alt sein.", "DateOfBirth");

            DateOfBirth = d;
        }


        public void SetPhones(string? priv, string? mobile, string? business)
        {
            PhoneNumberPrivate = NormalizePhoneOrNull(priv, "PhoneNumberPrivate");
            PhoneNumberMobile = NormalizePhoneOrNull(mobile, "PhoneNumberMobile");
            PhoneNumberBusiness = NormalizePhoneOrNull(business, "PhoneNumberBusiness");
        }

        public void SetAddress(string? street, string? nr, int? zip, string? place, string? nationality)
        {
            if (zip.HasValue && (zip < 100 || zip > 9999))
                throw new DomainValidationException("PLZ muss 3–4-stellig sein.", "ZipCode");

            Street = street?.Trim();
            StreetNumber = nr?.Trim();
            ZipCode = zip;
            Place = place?.Trim();
            Nationality = nationality?.Trim();
        }

        public void SetSocialSecurityNumber(string? socialSecurityNumber)
        {
            if (string.IsNullOrWhiteSpace(socialSecurityNumber))
            {
                SocialSecurityNumber = null;
                return;
            }

            // Entferne alle nicht-numerischen Zeichen
            var normalized = Regex.Replace(socialSecurityNumber, @"\D", "");

            // Prüfe, ob die AHV-Nummer mit 756 beginnt und genau 13 Ziffern hat
            if (!Regex.IsMatch(normalized, @"^756\d{10}$"))
            {
                throw new ArgumentException("Die AHV-Nummer ist ungültig. Sie muss mit '756' beginnen und 13 Ziffern enthalten.");
            }

            SocialSecurityNumber = normalized;
        }

        public void SetGender(bool isMale) => Gender = isMale;

        public void Activate() => Status = true;
        public void Deactivate() => Status = false;



        private static bool IsValidEmail(string email)
            => Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

        private static string? NormalizePhoneOrNull(string? raw, string field)
        {
            if (string.IsNullOrWhiteSpace(raw)) return null;
            var digits = Regex.Replace(raw, @"\D", "");
            if (digits.Length < 6)
                throw new DomainValidationException("Telefonnummer ist zu kurz.", field);

            // einfache Normalisierung
            if (digits.StartsWith("41") && digits.Length >= 11) return "+41" + digits[2..];
            if (digits.StartsWith("0")) return digits;
            return digits;
        }

    }
}
