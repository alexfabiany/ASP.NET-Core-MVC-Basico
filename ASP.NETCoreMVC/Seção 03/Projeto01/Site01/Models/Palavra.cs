using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Models
{
    public class Palavra
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Esse campo deve ser preenchido!")]
        [MaxLength(50, ErrorMessage = "O campo Nome deve conter no máximo 30 caracteres!")]
        public string Nome { get; set; }

        // 1-Fácil, 2-Médio, 3-Difícil
        [Required(ErrorMessage = "Esse campo deve ser preenchido!")]
        public byte? Nivel { get; set; }
    }
}
