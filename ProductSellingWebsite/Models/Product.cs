using System.ComponentModel.DataAnnotations;

namespace ProductSellingWebsite.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(500)]
        public string Description { get; set; } = string.Empty;

        [Range(0.01, double.MaxValue)]
        public decimal Price { get; set; }

        [Url]
        public string ImageUrl { get; set; } = string.Empty;
    }
}