using System.ComponentModel.DataAnnotations;

namespace WebBarber.Models
{
    public class ClientesModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome do cliente")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite o e-mail do cliente")]
        [EmailAddress(ErrorMessage = "Digite um e-mail válido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Digite o celular do cliente")]
        [RegularExpression(@"^\(?[1-9]{2}\)?\s?9[0-9]{4}-?[0-9]{4}$",
        ErrorMessage = "Digite um número de celular válido")]
        public string Celular { get; set; }

    }
}
