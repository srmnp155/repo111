using ProductSellingWebsite.Models;

namespace ProductSellingWebsite.Services
{
    public interface ICartService
    {
        IEnumerable<CartItem> GetCartItems();
        void AddToCart(Product product, int quantity);
        void RemoveFromCart(int productId);
        void ClearCart();
    }
}