using Microsoft.AspNetCore.Mvc;
using WebBarber.Models;
using WebBarber.Repositorio;

namespace WebBarber.Controllers
{
    public class ServicosController : Controller
    {
        private readonly IServicosRepositorio _servicosRepositorio;

        public ServicosController(IServicosRepositorio servicosRepositorio)
        {
            _servicosRepositorio = servicosRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Criar()
        {         
            return View();
        }
    }
}
