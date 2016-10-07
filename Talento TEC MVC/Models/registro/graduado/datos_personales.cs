using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Talento_TEC_MVC.Models.registro.graduado
{
    public class datos_personales
    {
        [Required]
        [Display(Name = "Primer Apellido")]
        [DataType(DataType.Text)]
        public string primerApellido { get; set; }

        [Required]
        [Display(Name = "Segundo Apellido")]
        [DataType(DataType.Text)]
        public string segundoApellido { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        [DataType(DataType.Text)]
        public string nombreGraduado { get; set; }

        [Required]
        [Display(Name = "Identificación")]
        [DataType(DataType.Text)]
        public string identificacion { get; set; }




    }
}