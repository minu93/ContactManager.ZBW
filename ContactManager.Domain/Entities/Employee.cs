using ContactManager.Domain.Errors;

namespace ContactManager.Domain.Entities
{
    public class Employee : Person
    {

        public int EmployeeNumber { get; private set; }
        public string? Department { get; private set; }
        public DateTime? StartDate { get; private set; }
        public DateTime? EndDate { get; private set; }
        public int? Employment { get; private set; } 
        public string? Role { get; private set; }
        public int? CadreLevel { get; private set; }

        public void SetEmployeeNumber(int number)
        {
            if (number <= 0)
                throw new DomainValidationException("Mitarbeiternummer muss > 0 sein.", nameof(EmployeeNumber));
            EmployeeNumber = number;
        }

        public void SetDepartment(string? department)
        {
            if (department == null)
                throw new DomainValidationException("Abteilung muss definiert sein.", nameof(Department));

            var val = string.IsNullOrWhiteSpace(department) ? null : department.Trim();
            Department = val;
        }

        public void SetRole(string? role)
        {
            // role can be null or empty throw exception
            if (role == null)
                throw new DomainValidationException("Rolle muss definiert sein.", nameof(Role));

            var val = string.IsNullOrWhiteSpace(role) ? null : role.Trim();
            Role = val;
        }

        public void SetCadreLevel(int? level)
        {
            if (level.HasValue && (level < 1 || level > 10))
                throw new DomainValidationException("Kaderstufe muss zwischen 1 und 10 liegen.", nameof(CadreLevel));
            CadreLevel = level;
        }

        public void SetEmployment(int? percent)
        {
            if (percent.HasValue && (percent < 20 || percent > 100))
                throw new DomainValidationException("Pensum muss zwischen 20% und 100% liegen", nameof(Employment));
            Employment = percent;
        }
        public void SetStartDate(DateTime start)
        {
            StartDate = start.Date;

            if (EndDate.HasValue && EndDate.Value.Date < StartDate.Value.Date)
                throw new DomainValidationException("Enddatum darf nicht vor dem Startdatum liegen.", nameof(EndDate));
        }

        public void SetEndDate(DateTime? end)
        {
            if (end is null)
            {
                EndDate = null;
                return;
            }

            if (!StartDate.HasValue)
                throw new DomainValidationException("Startdatum zuerst setzen.", nameof(StartDate));

            var e = end.Value.Date;
            if (e < StartDate.Value.Date)
                throw new DomainValidationException("Enddatum darf nicht vor dem Startdatum liegen.", nameof(EndDate));

            EndDate = e;
        }

        // Can be used for temporary employees :D 
        public void SetEmploymentPeriod(DateTime start, DateTime? end)
        {
            SetStartDate(start);
            SetEndDate(end);
        }


    }
}
