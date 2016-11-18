using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Talento_TEC_MVC.Models.registro.graduado
{
    public class Experience
    {
        public string id { get; set; }
        public string empresa { get; set; }
        public string cargo { get; set; }
        public string pais { get; set; }
        public string annoInicio { get; set; }
        public string annoFin { get; set; }
    }
}