using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.Application.DataTransferObjects.Requests
{
    public class CreateNewProductRequest
    {
        [Required(ErrorMessage ="Ürün adını unutmayınız")]
        [MaxLength(255, ErrorMessage ="Maksimum 255 karakter olmalı")]
        [MinLength(3, ErrorMessage ="En az üç harfli olmalı")]
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public string? ImageUrl { get; set; } = "https://cdn.dsmcdn.com/ty1398/product/media/images/prod/QC/20240703/11/36f8f5ca-a76c-356a-8ff3-3435c5ae8c9f/1_org.jpg";

        public int? Stock { get; set; }
        public string? Status { get; set; }

        public int? CategoryId { get; set; }
    }
}
