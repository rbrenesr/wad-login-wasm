using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Shared.DTOs
{
    public  class UserInfoDTO
    {
        
        [EmailAddress(ErrorMessage = "Por favor, introduzca una dirección de correo electrónico válida.")]
        public string Email { get; set; } = null!;
        
        [Required(ErrorMessage = "Por favor, introduzca la contraseña.")]
        public string Password { get; set; } = null!;

        [Required(ErrorMessage = "Por favor, introduzca el nombre de usuario.")]
        public string UserName { get; set; } = null!;

        public string BD { get; set; } =  null!;

        public int UserId { get; set; }
    }
}
