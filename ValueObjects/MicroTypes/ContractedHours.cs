namespace ValueObjects.MicroTypes
{
    public class ContractedHours : BaseValueObject<ContractedHours>
    {
        public readonly Hours Hours;
        public ContractedHours(Hours hours)
        {
            this.Hours = hours;
        }
        protected override int GetHashCodeCore()
        {
            return this.Hours.GetHashCode();
        }

        protected override bool IsEqual(ContractedHours other)
        {
            return this.Hours == other.Hours;
        }
    }
}
