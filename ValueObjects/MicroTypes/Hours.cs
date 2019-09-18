namespace ValueObjects.MicroTypes
{
    public class Hours : BaseValueObject<Hours>
    {
        public readonly int Amount;
        public Hours(int amount)
        {
            this.Amount = amount;
        }
        public static Hours operator -(Hours left, Hours right)
        {
            return new Hours(left.Amount - right.Amount);
        }

        protected override bool IsEqual(Hours other)
        {
            return this.Amount == other.Amount;
        }

        protected override int GetHashCodeCore()
        {
            return this.Amount.GetHashCode();
        }
    }
}
