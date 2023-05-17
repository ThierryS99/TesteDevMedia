using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TesteDevMedia.Models;

namespace TesteDevMedia.Controllers
{
    public class PostController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public PostController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult PostPadraoView()
        {
            return View();
        }
    }
}