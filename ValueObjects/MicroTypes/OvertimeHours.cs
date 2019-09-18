namespace ValueObjects.MicroTypes
{
    public class OvertimeHours : BaseValueObject<OvertimeHours>
    {
        public readonly Hours Hours;
        public OvertimeHours(Hours hours)
        {
            this.Hours = hours;
        }
        protected override int GetHashCodeCore()
        {
            return this.Hours.GetHashCode();
        }

        protected override bool IsEqual(OvertimeHours other)
        {
            return this.Hours == other.Hours;
        }
    }
}
