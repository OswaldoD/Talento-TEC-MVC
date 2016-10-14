using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Talento_TEC_MVC.Models.registro.graduado
{
    public class educacion_formal
    {
        [Required]
        [Display(Name = "Institución")]
        [DataType(DataType.Text)]
        public string institucion { get; set; }

        [Required]
        [Display(Name = "País")]
        [DataType(DataType.Text)]
        public string paisTitulo { get; set; }

        [Required]
        [Display(Name = "Año de graduación")]
        [DataType(DataType.Text)]
        public string annoGraduacion { get; set; }

        [Required]
        [Display(Name = "Título obtenido")]
        [DataType(DataType.Text)]
        public string titulo { get; set; }

        [Required]
        [Display(Name = "Grado")]
        [DataType(DataType.Text)]
        public string grado { get; set; }
    }
}