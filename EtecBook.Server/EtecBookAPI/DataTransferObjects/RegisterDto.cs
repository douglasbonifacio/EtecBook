using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EtecBookAPI.DataTransferObjects
{
    public class RegisterDto
    {
        [Required(ErrorMessage = "Informe o Nome do Usuário")]
        [StringLength(60, ErrorMessage = "O nome deve possuir no máximo 60 caracteres")]
       public string Name { get; set; } 
       [Required(ErrorMessage = "Informe o email do usuário")]
       [EmailAddress(ErrorMessage = "Informe um Email Válido")]
       [StringLength(100, ErrorMessage = "O email deve possuir no máximo 100 caracteres")]
       public string Email { get; set; }
       [Required(ErrorMessage = "Informe a Senha de Acesso")]
       [StringLength(20, MinimumLength = 6, ErrorMessage = "A Senha deve possuir no minimo 6 caracteres e no máximo 20 caracteres")]
       public string Password {get; set; }
    }
}