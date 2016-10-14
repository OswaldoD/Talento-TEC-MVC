using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Talento_TEC_MVC.Models.registro.graduado
{
    public class informacion_contacto
    {
        [Required]
        [Display(Name = "País de residencia")]
        [DataType(DataType.Text)]
        public string paisResidencia { get; set; }

        [Required]
        [Display(Name = "Provincia")]
        [DataType(DataType.Text)]
        public string provincia { get; set; }

        [Required]
        [Display(Name = "Dirección exacta")]
        [DataType(DataType.Text)]
        public string direccion { get; set; }

        [Required]
        [Display(Name = "Teléfono")]
        [DataType(DataType.Text)]
        public string telefono { get; set; }

        [Required]
        [Display(Name = "Correo electrónico")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Required]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required]
        [Display(Name = "Confirmar contraseña")]
        [DataType(DataType.Password)]
        public string confirmPassword { get; set; }

    }
}