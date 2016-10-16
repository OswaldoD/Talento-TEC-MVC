using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Talento_TEC_MVC.Models.registro.graduado;

namespace Talento_TEC_MVC.Controllers
{
    public class RegistroEstudianteController : Controller
    {
        // GET: RegistroEstudiante
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult datos_personales()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult datos_personales(datos_personales model)
        {
            return View();
        }

        public ActionResult informacion_contacto()
        {
            return View();
        }

        public ActionResult educacion_formal()
        {
            return View();
        }

        public ActionResult dominio_idioma()
        {
            return View();
        }

        public ActionResult experiencia_laboral()
        {
            return View();
        }

        public ActionResult conocimientos_referencias()
        {
            return View();
        }
    }
}