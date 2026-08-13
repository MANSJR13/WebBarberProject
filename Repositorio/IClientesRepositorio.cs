using WebBarber.Models;

namespace WebBarber.Repositorio
{
    public interface IClientesRepositorio
    {
        ClientesModel ListarPorId(int id);
        List<ClientesModel> BuscarTodos();
        ClientesModel Adicionar(ClientesModel cliente);

        ClientesModel Atualizar(ClientesModel cliente);

        bool Apagar(int id);
    }
}
