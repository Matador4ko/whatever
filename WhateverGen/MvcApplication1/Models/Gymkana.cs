using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WhateverGenNHibernate.EN.Whatever;

namespace MvcApplication1.Models
{
    public class Gymkana
    {
        /*
        private string titulo;
        private string descripcion;
        private Nullable<DateTime> fecha;
        private int precio;
        private UsuarioEN usuario;
        private IList<PuntuacionEN> puntuacion;
        private IList<MapaEN> evento_mapa;
        private IList<ComentarioEN> comentario;
        private int numPasos;
        private IList<PasoEN> gymkana_paso;

        private int iD;
        private UsuarioEN usuario;
        private IList<ReporteEN> reporte;
        */

        //public void CrearGymkana (WhateverGenNHibernate.EN.Whatever.GymkanaEN gym, double lat, double lon, int zoom)

        //Titulo
        [Display(Prompt = "Titulo de la gymkana", Description = "Titulo de la gymkana", Name = "Titulo")]
        [Required(ErrorMessage = "Debe indicar un titulo para el evento")]
        [StringLength(maximumLength: 100, ErrorMessage = "El titulo no puede tener más de 100 caracteres")]
        public string Titulo { get; set; }

        //Descripcion
        [Display(Prompt = "Descripción de la gymkana", Description = "Descripción de la gymkana", Name = "Descripcion")]
        [Required(ErrorMessage = "Debe indicar una descripción para el evento")]
        [StringLength(maximumLength: 200, ErrorMessage = "La descripción no puede tener más de 200 caracteres")]
        public string Descripcion { get; set; }

        //Fecha
        [Display(Prompt = "Fecha de la gymkana", Description = "Fecha de la gymkana", Name = "Fecha")]
        [Required(ErrorMessage = "Debe indicar una fecha para el evento")]
        public Nullable<DateTime> Fecha { get; set; }

        //Precio
        [Display(Prompt = "Precio de la gymkana", Description = "Precio de la gymkana", Name = "Precio")]
        [Required(ErrorMessage = "Debe indicar un precio para el evento")]
        [DataType(DataType.Currency, ErrorMessage = "El precio debe ser un valor numérico")]
        [Range(minimum: 0, maximum: 10000, ErrorMessage = "El precio debe ser mayor que cero y menor de 10000")]
        public double Precio { get; set; }

        //Creador
        [Display(Prompt = "Creador", Description = "Nombre del creador de la gymkana", Name = "Creador")]
        [Required(ErrorMessage = "Debe indicar el nombre del creador de la gymkana")]
        public string Creador { get; set; }

        //private IList<PuntuacionEN> puntuacion;
        [Display(Prompt = "Puntuacion", Description = "Puntuacion de la gymkana", Name = "Puntuacion")]
        [Required(ErrorMessage = "Debe indicar la puntuacion de la gymkana")]
        public double Puntuacion { get; set; }

        //private IList<MapaEN> evento_mapa;
        [Display(Prompt = "Mapa", Description = "Mapa de la gymkana", Name = "Mapa")]
        [Required(ErrorMessage = "Debe indicar un mapa")]
        public Mapa Mapa { get; set; }

        //private IList<ComentarioEN> comentario;
        [Display(Prompt = "Comentarios", Description = "Comentarios de la gymkana", Name = "Comentario")]
        public IList<Comentario> Comentarios { get; set; }

        //numero de pasos
        [Display(Prompt = "Numero de pasos", Description = "Numero de los pasos de la gymkana", Name = "Numeropasos")]
        [DataType(DataType.Currency, ErrorMessage = "El nuermo de pasos debe ser un valor numérico")]
        [Required(ErrorMessage = "Debe indicar un numero de pasos")]
        public int Numeropasos { get; set; }

        //Paso
        [Display(Prompt = "Pasos", Description = "Pasos de la gymkana", Name = "Pasos")]
        public IList<Paso> Pasos { get; set; }
        
        //private IList<ReporteEN> reporte;
        [Display(Prompt = "Reportes", Description = "Reportes de la gymkana", Name = "Reportes")]
        public IList<Reporte> Reportes { get; set; }
        
        

        //private int iD;
        [ScaffoldColumn(false)]
        public int id { get; set; }
        
        //private UsuarioEN usuario;
        [ScaffoldColumn(false)]
        public UsuarioEN usuario { get; set; }

        [ScaffoldColumn(false)]
        public int ultimoPaso { get; set; }
    }
}