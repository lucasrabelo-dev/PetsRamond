using Microsoft.AspNetCore.Mvc;

namespace PetsRamond.Controllers
{
    public class ContaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
