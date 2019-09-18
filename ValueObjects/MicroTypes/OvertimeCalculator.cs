namespace ValueObjects.MicroTypes
{
    public class OvertimeCalculator
    {
        public OvertimeHours Calculate(HoursWorked worked, ContractedHours contracted)
        {
            var overtimeHours = worked.Hours - contracted.Hours;
            return new OvertimeHours(overtimeHours);
        }
    }
}
