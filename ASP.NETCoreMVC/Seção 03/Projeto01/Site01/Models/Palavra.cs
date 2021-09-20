using Site01.Library.Validation;
using System.ComponentModel.DataAnnotations;

namespace Site01.Models
{
    public class Palavra
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo 'Nome' deve ser preenchido!")]
        [MaxLength(30, ErrorMessage = "O campo Nome deve conter no máximo 30 caracteres!")]
        [UnicoNomePalavra]
        public string Nome { get; set; }

        // 1-Fácil, 2-Médio, 3-Difícil
        [Required(ErrorMessage = "Esse campo deve ser preenchido!")]
        public byte? Nivel { get; set; }
    }
}
