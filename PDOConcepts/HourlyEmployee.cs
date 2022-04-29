namespace ConcepsPDO
{
    public class HourlyEmployee : Employee
    {
        public float Hours { get; set; }

        public decimal HourValue  { get; set; }
        public override decimal GetValueToPay()
        {
            return (decimal)Hours * HourValue;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t tHours: {Hours:N2} \n\t HourValue: ...... {$"{HourValue:C2}",18} \n\t Value to pay: {$"{GetValueToPay():C2}",18}";
        }
    }
}