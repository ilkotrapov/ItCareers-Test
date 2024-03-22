using Microsoft.AspNetCore.Mvc;
using Products_Web.Models;
using Products_Web.Services.Interfaces;

namespace Products_Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateProductViewModel product)
        {
            productService.Add(product);

            return RedirectToAction(nameof(Index));
        }
    }
}
