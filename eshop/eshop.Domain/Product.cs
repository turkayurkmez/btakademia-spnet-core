using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.Domain
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; } = "https://cdn.dsmcdn.com/ty1398/product/media/images/prod/QC/20240703/11/36f8f5ca-a76c-356a-8ff3-3435c5ae8c9f/1_org.jpg";

        public int Stock { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set;}

        public bool IsActive { get; set; } = true;
        public string? Status { get; set; }

        public int CategoryId { get; set; }

    }
}
