using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Talento_TEC_MVC.Models.registro.empresa;

namespace Talento_TEC_MVC.Controllers
{
    public class RegistroEmpresaController : Controller
    {
        public registro_completo_empresa informacion_empresa = new registro_completo_empresa(); // este será el json a enviar

        // GET: RegistroEmpresa
        public ActionResult Index()
        {
            return View();
        }

        // GET
        public ActionResult Info_Inicial_Empresa()
        {
            return View();
        }

        // POST
        /* Método para extraer el formulario de empresa Información Inicial */
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Info_Inicial_Empresa(Info_Inicial_Empresa model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                // Información inicial de la empresa
                Session["nombreEmpresa"] = model.nombreEmpresa;
                Session["cedulaJurídica"] = model.cedula;
                Session["direccion"] = model.direccion;
                Session["provincia"] = model.ciudad;
                Session["nombrePais"] = model.paisEmpresa.ToString();
                Session["telefonoEmpresa"] = model.telefono;
                Session["URL_Empresa"] = model.pagina_web;
                Session["nombreContactoEmpresa"] = model.nombre_contacto;
                Session["puestoContacto"] = model.cargo_contacto;
                Session["emailContacto"] = model.email_contacto;
                Session["telefonoContacto"] = model.tel_contacto;

                return RedirectToAction("descripcionEmpresa", "RegistroEmpresa");
                //return View("descripcionEmpresa");
            }
        }

        public ActionResult descripcionEmpresa()
        {
            return View("descripcionEmpresa");
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult descripcionEmpresa(DescripcionEmpresa model)
        {
            Response.Write(ModelState.IsValid);

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                Session["descripcionActividades"] = model.descripcionEmpresa;
                Session["nombreSectores"] = model.sectores.ToString(); ;

                return RedirectToAction("credenciales_empresa", "RegistroEmpresa");

               // return View("credenciales_empresa");
            }
        }

        public ActionResult credenciales_empresa()
        {
            return View("credenciales_empresa");
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult credenciales_empresa(credenciales_empresa model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                Session["nombreUsuario"] = model.nombreUsuario;
                Session["passwordUsuario"] = model.contrasenna;

               // return View("finalizar_empresa");
                return RedirectToAction("finalizar_empresa", "RegistroEmpresa");

            }
        }

        public ActionResult finalizar_empresa()
        {
            Response.Write("????");

            return View("finalizar_empresa");
        }

        [HttpPost] 
        [AllowAnonymous]
        public ActionResult finalizar_empresa(string returnUrl)
        {
            Response.Write("agregar empresa");
            Response.Write(Session["nombreEmpresa"]);
            /*
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://talentotec-api.azurewebsites.net/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // informacion_empresa es la var que entra 

                HttpResponseMessage response = await client.PostAsJsonAsync("api/login", informacion_empresa);

                var json_respuesta = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    Response.Write("exito");
                }

            }*/
           // return RedirectToAction("Index", "Home");

            return View("finalizar_empresa");
        }



        /*
        [HttpPost]
        public async Task<ActionResult> Next(Info_Inicial_Empresa model, string returnUrl)
        {
            Response.Write("Hola");
            return View(model);
        }*/
        
    }
}
