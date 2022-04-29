namespace ConcepsPDO
{
    public class Invoice : IPay
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public float Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal GetValueToPay()
        {
            return Price * (decimal)Quantity;
        }
        public override string ToString()
        {
            return $"{Id} -Description: {Description} - Quantity: {$"{Quantity:N2}",18} - Price: {$"{Price:C2}",18} Value: {$"{GetValueToPay():C2}",18}";
        }
    }
}