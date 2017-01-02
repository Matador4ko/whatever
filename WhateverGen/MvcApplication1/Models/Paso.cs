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

        /*
        private string descripcion;
        private WhateverGenNHibernate.EN.Whatever.GymkanaEN gymkana_paso2;
        private WhateverGenNHibernate.EN.Whatever.MapaEN paso;
        private int iD;
        */
        //public void AnadirPaso (int id_gym, string descripcion, int latitud, int longitud, int zoom)

        
        //numero del paso
        [Display(Prompt = "Numero", Description = "Nuemro del paso", Name = "Numero")]
        public int Numero { get; set; }
        
        //private string descripcion;
        [Display(Prompt = "Descripción del paso", Description = "Descripción del paso", Name = "Descripcion")]
        [Required(ErrorMessage = "Debe indicar una descripción para el paso")]
        [StringLength(maximumLength: 200, ErrorMessage = "El nombre no puede tener más de 200 caracteres")]
        public string Descripcion { get; set; }

        //private WhateverGenNHibernate.EN.Whatever.MapaEN paso;
        [Display(Prompt = "Mapa del paso", Description = "Mapa del paso", Name = "Mapa ")]
        public Mapa Mapa{ get; set; }

        //private int iD;
        [ScaffoldColumn(false)]
        public int id { get; set; }

        //private WhateverGenNHibernate.EN.Whatever.GymkanaEN gymkana_paso2;
        [ScaffoldColumn(false)]
        public int idGymkana { get; set; }



    }
}