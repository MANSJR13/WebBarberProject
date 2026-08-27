using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using WebBarber.Models;

namespace WebBarber.Repositorio
{
    public interface IServicosRepositorio
    {

        ServicosModel ListarPorId(int id);
        List<ServicosModel> BuscarTodos();
        ServicosModel Adicionar(ServicosModel servico);

        ServicosModel Atualizar(ServicosModel servico);
 
        bool Apagar(int id);
    }
}
