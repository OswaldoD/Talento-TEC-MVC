using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Talento_TEC_MVC.Models.admin;

namespace Talento_TEC_MVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult add_date()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult add_date(nueva_fecha model)
        {
            return View();
        }

        public ActionResult info_date()
        {
            return View();
        }

        public ActionResult new_email()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public ActionResult new_email(new_email model)
        {
            
            return View();
        }

    }
}