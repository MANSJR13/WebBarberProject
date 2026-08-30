using WebBarber.Data;
using WebBarber.Models;
using WebBarber.Models.Enums;

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

       
        public ServicosModel Atualizar(ServicosModel servico)
        {
            var servicoDB = ListarPorId(servico.Id);
            servicoDB.Nome = servico.Nome;
            servicoDB.Descricao = servico.Descricao;
            servicoDB.Preco = servico.Preco;
            servicoDB.Duracao = servico.Duracao;
            servicoDB.Status = servico.Status;

            _bancoContext.Servicos.Update(servicoDB);
            _bancoContext.SaveChanges();

            return servicoDB;
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
