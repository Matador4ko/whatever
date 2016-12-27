using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WhateverGenNHibernate.EN.Whatever;

namespace MvcApplication1.Models
{
    public class Usuario
    {
        /*ATRIBUTOS EN
        private int iD;
        private string nombre;
        private int edad;
        private string sexo;
        private String contrasena;
        private string email;
        private string foto;
        private string facebook;
        private string instagram;
        private string twitter;
        private IList<RetoEN> usuario_reto;
        private IList<ReporteEN> usuario_reporte2;
        private IList<PuntuacionEN> usuario_puntuacion;
        private IList<ComentarioEN> comentario_usuario2;
        private IList<EventoEN> usuario_evento2;
        */


        //private string nombre;
        [Display(Prompt = "Nombre del usuario", Description = "Nombre del usuario", Name = "Nombre")]
        [Required(ErrorMessage = "Debe indicar un nombre para el usuario")]
        [StringLength(maximumLength: 50, ErrorMessage = "El nombre no puede tener más de 50 caracteres")]
        public string Nombre { get; set; }

        //private int edad;
        [Display(Prompt = "Edad del usuario", Description = "Edad del usuario", Name = "Precio")]
        [Required(ErrorMessage = "Debe indicar una edad para el usuario")]
        [DataType(DataType.Currency, ErrorMessage = "La edad debe ser un valor numérico")]
        [Range(minimum: 0, maximum: 120, ErrorMessage = "La edad debe ser mayor que cero y menor de 120")]
        public int Edad { get; set; }

        //private string sexo;
        [Display(Prompt = "Sexo del usuario", Description = "Sexo del usuario", Name = "Sexo")]
        [Required(ErrorMessage = "Debe indicar un sexo para el usuario")]
        public string sexo { get; set; }

        //private String contrasena;
        [Display(Prompt = "Contrasena del usuario", Description = "Contrasena del usuario", Name = "Contrasena")]
        [Required(ErrorMessage = "Debe indicar una edad para el usuario")]
        [DataType(DataType.Password)]
        public string Contrasena { get; set; }

        //private string email;
        [Display(Prompt = "Email del usuario", Description = "Email del usuario", Name = "Email")]
        [Required(ErrorMessage = "Debe indicar una email para el usuario")]
        public string Email{ get; set; }

        //private string foto;
        [Display(Prompt = "Foto del usuario", Description = "Unidades del usuario", Name = "Foto")]
        public string Foto { get; set; }

        //private string facebook;
        [Display(Prompt = "Facebook del usuario", Description = "Facebook del usuario", Name = "Facebook")]
        [StringLength(maximumLength: 50, ErrorMessage = "Tu cuenta de facebook no puede tener más de 50 caracteres")]
        public string Facebook { get; set; }

        //private string instagram;
        [Display(Prompt = "Instagram del usuario", Description = "Instagram del usuario", Name = "Instagram")]
        [StringLength(maximumLength: 50, ErrorMessage = "Tu cuenta de instagram no puede tener más de 50 caracteres")]
        public string Instagram { get; set; }

        //private string twitter;
        [Display(Prompt = "Twitter del usuario", Description = "Twitter del usuario", Name = "Twitter")]
        [StringLength(maximumLength: 50, ErrorMessage = "Tu cuenta de twitter no puede tener más de 50 caracteres")]
        public string Twitter { get; set; }

        //private IList<RetoEN> usuario_reto;
        [Display(Prompt = "Retos del usuario", Description = "Retos del usuario", Name = "Retos")]
        public IList<RetoEN> Retos { get; set; }

        //private IList<EventoEN> usuario_evento2;        
        [Display(Prompt = "Eventos del usuario", Description = "Eventos del usuario", Name = "Eventos")]
        public IList<EventoEN> Eventos { get; set; }

        //private IList<ReporteEN> usuario_reporte2;
        [Display(Prompt = "Reportes del usuario", Description = "Reportes del usuario", Name = "Reportes")]
        public IList<ReporteEN> Reportes { get; set; }

        //private IList<PuntuacionEN> usuario_puntuacion;
        [Display(Prompt = "Puntuaciones del usuario", Description = "Puntuaciones del usuario", Name = "Puntuaciones")]
        public IList<PuntuacionEN> Puntuaciones { get; set; }

        //private IList<ComentarioEN> comentario_usuario2;
        [Display(Prompt = "Comentarios del usuario", Description = "Comentarios del usuario", Name = "Comentarios")]
        public IList<Comentario> Comentarios { get; set; }


        
        //private int iD;
        [ScaffoldColumn(false)]
        public int id { get; set; }

        //private IList<RetoEN> usuario_reto;
        [ScaffoldColumn(false)]
        public IList<RetoEN> usuario_reto { get; set; }

        //private IList<EventoEN> usuario_evento2;        
        [ScaffoldColumn(false)]
        public IList<EventoEN> usuario_evento { get; set; }

        //private IList<ReporteEN> usuario_reporte2;
        [ScaffoldColumn(false)]
        public IList<ReporteEN> usuario_reporte { get; set; }

        //private IList<PuntuacionEN> usuario_puntuacion;
        [ScaffoldColumn(false)]
        public IList<PuntuacionEN> usuario_puntuacion { get; set; }

        //private IList<ComentarioEN> comentario_usuario2;
        //[ScaffoldColumn(false)]
        //public IList<ComentarioEN> comentario_usuario2 { get; set; }
        
    }
}
