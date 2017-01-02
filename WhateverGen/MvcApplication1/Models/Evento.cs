using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using WhateverGenNHibernate.EN.Whatever;

namespace MvcApplication1.Models
{
    public class Evento
    {
        /*
        EVENTO EN   
        private string titulo;
        private string descripcion;
        private Nullable<DateTime> fecha;
        private int precio;
        private UsuarioEN usuario;
        private IList<PuntuacionEN> puntuacion;
        private IList<MapaEN> mapa;
        private IList<ComentarioEN> comentario;
        private int iD;
        private IList<ReporteEN> reporte;
        private double latitud;
        private double longitud;
        private int zoom;
        */
        //public void CrearEvento (WhateverGenNHibernate.EN.Whatever.EventoEN evento, double lat, double long_, int zoom)


        //Titulo
        [Display(Prompt = "Titulo del evento", Description = "Titulo del evento", Name = "Titulo")]
        [Required(ErrorMessage = "Debe indicar un titulo para el evento")]
        [StringLength(maximumLength: 100, ErrorMessage = "El titulo no puede tener más de 100 caracteres")]
        public string Titulo { get; set; }

        //Descripcion
        [Display(Prompt = "Descripción del evento", Description = "Descripción del evento", Name = "Descripcion")]
        [Required(ErrorMessage = "Debe indicar una descripción para el evento")]
        [StringLength(maximumLength: 200, ErrorMessage = "La descripción no puede tener más de 200 caracteres")]
        public string Descripcion { get; set; }

        //Fecha
        [Display(Prompt = "Fecha del evento", Description = "Fecha del evento", Name = "Fecha")]
        [Required(ErrorMessage = "Debe indicar una fecha para el evento")]
        public Nullable<DateTime> Fecha { get; set; }

        //Precio
        [Display(Prompt = "Precio del evento", Description = "Precio del evento", Name = "Precio")]
        [Required(ErrorMessage = "Debe indicar un precio para el evento")]
        [DataType(DataType.Currency, ErrorMessage = "El precio debe ser un valor numérico")]
        [Range(minimum: 0.0, maximum: 10000.0, ErrorMessage = "El precio debe ser mayor que cero y menor de 10000")]
        public double Precio { get; set; }

        //Creador
        [Display(Prompt = "Creador", Description = "Nombre del creador del evento", Name = "Creador")]
        [Required(ErrorMessage = "Debe indicar el nombre del creador del evento")]
        public string Creador { get; set; }

        //Latitud
        [Display(Prompt = "Latitud del evento", Description = "Latitud del evento", Name = "Latitud")]
        [Required(ErrorMessage = "Debe indicar una latitud para el evento")]
        [DataType(DataType.Currency, ErrorMessage = "La latitud debe ser numerica")]
        [Range(minimum: -90.0, maximum: 90.0, ErrorMessage = "La latitud debe ser mayor que -90 y menor de 90")]
        public double Latitud { get; set; }

        //Longitud
        [Display(Prompt = "Longitud del evento", Description = "Longitud del evento", Name = "Longitud")]
        [Required(ErrorMessage = "Debe indicar una longitud para el evento")]
        [DataType(DataType.Currency, ErrorMessage = "La longitud debe ser numerica")]
        [Range(minimum: -180.0, maximum: 180.0, ErrorMessage = "La longitud debe ser mayor que -180 y menor de 180")]
        public double Longitud { get; set; }

        //Zoom
        [Display(Prompt = "Zoom para el mapa", Description = "Zoom para el mapa", Name = "Zoom")]
        [Required(ErrorMessage = "Debe indicar un zoom para el mapa")]
        [DataType(DataType.Currency, ErrorMessage = "El zoom debe ser numerico")]
        [Range(minimum: -180.0, maximum: 180.0, ErrorMessage = "El zoom debe ser mayor que 0 y menor de 20")]
        public int Zoom { get; set; }

        //private IList<PuntuacionEN> puntuacion;
        [Display(Prompt = "Puntuacion", Description = "Puntuacion del evento", Name = "Puntuacion")]
        public IList<Puntuacion> Puntuaciones { get; set; }
        
        //private IList<MapaEN> mapa;
        [Display(Prompt = "Mapa", Description = "Mapa del evento", Name = "Mapa")]
        [Required(ErrorMessage = "Debe indicar un mapa")]
        public Mapa Mapa{ get; set; }

        //private IList<ComentarioEN> comentario;
        [Display(Prompt = "Comentarios", Description = "Comentarios del evento", Name = "Comentario")]
        public IList<Comentario> Comentarios { get; set; }

        //private IList<ReporteEN> reporte;
        [Display(Prompt = "Reportes", Description = "Reportes del evento", Name = "Reportes")]
        public IList<Reporte> Reportes { get; set; }



        //private int iD;
        [ScaffoldColumn(false)]
        public int id { get; set; }

        //private UsuarioEN usuario_evento;
        [ScaffoldColumn(false)]
        public UsuarioEN usuario { get; set; }



    }
}