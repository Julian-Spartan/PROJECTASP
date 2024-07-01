namespace sit.Models
{
    public class CartItem
    {
        public Product Product { get; set; } = new Product(); // Inicialización para evitar CS8618
        public int Quantity { get; set; }
    }
}
