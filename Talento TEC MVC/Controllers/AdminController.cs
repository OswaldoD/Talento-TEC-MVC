using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
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
            Session["nombre"] = "Cuenta Prueba Admin";
            Session["TipoCuenta"] = "Admin";
            Session["ID"] = 1;
            return View();
        }

        public ActionResult show_dates()
        {
            return View();
        }


        public ActionResult add_date()
        {
            Session["nombre"] = "Cuenta Prueba normal Admin";
            Session["TipoCuenta"] = "Admin";
            Session["ID"] = 1;
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult> add_date(nueva_fecha model)
        {
            // Crear fecha importante
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://talentotec-api.azurewebsites.net/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    send_date date = new send_date()
                    {
                        fecha = model.fecha,
                        nombreActividad = model.nombreActividad,
                        descripcionActividad = model.descripcionActividad
                    };

                    HttpResponseMessage response = await client.PostAsJsonAsync("api/Add_Date", date);

                    var json_respuesta = await response.Content.ReadAsStringAsync();
                    if (response.IsSuccessStatusCode)
                    {
                        Session.Abandon();
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        return View();
                    }
                }
            }
        }

        public ActionResult info_date()
        {
            // cambiar la fecha importante
            return View();
        }

        public ActionResult new_email()
        {
            // mandar correo
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public ActionResult new_email(new_email model)
        {
            // mandar correo
            return View();
        }

        public ActionResult enterprises()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult enterprises(string Url)
        {
            return View();
        }

        public ActionResult see_enterprise()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult see_enterprise(enterprise_info enterprise)
        {
            return View();
        }

    }
}