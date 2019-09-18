using System;

namespace Entities.Specification
{
    public class IsGraterThanOrEqualAgePerson : ISpecification<Person>
    {
        private readonly int minValidDate;
        public IsGraterThanOrEqualAgePerson(int minValidDate)
        {

            this.minValidDate = minValidDate;
        }

    

        public bool IsSatisfiedBy(Person Entity)
        {
            var age = (DateTime.Now - Entity.BirthDate).TotalDays % 365;
            return age >= minValidDate

        }
    }
}
