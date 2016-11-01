using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Talento_TEC_MVC.Models.admin
{
    public class new_email
    {
        [Display(Name = "Destinatarios")]
        [DataType(DataType.Text)]
        public string destinatarios { get; set; }

        [Display(Name = "Asunto")]
        [DataType(DataType.Text)]
        public string asunto{ get; set; }

        [Display(Name = "Mensaje")]
        [DataType(DataType.MultilineText)]
        public string mensaje { get; set; }
    }
}