using Azure;
using System.ComponentModel.DataAnnotations;
using WebBarber.Models.Enums;

namespace WebBarber.Models
{
    public class ServicosModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome do serviço")]
        [StringLength(100,MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite a descrição do serviço")]
        [StringLength(500, ErrorMessage = "A descrição deve ter no máximo 500 caracteres")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Digite o preço do serviço")]
        [Range(0.01, 9999.99, ErrorMessage = "O preço deve estar entre R$ 0, 01 e R$ 9.999, 99")]
        public decimal Preco { get; set; }
        [Required(ErrorMessage = "Informe a duração do serviço")]
        public TimeSpan Duracao { get; set; }
        [Required(ErrorMessage = "Selecione o status do serviço")]
        public StatusServico Status { get; set; }
    }
}
