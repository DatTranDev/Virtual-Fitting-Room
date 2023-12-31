using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VirtualFittingRoom.Models;

namespace VirtualFittingRoom.Controllers
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
     
    }
}
