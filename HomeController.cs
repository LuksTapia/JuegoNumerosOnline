using JuegoNumero.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JuegoNumero.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {   
            //es el primero que aparece cuando abro la pagina
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string Nombre1, string Nombre2)
        {
            ViewBag.Nombre1= Nombre1;
            ViewBag.Nombre2= Nombre2;

            return View("Juego");
        }

        public IActionResult Juego()
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