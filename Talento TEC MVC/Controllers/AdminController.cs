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
            return View();
        }

        public ActionResult add_date()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult> add_date(nueva_fecha model)
        {
            // Crear fecha
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
                        fecha = "",
                        nombreActividad = "",
                        descripcionActividad = ""
                    };

                    HttpResponseMessage response = await client.PostAsJsonAsync("api/ ", date);

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
            // mandar correo
            return View();
        }

    }
}