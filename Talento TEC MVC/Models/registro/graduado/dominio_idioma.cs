using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Talento_TEC_MVC.Models.registro.graduado
{
    public class dominio_idioma
    {
        
        [Display(Name = "Idioma (*)")]
        [DataType(DataType.Text)]
        public string idioma { get; set; }

        
        [Display(Name = "Nivel de lectura (*)")]
        [DataType(DataType.Text)]
        public string nivelLectura { get; set; }

       
        [Display(Name = "Nivel de escritura (*)")]
        [DataType(DataType.Text)]
        public string nivelEscritura { get; set; }

        
        [Display(Name = "Nivel oral (*)")]
        [DataType(DataType.Text)]
        public string nivelOral { get; set; }
    }
}