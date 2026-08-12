using Microsoft.AspNetCore.Mvc;

namespace WebBarber.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult ApagarConfirmar()
        {
            return View();
        }

    }
}
