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
        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult Inativar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(ServicosModel servico)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _servicosRepositorio.Adicionar(servico);
                    TempData["MensagemSucesso"] = "Serviço cadastrado com sucesso!";
                    return RedirectToAction("Index");
                }
                return View(servico);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos cadastrar seu serviço, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
