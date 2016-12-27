using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using WhateverGenNHibernate.EN.Whatever;

namespace MvcApplication1.Models
{
    public class Mapa
    {
        /*
        private WhateverGenNHibernate.EN.Whatever.EventoEN evento_mapa2;
        private int id;
        private WhateverGenNHibernate.EN.Whatever.PasoEN paso_0;
        private double latitud;
        private double longitud;
        private int zoom;
        */
         

        //Latitud
        [Display(Prompt = "Latitud del mapa", Description = "Latitud del mapa", Name = "Latitud ")]
        [Required(ErrorMessage = "Debe indicar una latitud para el mapa")]
        [Range(minimum: -90, maximum: 90, ErrorMessage = "La latitud debe ser mayor que -90 y menor que 90")]
        public double Latitud { get; set; }

        //Longitud
        [Display(Prompt = "Longitud del mapa", Description = "Longitud del mapa", Name = "Longitud ")]
        [Required(ErrorMessage = "Debe indicar una longitud para el mapa")]
        [Range(minimum: -180, maximum: 180, ErrorMessage = "La longitud debe ser mayor que -180 y menor que 180")]
        public double Longitud { get; set; }

        //Zoom
        [Display(Prompt = "Zoom del mapa", Description = "Zoom del mapa", Name = "Zoom ")]
        [Required(ErrorMessage = "Debe indicar un zoom para el mapa")]
        [Range(minimum: 1, maximum: 21, ErrorMessage = "El zoom debe ser mayor que 0 y menor que 21")]
        public int Zoom { get; set; }

        //id
        [ScaffoldColumn(false)]
        public int id { get; set;}
        
        //IList<EventoEN> evento_mapa2;
        [ScaffoldColumn(false)]
        public EventoEN evento_mapa;
        
        //PasoEN paso_0;
        [ScaffoldColumn(false)]
        public PasoEN paso;

    }
}