using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do contato")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "Digite o e-mail do contato")]
        [EmailAddress(ErrorMessage = "O e-mail informdado não é válido!")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Digite o celular do contato")]
        [Phone(ErrorMessage = "O celular informado não é válido")]
        public string Celular { get; set; } = string.Empty;

        public int? UsuarioId { get; set; }

        public UsuarioModel? Usuario { get; set; }
    }
}
