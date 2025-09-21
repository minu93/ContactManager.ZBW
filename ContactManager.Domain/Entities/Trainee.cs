using ContactManager.Domain.Errors;

namespace ContactManager.Domain.Entities
{
    public class Trainee : Employee
    {
        public int? TraineeYears { get; private set; }
        public int? ActualTraineeYear { get; private set; }

        public void SetTraineePlan(int? totalYears, int? currentYear)
        {
            // if totalyears and current ares are both 0 then thow exception
            if (totalYears == null && currentYear == null)
                throw new DomainValidationException("Ausbildungsjahre und aktuelles Lehrjahr dürfen nicht beide 0 sein.");

            if (totalYears.HasValue && (totalYears < 1 || totalYears > 5))
                throw new DomainValidationException("Ausbildungsjahre müssen zwischen 1 und 5 liegen.", nameof(TraineeYears));

            if (currentYear.HasValue && currentYear < 1)
                throw new DomainValidationException("Aktuelles Lehrjahr muss ≥ 1 sein.", nameof(ActualTraineeYear));

            if (totalYears.HasValue && currentYear.HasValue && currentYear > totalYears)
                throw new DomainValidationException("Aktuelles Lehrjahr darf die Gesamtdauer nicht überschreiten.", nameof(ActualTraineeYear));

            TraineeYears = totalYears;
            ActualTraineeYear = currentYear;
        }
    }
}
