using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Site01.Models
{
    public class Usuario
    {

        [Required(ErrorMessage = "Esse campo deve ser preenchido!")]
        [MaxLength(50, ErrorMessage = "O campo Nome deve conter no máximo 50 caracteres!")]
        [EmailAddress(ErrorMessage = "O campo E-mail informado é inválido")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Esse campo deve ser preenchido!")]
        [MaxLength(70, ErrorMessage = "O campo Email deve conter no máximo 70 caracteres!")]
        public string Senha { get; set; }
    }
}
