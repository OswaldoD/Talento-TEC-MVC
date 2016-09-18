using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Talento_TEC_MVC.Models.registro.empresa
{
    public class credenciales_empresa
    {
        [Required]
        [Display(Name = "Nombre de usuario  (*)")]
        [DataType(DataType.Text)]
        public string nombreUsuario { get; set; }

        [Required]
        [Display(Name = "Contraseña  (*)")]
        [DataType(DataType.Password)]
        public string contrasenna { get; set; }

        [Required]
        [Display(Name = "Comprobar contraseña  (*)")]
        [DataType(DataType.Password)]
        public string comprobarContrasenna { get; set; }

    }
}