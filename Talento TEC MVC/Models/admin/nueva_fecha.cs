using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Talento_TEC_MVC.Models.admin
{
    public class nueva_fecha
    {

        [Display(Name = "Fecha (*): ")]
        [DataType(DataType.Text)]
        public string fecha { get; set; }

        [Display(Name = "Nombre Actividad (*): ")]
        [DataType(DataType.MultilineText)]
        public string nombreActividad { get; set; }
    }
}