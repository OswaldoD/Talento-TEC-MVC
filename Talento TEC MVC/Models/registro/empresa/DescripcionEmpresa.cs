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

        
        [Display(Name = "Sector productivo  (*)")]
        public sectoresProducticos sectores { get; set; }

        //Sector productivo: indique el o los sectores productivos en los cuales su empresa realiza sus actividades  (*)

        public static List<SelectListItem> getSectoresValues()
        {
            return new List<SelectListItem>
            {
                new SelectListItem {Text="No Presenta Sectores", Value="No_Presenta_Sectores" }
            };
        }
    }

    public enum sectoresProducticos { No_Presenta_Sectores }
}