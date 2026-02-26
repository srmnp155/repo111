using ProductSellingWebsite.Models;
using System.Linq;

namespace ProductSellingWebsite.Services
{
    public class CartService : ICartService
    {
        private readonly List<CartItem> _items = new();

        public IEnumerable<CartItem> GetCartItems() => _items;

        public void AddToCart(Product product, int quantity)
        {
            var existing = _items.FirstOrDefault(i => i.Product.Id == product.Id);
            if (existing != null)
            {
                existing.Quantity += quantity;
            }
            else
            {
                _items.Add(new CartItem { Product = product, Quantity = quantity });
            }
        }

        public void RemoveFromCart(int productId)
        {
            var existing = _items.FirstOrDefault(i => i.Product.Id == productId);
            if (existing != null)
            {
                _items.Remove(existing);
            }
        }

        public void ClearCart() => _items.Clear();
    }
}