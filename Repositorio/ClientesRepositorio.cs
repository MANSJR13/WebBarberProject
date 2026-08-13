using System.Reflection.Metadata.Ecma335;
using WebBarber.Data;
using WebBarber.Models;

namespace WebBarber.Repositorio
{
    public class ClientesRepositorio : IClientesRepositorio
    {
        private readonly BancoContext _bancoContext;

        public List<ClientesModel> BuscarTodos()
        {
            return _bancoContext.Clientes.ToList();
        }
        public ClientesRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public ClientesModel Adicionar(ClientesModel cliente)
        {
            _bancoContext.Clientes.Add(cliente);
            _bancoContext.SaveChanges();
            return cliente;
        }

     
    }
}
