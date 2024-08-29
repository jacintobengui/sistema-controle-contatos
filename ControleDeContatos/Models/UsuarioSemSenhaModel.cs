using ControleDeContatos.Enums;
using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class UsuarioSemSenhaModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do usuário")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "Digite o login do usuário")]
        public string Login { get; set; } = string.Empty;

        [Required(ErrorMessage = "Digite o e-mail do usuário")]
        [EmailAddress(ErrorMessage = "O e-mail informdado não é válido!")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o perfil do usuário")]
        public PerfilEnum? Perfil { get; set; }
    }
}
