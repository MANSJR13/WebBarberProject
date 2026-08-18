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
    }
}
