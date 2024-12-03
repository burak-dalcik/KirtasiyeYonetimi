namespace Kirt_web.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public int SubcategoryId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Brand { get; set; }
        public int StockCount { get; set; } 

        public Subcategory Subcategory { get; set; }
    }
}
