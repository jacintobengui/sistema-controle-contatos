using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class RedefinirSenhaModel
    {
        [Required(ErrorMessage = "Digite o login do usuário")]
        public string Login { get; set; } = string.Empty;

        [Required(ErrorMessage = "Digite o e-mail do usuário")]
        [EmailAddress(ErrorMessage = "E-mail inválido!")]
        public string Email { get; set; } = string.Empty;
    }
}

