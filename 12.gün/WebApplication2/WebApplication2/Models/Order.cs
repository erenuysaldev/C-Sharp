namespace WebApplication2.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public List<CartItem> Items { get; set; }
        public decimal totalAmount { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
