using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Shared.Entities
{
    internal class Usuario
    {
        public int Id { get; set; }


        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        [DefaultValue("")]
        [Required(ErrorMessage = "El UserName es requerido")]
        public string UserName { get; set; } = null!;

        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        [DefaultValue("")]
        [Required(ErrorMessage = "La contraseña es requerido")]
        [PasswordPropertyText]
        public string Password { get; set; } = null!;



        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        [DefaultValue("")]
        [Required(ErrorMessage = "El email es requerido")]
        [EmailAddress]
        public string Email { get; set; } = null!;


        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        [DefaultValue("")]
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Name { get; set; } = null!;

        [MaxLength(20)]
        [Column(TypeName = "varchar(20)")]
        [DefaultValue("+000-00000000")]
        [Phone]
        public string Telefono { get; set; } = null!;
    }
}
