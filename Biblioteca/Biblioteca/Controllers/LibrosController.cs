using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers
{
    public class LibrosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
