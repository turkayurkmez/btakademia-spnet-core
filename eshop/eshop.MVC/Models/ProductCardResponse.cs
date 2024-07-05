namespace eshop.MVC.Models
{
    public class ProductCardResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } = "https://cdn.dsmcdn.com/ty1398/product/media/images/prod/QC/20240703/11/36f8f5ca-a76c-356a-8ff3-3435c5ae8c9f/1_org.jpg";
    }
}
