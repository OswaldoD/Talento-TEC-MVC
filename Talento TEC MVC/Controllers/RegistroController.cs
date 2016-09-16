using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Talento_TEC_MVC.Controllers
{
    public class RegistroController : Controller
    {
        /*----------------------------------------------------------*/
        public ActionResult RegistroEleccion()
        {
            return View();

        }
        public ActionResult registro_inicial_estudiante()
        {
            return View();

        }
        public ActionResult registro_inicial_empresa()
        {
            return View();

        }
        public ActionResult descripcion_empresa()
        {
            return View();

        }
        public ActionResult credenciales_empresa()
        {
            return View();

        }
        public ActionResult finalizar_empresa()
        {
            return View();

        }
        public ActionResult registro_inicial_graduado()
        {
            return View();

        }

        /*----------------------------------------------------------*/

        // GET: Registro
        public ActionResult Index()
        {
            return View();
        }

        // GET: Registro/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Registro/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Registro/Create
        [HttpPost]
        public void Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Response.Write("Hola");
                //return RedirectToAction("Index");
            }
            catch
            {
                //return View();
            }
        }

        // GET: Registro/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Registro/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Registro/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Registro/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
