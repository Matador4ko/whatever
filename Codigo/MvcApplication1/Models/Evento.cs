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
        private string titulo;
        private string descripcion;
        private Nullable<DateTime> fecha;
        private int precio;
        private UsuarioEN usuario_evento;
        private IList<PuntuacionEN> puntuacion_evento2;
        private IList<MapaEN> evento_mapa;
        private IList<ComentarioEN> comentario_evento;
        private int iD;
        private UsuarioEN usuario_evento;
        private IList<ReporteEN> reporte_evento2;
        */


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
        [Range(minimum: 0, maximum: 10000, ErrorMessage = "El precio debe ser mayor que cero y menor de 10000")]
        public double Precio { get; set; }

        //Creador
        [Display(Prompt = "Creador", Description = "Nombre del creador del evento", Name = "Creador")]
        [Required(ErrorMessage = "Debe indicar el nombre del creador del evento")]
        public string Creador { get; set; }
        
        //private IList<PuntuacionEN> puntuacion_evento2;
        [Display(Prompt = "Puntuacion", Description = "Puntuacion del evento", Name = "Puntuacion")]
        [Required(ErrorMessage = "Debe indicar la puntuacion del evento")]
        public double Puntuacion{ get; set; }
        
        //private IList<MapaEN> evento_mapa;
        [Display(Prompt = "Mapa", Description = "Mapa del evento", Name = "Mapa")]
        [Required(ErrorMessage = "Debe indicar un mapa")]
        public Mapa Mapa{ get; set; }

        //private IList<ComentarioEN> comentario_evento;
        [Display(Prompt = "Comentarios", Description = "Comentarios del evento", Name = "Comentario")]
        public IList<Comentario> Comentarios { get; set; }




        //private int iD;
        [ScaffoldColumn(false)]
        public int id { get; set; }

        //private UsuarioEN usuario_evento;
        [ScaffoldColumn(false)]
        public UsuarioEN usuario_evento { get; set; }

        //private IList<ReporteEN> reporte_evento2;
        [ScaffoldColumn(false)]
        public IList<ReporteEN> reporte_evento{ get; set; }


    }
}