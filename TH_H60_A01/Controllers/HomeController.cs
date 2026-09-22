using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TH_H60_A01.Models;

namespace TH_H60_A01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductCategoryDB _productCategoryDB;

        public HomeController(ProductCategoryDB productCategoryDB)
        {
            _productCategoryDB = productCategoryDB;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Categories()
        {
            var categories = _productCategoryDB.GetCategories();
            return View(categories);
        }
    }
}
