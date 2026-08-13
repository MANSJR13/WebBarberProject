using Microsoft.AspNetCore.Mvc;
using WebBarber.Models;
using WebBarber.Repositorio;

namespace WebBarber.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClientesRepositorio _clientesRepositorio;
        public ClientesController(IClientesRepositorio clientesRepositorio)
        {
            _clientesRepositorio = clientesRepositorio;
        }
        public IActionResult Index()
        {
            var contatos = _clientesRepositorio.BuscarTodos();
            return View(contatos);
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

        [HttpPost]
        public IActionResult Criar(ClientesModel cliente)
        {

            _clientesRepositorio.Adicionar(cliente);
            return RedirectToAction("Index");

        }
    }
}
