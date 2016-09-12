using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Talento_TEC_MVC.Models;

namespace Talento_TEC_MVC.Controllers.actions
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Login()
        {
            Console.WriteLine("gg");

            return View();
        }

        // POST: Login/Create
        [HttpPost]
        public ActionResult Login(LoginStart loginStart)
        {
            try
            {
                // TODO: Add insert logic here
                Console.WriteLine(loginStart.input_username);

                //return RedirectToAction("Index");
                return View("Contact");
            }
            catch
            {
                //return View();
                return View();
            }
        }

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }



        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

    }
}
