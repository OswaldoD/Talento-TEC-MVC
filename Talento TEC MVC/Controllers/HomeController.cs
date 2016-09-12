using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Talento_TEC_MVC.Models;

namespace Talento_TEC_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Dates()
        {
            return View();
        }
        public ActionResult UserTerms()
        {
            return View();
        }

        public ActionResult Contact()
        {
            

            return View();
        }



    }
}