using Microsoft.AspNetCore.Mvc;
using SistemaFinanceiroUGB20232.Models;
using System.Diagnostics;

namespace SistemaFinanceiroUGB20232.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;  /* atributo pq ta sem get e set, o logger mostra quando a pessoa logou e executou algo*/

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
            ViewData["Message"] = "Seja bem vindo, ah";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Teste() 
        {

            return View();
        }
    }
}