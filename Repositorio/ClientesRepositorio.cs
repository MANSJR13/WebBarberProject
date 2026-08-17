using System.Reflection.Metadata.Ecma335;
using WebBarber.Data;
using WebBarber.Models;

namespace WebBarber.Repositorio
{
    public class ClientesRepositorio : IClientesRepositorio
    {
        private readonly BancoContext _bancoContext;


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
        public ClientesModel ListarPorId(int id)
        {
            return _bancoContext.Clientes.FirstOrDefault(x => x.Id == id);
        }
        public List<ClientesModel> BuscarTodos()
        {
            return _bancoContext.Clientes.ToList();
        }

        public ClientesModel Atualizar(ClientesModel cliente)
        {
            ClientesModel clientesDB = ListarPorId(cliente.Id);
            if (clientesDB == null) throw new Exception("Houve um erro na atualização do cliente");

            clientesDB.Nome = cliente.Nome;
            clientesDB.Email = cliente.Email;
            clientesDB.Celular = cliente.Celular;

            _bancoContext.Clientes.Update(clientesDB);
            _bancoContext.SaveChanges();

            return clientesDB;
        }

        public bool Apagar(int id)
        {
            ClientesModel clientesDB = ListarPorId(id);
            if (clientesDB == null) throw new Exception("Houve um erro na Exclusão do cliente");

            _bancoContext.Clientes.Remove(clientesDB);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
