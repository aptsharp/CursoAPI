using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Curso.API.Models.Usuarios
{
    public class RegistrarViewModelInput
    {
        [Required(ErrorMessage ="O login é obrigatorio")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Email obrigatorio")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha obrigatorio")]
        public string Senha { get; set; }

    }
}
