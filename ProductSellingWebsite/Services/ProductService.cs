using ProductSellingWebsite.Models;
using System.Linq;

namespace ProductSellingWebsite.Services
{
    public class ProductService : IProductService
    {
        private readonly List<Product> _products;

        public ProductService()
        {
            // Seed data
            _products = new List<Product>
            {
                new Product { Id = 1, Name = "Product A", Description = "Description for Product A", Price = 29.99M, ImageUrl = "/images/product1.jpg" },
                new Product { Id = 2, Name = "Product B", Description = "Description for Product B", Price = 49.99M, ImageUrl = "/images/product2.jpg" },
                new Product { Id = 3, Name = "Product C", Description = "Description for Product C", Price = 19.99M, ImageUrl = "/images/product3.jpg" }
            };
        }

        public IEnumerable<Product> GetAllProducts() => _products;

        public Product? GetProductById(int id) => _products.FirstOrDefault(p => p.Id == id);
    }
}