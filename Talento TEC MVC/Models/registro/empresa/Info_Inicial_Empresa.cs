using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Talento_TEC_MVC.Models.registro.empresa
{
    public class Info_Inicial_Empresa
    {

        [Required]
        [Display(Name = "Nombre comercial de la empresa  (*)")]
        [DataType(DataType.Text)]
        public string nombre { get; set; }
        
        [Required]
        [Display(Name = "Cédula jurídica o identificación  (*)")]
        [DataType(DataType.Text)]
        public string cedula { get; set; }
        /*
        [Required]
        [Display(Name = "Razón social de la empresa  (*)")]
        [DataType(DataType.Text)]
        public string razon_social { get; set; }*/

        [Required]
        [Display(Name = "Dirección  (*)")]
        [DataType(DataType.Text)]
        public string direccion { get; set; }

        [Required]
        [Display(Name = "Ciudad  (*)")]
        [DataType(DataType.Text)]
        public string nombreEmpresa { get; set; }

        [Required]
        [Display(Name = "País  (*)")]
        [DataType(DataType.Text)]
        public string pais { get; set; }

        [Required]
        [Display(Name = "Teléfono  (*)")]
        [DataType(DataType.Text)]
        public string telefono { get; set; }

        [Required]
        [Display(Name = "Correo electrónico  (*)")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Required]
        [Display(Name = "Página web  (*)")]
        [DataType(DataType.Text)]
        public string pagina_web { get; set; }

        //[Display(Name ="Persona de contacto")]

        [Required]
        [Display(Name = "Nombre  (*)")]
        [DataType(DataType.Text)]
        public string nombre_contacto { get; set; }

        [Required]
        [Display(Name = "Cargo  (*)")]
        [DataType(DataType.Text)]
        public string cargo_contacto { get; set; }

        [Required]
        [Display(Name = "Correo electrónico  (*)")]
        [DataType(DataType.Text)]
        public string email_contacto { get; set; }

        [Required]
        [Display(Name = "Teléfono  (*)")]
        [DataType(DataType.Text)]
        public string tel_contacto { get; set; }
 
    }
}