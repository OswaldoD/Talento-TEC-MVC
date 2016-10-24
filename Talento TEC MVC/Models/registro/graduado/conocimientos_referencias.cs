using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Talento_TEC_MVC.Models.registro.graduado
{
    public class conocimientos_referencias
    {
        [Required]
        [Display(Name = "Describa sus conocimientos (*)")]
        [DataType(DataType.MultilineText)]
        public string descripcionConocimientos { get; set; }

        [Required]
        [Display(Name = "Nombre completo (*)")]
        [DataType(DataType.Text)]
        public string nombreRef { get; set; }

        [Required]
        [Display(Name = "Puesto (*)")]
        [DataType(DataType.Text)]
        public string puestoRef { get; set; }

        [Required]
        [Display(Name = "Correo electrónico (*)")]
        [DataType(DataType.EmailAddress)]
        public string emailRef { get; set; }

        [Required]
        [Display(Name = "Teléfono (*)")]
        [DataType(DataType.Text)]
        public string telRef { get; set; }
    }
}