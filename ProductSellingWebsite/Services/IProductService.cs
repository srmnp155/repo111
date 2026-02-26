using ProductSellingWebsite.Models;

namespace ProductSellingWebsite.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        Product? GetProductById(int id);
    }
}