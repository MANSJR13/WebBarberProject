using WebBarber.Models.Enums;

namespace WebBarber.Models
{
    public class ServicosModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public DateTime Duracao { get; set; }
        public StatusServico Status { get; set; }
    }
}
