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
        public registro_completo_empresa informacion_empresa; // este será el json a enviar

        // GET: RegistroEmpresa
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Info_Inicial_Empresa()
        {
            return View();
        }

        // GET: RegistroEmpresa/Create
        public ActionResult Create()
        {
            Response.Write("Hola");
            return View();
        }

        // POST: RegistroEmpresa/Create
        [HttpPost]
        public void Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Response.Write("Hola");
                // return RedirectToAction("Index");
            }
            catch
            {
               // return View();
            }
        }

        [HttpPost]
        public ActionResult Info_Inicial_Empresa(Info_Inicial_Empresa model, string returnUrl)
        {
            Response.Write("Holas");
            Console.Write("Alo polisia");
            return View(model);
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
