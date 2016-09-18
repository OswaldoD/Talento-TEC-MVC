using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Talento_TEC_MVC.Models.registro.empresa
{
    public class DescripcionEmpresa
    {

        [Required]
        [Display(Name = "Para el TEC es importante conocer su empresa. Por favor, ingrese a continuación una descripción de las actividades que desarrolla su empresa  (*) ")]
        [DataType(DataType.MultilineText)]
        public string descripcionEmpresa { get; set; }

        [Required]
        [Display(Name = "Sector productivo  (*)")]
        [DataType(DataType.Text)]
        public sectoresProducticos sectores { get; set; }

        //Sector productivo: indique el o los sectores productivos en los cuales su empresa realiza sus actividades  (*)

        public static List<SelectListItem> getSectoresValues()
        {
            return new List<SelectListItem>
            {
                new SelectListItem {Text="Sin sectores", Value="sector1" }
                //new SelectListItem { Text = "Panamá", Value = "Panamá" },
                //new SelectListItem { Text = "Nicaragua", Value = "Nicaragua" }

            };
        }
    }

    public enum sectoresProducticos
    {
        sector1
    }
}