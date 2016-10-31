using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Talento_TEC_MVC.Controllers
{
    public class GraduadoController : Controller
    {
        // GET: Graduado
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ver_ofertas()
        {
            Session["nombre"] = "Cuenta Prueba";
            Session["TipoCuenta"] = "Graduado";
            return View();
        }
    }
}