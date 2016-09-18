using System;
using System.Collections.Generic;
using System.Linq;
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
        public ActionResult Info_Inicial_Empresa(Info_Inicial_Empresa model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
               
                Response.Write(model.paisEmpresa.ToString());
                return View(model);
            }
            else
            {
                // Información inicial de la empresa
                informacion_empresa.nombreEmpresa = model.nombreEmpresa;
                informacion_empresa.cedulaJurídica = model.cedula;
                informacion_empresa.direccion = model.direccion;
                informacion_empresa.provincia = model.ciudad;
                informacion_empresa.nombrePais = model.paisEmpresa.ToString();
                informacion_empresa.telefonoEmpresa = model.telefono;
                informacion_empresa.URL_Empresa = model.pagina_web;
                informacion_empresa.nombreContactoEmpresa = model.nombre_contacto;
                informacion_empresa.puestoContacto = model.cargo_contacto;
                informacion_empresa.emailContacto = model.email_contacto;
                informacion_empresa.telefonoContacto = model.tel_contacto;

                return View("descripcionEmpresa");
            }
        }

        public ActionResult descripcionEmpresa()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult descripcionEmpresa(DescripcionEmpresa model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                informacion_empresa.descripcionActividades = model.descripcionEmpresa;
                informacion_empresa.nombreSectores = model.sectores.ToString();
                return View("credenciales_empresa");
            }
        }

        public ActionResult credenciales_empresa()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult credenciales_empresa(credenciales_empresa model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                informacion_empresa.nombreUsuario = model.nombreUsuario;
                informacion_empresa.passwordUsuario = model.contrasenna;

                return View();
            }
        }

        public ActionResult finalizar_empresa()
        {
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
