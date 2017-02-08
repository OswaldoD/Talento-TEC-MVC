using Newtonsoft.Json;
using System;
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
                Session["educacionFormal"] = model.paisTitulo;

                //Response.Write(model.paisTitulo);

                // Response.Write(deserializeTitles(model.paisTitulo) );


                //Session["educacionFormal"] = model.institucion; // vienen por aqui todos los datos
                // return View(model);
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
                Session["infoIdiomas"] = model.nivelOral; // idiomas
                Response.Write( deserializeLanguages(Session["infoIdiomas"].ToString()) );
                //return View(model);
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
                Session["infoExperienciaLaboral"] = model.annoFin; // experiencia

                Session["infoCapacitaciones"] = model.annoCurso; // capacitaciones
                Response.Write(deserializeExperience(Session["infoExperienciaLaboral"].ToString()));
                Response.Write(deserializeCourses(Session["infoCapacitaciones"].ToString()));

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
                Session["infoReferencias"] = model.sendInfo; //

                Response.Write(deserializeReferences(Session["infoReferencias"].ToString()));

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
                    infoTitulos = deserializeTitles(Session["educacionFormal"].ToString()),
                    infoIdiomas = deserializeTitles(Session["infoIdiomas"].ToString()),
                    infoExperienciaLaboral = deserializeExperience( Session["infoExperienciaLaboral"].ToString() ),
                    infoCapacitaciones = deserializeCourses( Session["infoCapacitaciones"].ToString()),
                    conocimientos = Session["conocimientos"].ToString(),
                    infoReferencias = deserializeReferences( Session["infoReferencias"].ToString() ),
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
        /**
         * Deserializa los titulos y los convierte a strings
         */
        public string deserializeTitles(string json)
        {
            string titles = "";
            IEnumerable<Titles> titulos = JsonConvert.DeserializeObject<IEnumerable<Titles>>(json);
            for (int i = 0; i < titulos.Count(); i++)
            {
                // nombreInstitucion,pais,nombreTitulo,grado,annoGraduacion,/
                titles += titulos.ElementAt(i).nombreInstitucion + ",";
                titles += titulos.ElementAt(i).pais + ",";
                titles += titulos.ElementAt(i).nombreTitulo + ",";
                titles += titulos.ElementAt(i).grado + ",";
                titles += titulos.ElementAt(i).annoGraduacion + ",";
                titles += "/";
            }
            return titles;
        }
        /**
         * Deserializa los idiomas y los convierte a strings
         */
        public string deserializeLanguages(string json)
        {
            string languages = "";
            IEnumerable<Languages> idiomas = JsonConvert.DeserializeObject<IEnumerable<Languages>>(json);
            for (int i = 0; i < idiomas.Count(); i++)
            {
                // nombreInstitucion,pais,nombreTitulo,grado,annoGraduacion,/
                languages += idiomas.ElementAt(i).idioma + ",";
                languages += idiomas.ElementAt(i).nivelEscritura + ",";
                languages += idiomas.ElementAt(i).nivelEscritura + ",";
                languages += idiomas.ElementAt(i).nivelOral + ",";
                languages += "/";
            }
            return languages;
        }
        /**
         * Deserializa experiencia laboral y los convierte a strings
         */
        public string deserializeExperience(string json)
        {
            string experience = "";
            IEnumerable<Experience> experiencia = JsonConvert.DeserializeObject<IEnumerable<Experience>>(json);
            for (int i = 0; i < experiencia.Count(); i++)
            {
                // nombreInstitucion,pais,nombreTitulo,grado,annoGraduacion,/
                experience += experiencia.ElementAt(i).empresa + ",";
                experience += experiencia.ElementAt(i).cargo + ",";
                experience += experiencia.ElementAt(i).pais + ",";
                experience += experiencia.ElementAt(i).annoInicio + ",";
                experience += experiencia.ElementAt(i).annoFin + ",";
                experience += "/";
            }
            return experience;
        }
        /**
         * Deserializa los cursos y los convierte a strings
         */
        public string deserializeCourses(string json)
        {
            string courses = "";
            IEnumerable<Courses> cursos = JsonConvert.DeserializeObject<IEnumerable<Courses>>(json);
            for (int i = 0; i < cursos.Count(); i++)
            {
                // nombreInstitucion,pais,nombreTitulo,grado,annoGraduacion,/
                courses += cursos.ElementAt(i).nombreActividad + ",";
                courses += cursos.ElementAt(i).institucion + ",";
                courses += cursos.ElementAt(i).pais + ",";
                courses += cursos.ElementAt(i).anno + ",";
                courses += "/";
            }
            return courses;
        }
        /**
         * Deserializa las referencias y los convierte a strings
         */
        public string deserializeReferences(string json)
        {
            string references = "";
            IEnumerable<References> referencias = JsonConvert.DeserializeObject<IEnumerable<References>>(json);
            for (int i = 0; i < referencias.Count(); i++)
            {
                // nombreInstitucion,pais,nombreTitulo,grado,annoGraduacion,/
                references += referencias.ElementAt(i).nombreCompleto + ",";
                references += referencias.ElementAt(i).puesto + ",";
                references += referencias.ElementAt(i).email + ",";
                references += referencias.ElementAt(i).telefono + ",";
                references += "/";
            }
            return references;
        }
    }
}
