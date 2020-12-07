using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Razor_bonnes_pratiques.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Razor_bonnes_pratiques.Controllers
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
            IEnumerable<Int32> Amount = new Int32[] { 150, 300, 750 };
            Int32 sum = Amount.Sum();
            if (sum > 10000000)
            {
                conclusion = "You earn too much money";
            }
            else
            {
                conclusion = "You should ask for a salary raise";
            }
            return View("Index", conclusion);
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
