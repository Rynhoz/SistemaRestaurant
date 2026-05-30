using Microsoft.AspNetCore.Mvc;

namespace Proyecto.API._3._Controllers
{
    public class VentasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
