namespace OrderApi.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderName { get; set; }
        public double Amount { get; set; }
        public string Status { get; set; }
    }
}