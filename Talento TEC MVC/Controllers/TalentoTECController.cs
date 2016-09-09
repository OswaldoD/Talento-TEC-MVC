using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Talento_TEC_MVC.Controllers
{
    public class TalentoTECController : Controller
    {
        // GET: TalentoTEC
        public ActionResult Index()
        {
            return View();
        }

        // GET: TalentoTEC/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TalentoTEC/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TalentoTEC/Create
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

        // GET: TalentoTEC/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TalentoTEC/Edit/5
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

        // GET: TalentoTEC/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TalentoTEC/Delete/5
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
