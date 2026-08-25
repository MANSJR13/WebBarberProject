using WebBarber.Data;
using WebBarber.Models;

namespace WebBarber.Repositorio
{
    public class ServicosRepositorio : IServicosRepositorio
    {
        private readonly BancoContext _bancoContext;

        public ServicosRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public ServicosModel Adicionar(ServicosModel servico)
        {
            _bancoContext.Servicos.Add(servico);
            _bancoContext.SaveChanges();

            return servico;
        }

        public bool Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public ServicosModel Atualizar(ServicosModel servico)
        {
            throw new NotImplementedException();
        }

        public List<ServicosModel> BuscarTodos()
        {
            return _bancoContext.Servicos.ToList(); ;
        }

        public ServicosModel ListarPorId(int id)
        {
            return _bancoContext.Servicos.FirstOrDefault(x => x.Id == id); ;
        }
    }
}
