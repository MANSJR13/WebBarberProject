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
        public IActionResult Editar(int id)
        {
            ClientesModel cliente =_clientesRepositorio.ListarPorId(id);
            return View(cliente);
        }
        public IActionResult ApagarConfirmar(int id)
        {
            ClientesModel cliente = _clientesRepositorio.ListarPorId(id);
            return View(cliente);
        }

        public IActionResult Apagar(int id)
        {
            _clientesRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Criar(ClientesModel cliente)
        {

            _clientesRepositorio.Adicionar(cliente);
            return RedirectToAction("Index");

        }

        [HttpPost]
        public IActionResult Alterar(ClientesModel clientes)
        {

            _clientesRepositorio.Atualizar(clientes);
            return RedirectToAction("Index");

        }
    }
}
