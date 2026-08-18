using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using WebBarber.Models;

namespace WebBarber.Repositorio
{
    public interface IServicosRepositorio
    {
       ServicosModel Adicionar (ServicosModel servico);
    }
}
