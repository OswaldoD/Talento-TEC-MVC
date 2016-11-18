using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Talento_TEC_MVC.Models.registro.graduado
{
    public class conocimientos_referencias
    {
       
        [Display(Name = "Describa sus conocimientos (*)")]
        [DataType(DataType.MultilineText)]
        public string descripcionConocimientos { get; set; }

        
        [Display(Name = "Nombre completo (*)")]
        [DataType(DataType.Text)]
        public string nombreRef { get; set; }

        
        [Display(Name = "Puesto (*)")]
        [DataType(DataType.Text)]
        public string puestoRef { get; set; }

       
        [Display(Name = "Correo electrónico (*)")]
        [DataType(DataType.EmailAddress)]
        public string emailRef { get; set; }

       
        [Display(Name = "Teléfono (*)")]
        [DataType(DataType.Text)]
        public string telRef { get; set; }

        [Display(Name = "Send")]
        [DataType(DataType.Text)]
        public string sendInfo { get; set; }
    }
}