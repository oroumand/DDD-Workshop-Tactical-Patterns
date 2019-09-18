using System;
using System.Collections.Generic;
using System.Text;

namespace ValueObjects.MicroTypes
{
    public class HoursWorked : BaseValueObject<HoursWorked>
    {
        public readonly Hours Hours;
        public HoursWorked(Hours hours)
        {
            this.Hours = hours;
        }

        protected override int GetHashCodeCore()
        {
            return this.Hours.GetHashCode();
        }

        protected override bool IsEqual(HoursWorked other)
        {
            return this.Hours == other.Hours;
        }
    }
}
