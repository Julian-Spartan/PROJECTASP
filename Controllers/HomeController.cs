using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging; // Asegúrate de tener este using
using System.Diagnostics; // Asegúrate de tener este using

namespace sit.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new Models.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            // Asegúrate de que Activity y HttpContext.TraceIdentifier están disponibles
        }
    }
}
