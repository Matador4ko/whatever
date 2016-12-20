using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WhateverGenNHibernate.EN.Whatever;


namespace MvcApplication1.Models
{
    public class Paso
    {
        //private int iD;
        [ScaffoldColumn(false)]
        public int id { get; set; }

        [ScaffoldColumn(false)]
        public int idGymkana { get; set; }
        
        //private string descripcion;
        [Display(Prompt = "Descripción del paso", Description = "Descripción del paso", Name = "Descripción ")]
        [Required(ErrorMessage = "Debe indicar una descripción para el paso")]
        [StringLength(maximumLength: 200, ErrorMessage = "El nombre no puede tener más de 200 caracteres")]
        public string Descripcion { get; set; }

        //private WhateverGenNHibernate.EN.Whatever.GymkanaEN gymkana_paso2;
        [Display(Prompt = "Descripción del paso", Description = "Descripción del paso", Name = "Descripción ")]
        [Required(ErrorMessage = "Debe indicar una gymkana para el paso")]
        public GymkanaEN Gymkana { get; set; }

        //private WhateverGenNHibernate.EN.Whatever.MapaEN paso;
        [Display(Prompt = "Descripción del paso", Description = "Descripción del paso", Name = "Descripción ")]
        [Required(ErrorMessage = "Debe indicar un mapa para el paso")]
        public MapaEN Mapa{ get; set; }

    }
}