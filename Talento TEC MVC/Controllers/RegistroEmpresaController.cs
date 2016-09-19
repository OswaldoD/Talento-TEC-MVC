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
        public registro_completo_empresa informacion_empresa; // este será el json a enviar

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
                Session["emailEmpresa"] = model.email;
                Session["URL_Empresa"] = model.pagina_web;
                Session["nombreContactoEmpresa"] = model.nombre_contacto;
                Session["emailContacto"] = model.email_contacto;
                Session["puestoContacto"] = model.cargo_contacto;
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
            return View("finalizar_empresa");
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> finalizar_empresa(string returnUrl)
        {
            Response.Write("agregar empresa");
            Response.Write(Session["nombreEmpresa"]);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://talentotec-api.azurewebsites.net/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // informacion_empresa es la var que entra 

                informacion_empresa = new registro_completo_empresa()
                {
                    nombreEmpresa = Session["nombreEmpresa"].ToString(),
                    cedulaJurídica = Session["cedulaJurídica"].ToString(),
                    direccion = Session["direccion"].ToString(),
                    provincia = Session["provincia"].ToString(),
                    nombrePais = Session["nombrePais"].ToString(),
                    telefonoEmpresa = Session["telefonoEmpresa"].ToString(),
                    emailEmpresa = Session["emailEmpresa"].ToString(),
                    URL_Empresa = Session["URL_Empresa"].ToString(),
                    nombreContactoEmpresa = Session["nombreContactoEmpresa"].ToString(),
                    emailContacto = Session["emailContacto"].ToString(),
                    puestoContacto = Session["puestoContacto"].ToString(),
                    telefonoContacto = Session["telefonoContacto"].ToString(),
                    descripcionActividades = Session["descripcionActividades"].ToString(),
                    nombreUsuario = Session["nombreUsuario"].ToString(),
                    passwordUsuario = Session["passwordUsuario"].ToString(),
                    nombreSectores = Session["nombreSectores"].ToString()
                };

                HttpResponseMessage response = await client.PostAsJsonAsync("api/Add_Enterprise", informacion_empresa);

                var json_respuesta = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    Session.Abandon(); // eliminamos todos los archivos de session
                    return RedirectToAction("Index", "Home");
                    //Response.Write("exito");
                }
                else
                {
                    return View();
                }
            }
            // return View("finalizar_empresa");
        }
    }
}
