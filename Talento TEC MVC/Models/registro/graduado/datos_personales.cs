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
  
        [Display(Name = "Primer apellido (*)")]
        [DataType(DataType.Text)]
        public string primerApellido { get; set; }

     
        [Display(Name = "Segundo apellido (*)")]
        [DataType(DataType.Text)]
        public string segundoApellido { get; set; }

 
        [Display(Name = "Nombre (*)")]
        [DataType(DataType.Text)]
        public string nombreGraduado { get; set; }

    
        [Display(Name = "Fecha de nacimiento (*)")]
        [DataType(DataType.Text)]
        public string fechaNacimiento { get; set; }

      
        [Display(Name = "País de nacimiento (*)")]
        [DataType(DataType.Text)]
        public string paisNacimiento { get; set; }

      
        [Display(Name = "Nacionalidad (*)")]
        [DataType(DataType.Text)]
        public string nacionalidad { get; set; }

        
        [Display(Name = "Tipo de identificación (*)")]
        [DataType(DataType.Text)]
        public string tipoID { get; set; }

       
        [Display(Name = "Identificación (*)")]
        [DataType(DataType.Text)]
        public string identificacion { get; set; }

       
        [Display(Name = "Género (*)")]
        [DataType(DataType.Text)]
        public string sexo { get; set; }

        
        [Display(Name = "Carné TEC")]
        [DataType(DataType.Text)]
        public string carne { get; set; }

    }
}