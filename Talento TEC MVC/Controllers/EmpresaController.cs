using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Talento_TEC_MVC.Models.empresa;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Talento_TEC_MVC.Controllers
{
    public class EmpresaController : Controller
    {
        // GET: empresa
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index_Empresa()
        {
            return View();
        }

        public ActionResult agregar_oferta()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> agregar_oferta(NuevaOferta model)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://talentotec-api.azurewebsites.net/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // informacion de la oferta
                AgregaOferta nuevaOferta = new AgregaOferta()
                {
                    IDEmpresa = Int32.Parse(Session["ID"].ToString()),
                    descripcionPuesto = model.descripcionPuesto,
                    RequisitosPuesto = model.requisitosPuesto,
                    montoSalario = float.Parse(model.montoMensual),
                    nombreTipoMoneda = "", // desde boton
                    fechaInicioOferta = model.fechaInicio,
                    fechaFinalOferta = model.fechaFin,
                    nombreTipoOferta = "", // desde boton
                    nombreContacto = model.nombreContacto,
                    emailContacto = model.emailContacto,
                    telefonoContacto = model.telContacto,
                    estadoOferta = "", // desde boton
                    estadoConfidencialidad = "", // desde boton
                    cantidadPlazas = Int32.Parse(model.cantidadPlazas),
                    carrerasProfesionales = model.carreraOferta.ToString() + ", " + model.especialidadOferta.ToString() // agregar mas carreras
                };

                HttpResponseMessage response = await client.PostAsJsonAsync("api/Add_Offer", nuevaOferta);

                var json_respuesta = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("oferta_agregada", "Empresa");

                }
                else
                {
                    return View(model);
                }

            }
        }

        public ActionResult oferta_agregada()
        {
            return View();
        }

    }
}
