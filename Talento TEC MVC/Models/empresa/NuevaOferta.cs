using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Talento_TEC_MVC.Models.empresa
{
    public class NuevaOferta
    {
        [Required]
        [Display(Name = "Nombre de la empresa  (*)")]
        [DataType(DataType.Text)]
        public string nombreEmpresa { get; set; }

        [Display(Name = "¿Confidencial?")]
        public bool confidencial { get; set; }

        [Required]
        [Display(Name = "Nombre del puesto  (*)")]
        [DataType(DataType.Text)]
        public string nombrePuesto { get; set; }

        [Required]
        [Display(Name = "Descripción del puesto  (*)")]
        [DataType(DataType.MultilineText)]
        public string descripcionPuesto { get; set; }

        [Required]
        [Display(Name = "Requisitos del puesto  (*)")]
        [DataType(DataType.MultilineText)]
        public string requisitosPuesto { get; set; }

        [Required]
        [Display(Name = "Monto mensual ofrecido  (*)")]
        [DataType(DataType.Currency)]
        public string montoMensual { get; set; }

        [Display(Name = "Colones")]
        public bool pagoColones { get; set; }

        [Display(Name = "Dolares")]
        public bool pagoDolares { get; set; }

        /* aca van las carreras */

        [Required]
        [Display(Name = "Nombre de contacto  (*)")]
        [DataType(DataType.Text)]
        public string nombreContacto { get; set; }

        [Required]
        [Display(Name = "Correo de contacto  (*)")]
        [DataType(DataType.EmailAddress)]
        public string emailContacto { get; set; }

        [Required]
        [Display(Name = "Teléfono de contacto  (*)")]
        [DataType(DataType.Text)]
        public string telContacto { get; set; }

        [Required]
        [Display(Name = "Adjuntar un archivo")]
        [DataType(DataType.Upload)]
        public string adjuntarArchivo { get; set; }

    }
}