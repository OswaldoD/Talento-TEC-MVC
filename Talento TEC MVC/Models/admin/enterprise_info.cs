using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Talento_TEC_MVC.Models.admin
{
    public class enterprise_info
    {
        [Display(Name = "Nombre Empresa")]
        [DataType(DataType.Text)]
        public string nombreEmpresa { get; set; }

        [Display(Name = "Cédula Empresa")]
        [DataType(DataType.Text)]
        public string cedulaEmpresa { get; set; }

        [Display(Name = "País")]
        [DataType(DataType.Text)]
        public string pais { get; set; }

        [Display(Name = "Provincia")]
        [DataType(DataType.Text)]
        public string provincia { get; set; }

        [Display(Name = "Dirección")]
        [DataType(DataType.MultilineText)]
        public string direccion { get; set; }

        [Display(Name = "Descripción de la Empresa")]
        [DataType(DataType.MultilineText)]
        public string descripcion { get; set; }

        [Display(Name = "Teléfono Empresa")]
        [DataType(DataType.Text)]
        public string telefono { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Display(Name = "Página web")]
        [DataType(DataType.Text)]
        public string pagina_web { get; set; }

        [Display(Name = "Sectores Productivos")]
        [DataType(DataType.MultilineText)]
        public string sectores_productivos { get; set; }

        [Display(Name = "Nombre Contacto")]
        [DataType(DataType.Text)]
        public string nombreContacto { get; set; }

        [Display(Name = "Cargo Contacto")]
        [DataType(DataType.Text)]
        public string cargoContacto { get; set; }

        [Display(Name = "Teléfono Contacto")]
        [DataType(DataType.Text)]
        public string telefonoContacto { get; set; }

        [Display(Name = "Email Contacto")]
        [DataType(DataType.Text)]
        public string emailContacto { get; set; }
    }
}