using Microsoft.AspNetCore.Mvc;
using WebBarber.Models;
using WebBarber.Models.Enums;
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
            var servicos = _servicosRepositorio.BuscarTodos();
            return View(servicos);
        }

        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar(int id)
        {
            var servico = _servicosRepositorio.ListarPorId(id);
            return View(servico);
        }

        public IActionResult ExcluirConfirmacao(int id)
        {
            var servico = _servicosRepositorio.ListarPorId(id);
            return View(servico);
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

        
        public IActionResult AlterarStatus(int id)
        {
            var servico = _servicosRepositorio.ListarPorId(id);

            if (servico == null)
            {
                return NotFound();
            }

            if (servico.Status == StatusServico.Ativo)
            {
                servico.Status = StatusServico.Inativo;
            }
            else
            {
                servico.Status = StatusServico.Ativo;
            }

            _servicosRepositorio.Atualizar(servico);

            return RedirectToAction("Index");

        }
    }
}
