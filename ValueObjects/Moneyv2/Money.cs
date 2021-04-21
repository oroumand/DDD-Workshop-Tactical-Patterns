using System;
using System.Collections.Generic;
using System.Text;

namespace ValueObjects.Moneyv2
{
    public class Money : BaseValueObject<Money>
    {
        protected readonly decimal Value;
        public Money() : this(0m)
        {
        }
        public Money(decimal value)
        {
            Value = value;
        }
        public Money Add(Money money)
        {
            return new Money(Value + money.Value);
        }
        public Money Subtract(Money money)
        {
            return new Money(Value - money.Value);
        }

        protected override int GetHashCodeCore()
        {
            return this.Value.GetHashCode();
        }

        protected override bool IsEqual(Money other)
        {
            if (ReferenceEquals(other, null))
                return false;
            return this.Value == other.Value;
        }
    }
}
