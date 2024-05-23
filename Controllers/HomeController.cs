using Microsoft.AspNetCore.Mvc;
using Razor.Models;
using System.Diagnostics;
using System.Reflection;

namespace Razor.Controllers
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
            String conclusion = String.Empty;
            Int32 sum = new int[] { 24, 100, 200, 9000 }.Sum(m => m);

            if (sum > 10000000)
                conclusion = "You earn too much money";
            else
                conclusion = "You should ask for a salary raise";

            ViewData["Conclusion"] = conclusion;


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
