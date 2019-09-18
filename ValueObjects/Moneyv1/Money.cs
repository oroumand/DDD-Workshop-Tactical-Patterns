using System;
using System.Collections.Generic;
using System.Text;

namespace ValueObjects
{
    /// <summary>
    /// بررسی تساوی value Objectها
    /// </summary>
    public class Money
    {
        protected readonly decimal Value;
        public Money() : this(0m)
        {
        }
        public Money(decimal value)
        {
            Value = value;
        }       
      
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }


        public override bool Equals(object obj)
        {
            var valueObject = obj as Money;

            if (ReferenceEquals(valueObject, null))
                return false;

            return this == valueObject;
        }
        public static bool operator ==(Money a, Money b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(Money a, Money b)
        {
            return !(a == b);
        }
    }
}
