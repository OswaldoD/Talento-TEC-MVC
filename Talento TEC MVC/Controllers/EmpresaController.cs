using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Talento_TEC_MVC.Models.registro.empresa;

namespace Talento_TEC_MVC.Controllers
{
    public class EmpresaController : Controller
    {
        // GET: empresa
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index_Empresa()
        {
            return View();
        }

        public ActionResult Agregar_Oferta()
        {
            return View();
        }
        
        // POST: empresa/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}
