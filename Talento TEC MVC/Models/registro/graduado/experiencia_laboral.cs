using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Talento_TEC_MVC.Models.registro.graduado
{
    public class experiencia_laboral
    {
        [Required]
        [Display(Name = "Empresa (*)")]
        [DataType(DataType.Text)]
        public string empresa { get; set; }

        [Required]
        [Display(Name = "País (*)")]
        [DataType(DataType.Text)]
        public string paisEmpresa { get; set; }

        [Required]
        [Display(Name = "Año inicio (*)")]
        [DataType(DataType.Text)]
        public string annoInicio { get; set; }

        [Required]
        [Display(Name = "Año fin (*)")]
        [DataType(DataType.Text)]
        public string annoFin { get; set; }

        [Required]
        [Display(Name = "Cargo desempeñado (*)")]
        [DataType(DataType.Text)]
        public string cargo { get; set; }

/*-----------------------------------------------------------------------------------------*/

        [Required]
        [Display(Name = "Nombre de actividad (*)")]
        [DataType(DataType.Text)]
        public string nombreActividad { get; set; }

        [Required]
        [Display(Name = "Institución (*)")]
        [DataType(DataType.Text)]
        public string institucion { get; set; }

        [Required]
        [Display(Name = "País del curso (*)")]
        [DataType(DataType.Text)]
        public string paisCurso { get; set; }

        [Required]
        [Display(Name = "Año (*)")]
        [DataType(DataType.Text)]
        public string annoCurso { get; set; }


    }
}