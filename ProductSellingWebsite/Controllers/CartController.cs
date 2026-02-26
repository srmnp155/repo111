using Microsoft.AspNetCore.Mvc;
using System.Linq;
using ProductSellingWebsite.Services;

namespace ProductSellingWebsite.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        public IActionResult Index()
        {
            var items = _cartService.GetCartItems();
            ViewBag.Total = items.Sum(i => i.Quantity * i.Product.Price);
            return View(items);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Remove(int productId)
        {
            _cartService.RemoveFromCart(productId);
            return RedirectToAction("Index");
        }
    }
}