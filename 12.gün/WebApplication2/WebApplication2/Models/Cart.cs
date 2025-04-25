namespace WebApplication2.Models
{
    public class Cart
    {
        public int Id { get; set; }  // Birincil anahtar

        public List<CartItem> Items { get; set; } = new List<CartItem>();
        public decimal Total => Items.Sum(item => item.Product.Price * item.Quantity);
    }
    public class CartItem
    {
        public int Id { get; set; }  // Birincil anahtar

        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
