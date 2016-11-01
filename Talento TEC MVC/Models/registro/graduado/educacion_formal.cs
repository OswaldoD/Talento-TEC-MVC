using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Talento_TEC_MVC.Models.registro.graduado
{
    public class educacion_formal
    {
        
        [Display(Name = "Institución (*)")]
        [DataType(DataType.Text)]
        public string institucion { get; set; }

        [Display(Name = "País (*)")]
        [DataType(DataType.Text)]
        public string paisTitulo { get; set; }

        [Display(Name = "Año de graduación (*)")]
        [DataType(DataType.Text)]
        public string annoGraduacion { get; set; }

        [Display(Name = "Título obtenido (*)")]
        [DataType(DataType.Text)]
        public string nombreTitulo { get; set; }

        [Display(Name = "Grado (*)")]
        [DataType(DataType.Text)]
        public string grado { get; set; }
    }
}