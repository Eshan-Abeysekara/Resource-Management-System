using abcd.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace abcd.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult registration()
        {
            return View();
        }
        public IActionResult dashbord()
        {
            return View();
        }
        public IActionResult resource()
        {
            return View();
        }
        public IActionResult teacher()
        {
            return View();
        }
        public IActionResult resource_managing()
        {
            return View();
        }
        public IActionResult restock()
        {
            return View();
        }
        public IActionResult confirmation()
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
    }
}