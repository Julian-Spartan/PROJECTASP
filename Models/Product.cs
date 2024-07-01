namespace sit.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = ""; // Inicialización para evitar CS8618
        public string Description { get; set; } = ""; // Inicialización para evitar CS8618
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } = ""; // Inicialización para evitar CS8618
    }
}
