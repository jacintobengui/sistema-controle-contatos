using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class AlterarSenhaModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite a senha atual do usuário")]
        public string SenhaAtual { get; set; } = string.Empty;

        [Required(ErrorMessage = "Digite a nova senha do usuário")]
        public string NovaSenha { get; set; } = string.Empty;

        [Required(ErrorMessage = "Confirme a nova senha do usuário")]
        [Compare("NovaSenha", ErrorMessage = "A Senha não confere com a nova senha")]
        public string ConfirmarNovaSenha { get; set; } = string.Empty;
    }
}
