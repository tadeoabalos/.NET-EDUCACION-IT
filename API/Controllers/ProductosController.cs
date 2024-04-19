using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
