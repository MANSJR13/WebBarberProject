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
            ClientesModel cliente = _clientesRepositorio.ListarPorId(id);
            return View(cliente);
        }
        public IActionResult ApagarConfirmar(int id)
        {
            ClientesModel cliente = _clientesRepositorio.ListarPorId(id);
            return View(cliente);
        }

        public IActionResult Apagar(int id)
        {
            try { 
                bool apagado = _clientesRepositorio.Apagar(id);
                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Cliente apagado com sucesso!";
                }
                else
                {
                    TempData["MensagemErro"] = "Ops, não conseguimos apagar seu cliente!";
                }
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos apagar seu cliente, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Criar(ClientesModel cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _clientesRepositorio.Adicionar(cliente);
                    TempData["MensagemSucesso"] = "Cliente cadastrado com sucesso!";
                    return RedirectToAction("Index");
                }
                return View(cliente);

            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos cadastrar seu cliente, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Alterar(ClientesModel clientes)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _clientesRepositorio.Atualizar(clientes);
                    TempData["MensagemSucesso"] = "Cliente alterado com sucesso!";
                    return RedirectToAction("Index");
                }
                return View("Editar", clientes);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos alterar seu cliente, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");

            }
        }
    }
}
