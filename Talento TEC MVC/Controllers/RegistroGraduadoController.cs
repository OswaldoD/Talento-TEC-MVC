﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Talento_TEC_MVC.Models.registro.graduado;

namespace Talento_TEC_MVC.Controllers
{
    public class RegistroGraduadoController : Controller
    {
        //public registro_completo_graduado info_user;

        public ActionResult datos_personales()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult datos_personales(datos_personales model)
        {
            //Response.Write(model.fechaNacimiento);
            //return View();
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                Session["primerApellido"] = model.primerApellido;
                Session["segundoApellido"] = model.segundoApellido;
                Session["nombre"] = model.nombreGraduado;
                Session["fechaNacimiento"] = model.fechaNacimiento;
                Session["paisNacimiento"] = model.paisNacimiento;
                Session["nacionalidad"] = model.nacionalidad;
                Session["tipoID"] = model.tipoID;
                Session["identificacion"] = model.identificacion;
                Session["genero"] = model.sexo;
                Session["carne"] = model.carne;

                return RedirectToAction("informacion_contacto", "registrograduado");
            }
        }

        public ActionResult informacion_contacto()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult informacion_contacto(informacion_contacto model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                Session["paisResidencia"] = model.paisResidencia;
                Session["provincia"] = model.provincia;
                Session["direccion"] = model.direccion;
                Session["telefono"] = model.telefono;
                Session["email"] = model.email;
                Session["password"] = model.password;
                Session["confirmPassword"] = model.confirmPassword;

                return RedirectToAction("educacion_formal", "registrograduado");
            }
        }

        public ActionResult educacion_formal()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult educacion_formal(educacion_formal model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {

                Session["educacionFormal"] = model.institucion; // vienen por aqui todos los datos

                return RedirectToAction("dominio_idioma", "registrograduado");
            }
        }

        public ActionResult dominio_idioma()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult dominio_idioma(dominio_idioma model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                Session["dominioIdioma"] = model.idioma; // idiomas

                return RedirectToAction("experiencia_laboral", "registrograduado");
            }
        }

        public ActionResult experiencia_laboral()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult experiencia_laboral(experiencia_laboral model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                Session["experienciaLaboral"] = model.empresa; // experiencia

                Session["capacitaciones"] = model.nombreActividad; // capacitaciones

                return RedirectToAction("conocimientos_referencias", "registrograduado");
            }
        }

        public ActionResult conocimientos_referencias()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult conocimientos_referencias(conocimientos_referencias model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                Session["conocimientos"] = model.descripcionConocimientos;
                Session["referencias"] = model.nombreRef; //


                return RedirectToAction("finalizar", "registrograduado");
            }
        }

        public ActionResult finalizar()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> finalizar(string Url)
        {
            // Registro
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://talentotec-api.azurewebsites.net/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var info_user = new registro_completo_graduado()
                {
                    primerApellido = Session["primerApellido"].ToString(),
                    segundoApellido = Session["segundoApellido"].ToString(),
                    nombre = Session["nombre"].ToString(),
                    fechaNacimiento = Session["fechaNacimiento"].ToString(),
                    paisNacimiento = Session["paisNacimiento"].ToString(),
                    nacionalidad = Session["nacionalidad"].ToString(),
                    tipoIdentificacion = Session["tipoID"].ToString(),
                    identificacion = Session["identificacion"].ToString(),
                    genero = Session["genero"].ToString(),
                    carne = Session["carne"].ToString(),
                    paisResidencia = Session["paisResidencia"].ToString(),
                    provincia = Session["provincia"].ToString(),
                    direccionExacta = Session["direccion"].ToString(),
                    telefono = Session["telefono"].ToString(),
                    email = Session["email"].ToString(),
                    password = Session["password"].ToString(),
                    infoTitulos = "prueba",
                    infoIdiomas = "prueba",
                    infoExperienciaLaboral = "prueba",
                    infoCapacitaciones = "prueba",
                    conocimientos = Session["conocimientos"].ToString(),
                    infoReferencias = "prueba",
                    tipoAplicante = "Graduado"
                };

                HttpResponseMessage response = await client.PostAsJsonAsync("api/add_graduate", info_user);

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
}
