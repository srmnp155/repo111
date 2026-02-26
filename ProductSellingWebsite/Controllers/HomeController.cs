using Microsoft.AspNetCore.Mvc;
using ProductSellingWebsite.Services;

namespace ProductSellingWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var products = _productService.GetAllProducts();
            return View(products);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}