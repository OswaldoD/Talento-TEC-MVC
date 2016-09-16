using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Talento_TEC_MVC.Models
{
    public class LoginNavBar
    {
       // [Required]
        [Display(Name = "Nombre de Usuario")]
        [DataType(DataType.Text)]
        public string username { get; set; }

//        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string password { get; set; }

        [Display(Name = "¿Recordar cuenta?")]
        public bool rememberme { get; set; }

        [Display(Name = "¿No tiene una cuenta?")]
        public string registro { get; set; }
    }
}