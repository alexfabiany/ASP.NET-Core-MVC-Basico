using System.ComponentModel.DataAnnotations;

namespace Site01.Models
{
    public class Contato
    {
        [Required(ErrorMessage = "Esse campo deve ser preenchido!")]
        [MaxLength(50, ErrorMessage = "O campo Nome deve conter no máximo 50 caracteres!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Esse campo deve ser preenchido!")]
        [MaxLength(70, ErrorMessage = "O campo Email deve conter no máximo 70 caracteres!")]
        [EmailAddress(ErrorMessage = "O campo E-mail informado é inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Esse campo deve ser preenchido!")]
        [MaxLength(70, ErrorMessage = "O campo Assunto deve conter no máximo 70 caracteres!")]
        public string Assunto { get; set; }

        [Required(ErrorMessage = "Esse campo deve ser preenchido!")]
        [MaxLength(2000, ErrorMessage = "O campo 'Mensagem' deve conter no máximo 2.000 caracteres!")]
        public string Mensagem { get; set; }
    }
}
