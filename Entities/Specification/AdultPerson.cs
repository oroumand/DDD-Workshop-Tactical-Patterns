using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Specification
{
    public class Person
    {
        public IsGraterThanOrEqualAgePerson IsAdult { get; set; } = new IsGraterThanOrEqualAgePerson(18);
        public int Id { get; protected set; }
        public DateTime BirthDate { get; protected set; }
        public Person(int id, DateTime birthDate)
        {

        }
        public bool AllowAdultAccess()
        {
            return IsAdult.IsSatisfiedBy(this);
        }
    }
}
