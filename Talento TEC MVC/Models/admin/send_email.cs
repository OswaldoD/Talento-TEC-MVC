using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Talento_TEC_MVC.Models.admin
{
    public class send_email
    {
        public string destinatarios { get; set; }
        public string asunto { get; set; }
        public string mensaje { get; set; }
    }
}