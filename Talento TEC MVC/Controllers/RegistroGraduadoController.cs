using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Talento_TEC_MVC.Models.registro.graduado;

namespace Talento_TEC_MVC.Controllers
{
    public class RegistroGraduadoController : Controller
    {

        public ActionResult datos_personales()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult datos_personales(datos_personales model)
        {
            //Response.Write(model.fechaNacimiento);
            //return View();
            return RedirectToAction("informacion_contacto", "registrograduado");

        }

        public ActionResult informacion_contacto()
        {
            return View();

        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult informacion_contacto(informacion_contacto model)
        {
            return RedirectToAction("educacion_formal","registrograduado");
        }

        public ActionResult educacion_formal()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult educacion_formal(educacion_formal model)
        {
            return RedirectToAction("dominio_idioma", "registrograduado");
        }

        public ActionResult dominio_idioma()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult dominio_idioma(dominio_idioma model)
        {
            return RedirectToAction("experiencia_laboral", "registrograduado");
        }

        public ActionResult experiencia_laboral()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult experiencia_laboral(experiencia_laboral model)
        {
            return RedirectToAction("conocimientos_referencias", "registrograduado");
        }

        public ActionResult conocimientos_referencias()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult conocimientos_referencias(conocimientos_referencias model)
        {
            return RedirectToAction("finalizar", "registrograduado");
        }

        public ActionResult finalizar()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult finalizar(string Url)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
