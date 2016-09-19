using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Talento_TEC_MVC.Models.empresa
{
    public class NuevaOferta
    {
      //  [Required]
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

        [Required]
        [Display(Name = "Cantidad de plazas disponibles (*)")]
        [DataType(DataType.Text)]
        public string cantidadPlazas { get; set; }

        [Required]
        [Display(Name = "Fecha inicio de publicación (*)")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime fechaInicio { get; set; }

        [Required]
        [Display(Name = "Fecha fin de publicación (*)")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime fechaFin { get; set; }

        /* aca van las carreras */
        [Display(Name = "Carrera   (*)")]
        public carrerasDisponibles carreraOferta { get; set; }

        [Display(Name = "Especialidad  (*)")]
        public especialidadDisponibles especialidadOferta { get; set; }

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

        /*
        [Required]
        [Display(Name = "Adjuntar un archivo")]
        [DataType(DataType.Upload)]
        public string adjuntarArchivo { get; set; }
        */

        public static List<SelectListItem> getCarrerasValues()
        {
            return new List<SelectListItem>
            {
                new SelectListItem { Text ="Administracion de Empresas", Value="ADMINISTRACION_EMPRESAS" }
            };
        }
        public static List<SelectListItem> getEspecialidadesValues()
        {
            return new List<SelectListItem>
            {
                new SelectListItem { Text="Licenciatura en Contaduría Pública", Value="LICENCIATURA_CONTADURIA_PUBLICA" },
                new SelectListItem { Text = "Licenciatura en Mercadeo", Value = "LICENCIATURA_MERCADEO" },
                new SelectListItem { Text = "Licenciatura en Administración Financiera", Value = "LICENCIATURA_ADMINISTRACION_FINANCIERA" },
                new SelectListItem { Text = "Maestría en Administración de Empresas", Value = "MAESTRIA_ADMINISTRACION_EMPRESAS" },
                new SelectListItem { Text = "Maestría Dirección de Empresas", Value = "MAESTRIA_DIRECCION_EMPRESAS" },
                new SelectListItem { Text = "Maestría en Gerencia de Proyectos", Value = "MAESTRIA_GERENCIA_PROYECTOS" },
                new SelectListItem { Text = "Doctorado en Dirección de Empresas", Value = "DOCTORADO_DIRECCION_EMPRESAS" }
            };
        }
        public enum carrerasDisponibles { ADMINISTRACION_EMPRESAS }
        public enum especialidadDisponibles
        {
            LICENCIATURA_CONTADURIA_PUBLICA,
            LICENCIATURA_MERCADEO,
            LICENCIATURA_ADMINISTRACION_FINANCIERA,
            MAESTRIA_ADMINISTRACION_EMPRESAS,
            MAESTRIA_DIRECCION_EMPRESAS,
            MAESTRIA_GERENCIA_PROYECTOS,
            DOCTORADO_DIRECCION_EMPRESAS
        }
    }
}