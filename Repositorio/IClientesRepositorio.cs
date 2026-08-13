using WebBarber.Models;

namespace WebBarber.Repositorio
{
    public interface IClientesRepositorio
    {

        List<ClientesModel> BuscarTodos();
        ClientesModel Adicionar(ClientesModel cliente);
    }
}
