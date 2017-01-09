using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WhateverGenNHibernate.EN.Whatever;

namespace MvcApplication1.Models
{
    public class Admin
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
        private System.Collections.Generic.IList<RetoEN> usuario_reto;
        private System.Collections.Generic.IList<ReporteEN> usuario_reporte2;
        private System.Collections.Generic.IList<PuntuacionEN> usuario_puntuacion;
        private System.Collections.Generic.IList<ComentarioEN> comentario_usuario2;
        private System.Collections.Generic.IList<EventoEN> usuario_evento2;
        */
        
        //private string nombre;
        [Display(Prompt = "Nombre del admin", Description = "Nombre del admin", Name = "Nombre")]
        [Required(ErrorMessage = "Debe indicar un nombre para el admin")]
        [StringLength(maximumLength: 200, ErrorMessage = "El nombre no puede tener más de 200 caracteres")]
        public string Nombre { get; set; }

        //private int edad;
        [Display(Prompt = "Edad del admin", Description = "Edad del admin", Name = "Precio ")]
        [Required(ErrorMessage = "Debe indicar una edad para el admin")]
        [DataType(DataType.Currency, ErrorMessage = "La edad debe ser un valor numérico")]
        [Range(minimum: 0, maximum: 120, ErrorMessage = "La edad debe ser mayor que cero y menor de 120")]
        public int Edad { get; set; }

        //private string sexo;
        [Display(Prompt = "Sexo del admin", Description = "Sexo del admin", Name = "Sexo ")]
        [Required(ErrorMessage = "Debe indicar un sexo para el admin")]
        public string sexo { get; set; }

        //private String contrasena;
        [Display(Prompt = "Contrasena del admin", Description = "Contrasena del admin", Name = "Contrasena ")]
        [Required(ErrorMessage = "Debe indicar una edad para el admin")]
        [DataType(DataType.Password)]
        public string Contrasena { get; set; }

        //private string email;
        [Display(Prompt = "Email del admin", Description = "Email del admin", Name = "Email ")]
        [Required(ErrorMessage = "Debe indicar una email para el admin")]
        public string Email { get; set; }

        //private string foto;
        [Display(Prompt = "Foto del admin", Description = "Foto del admin", Name = "Foto")]
        public string Foto { get; set; }

        //private string facebook;
        [Display(Prompt = "Facebook del admin", Description = "Facebook del admin", Name = "Facebook")]
        [StringLength(maximumLength: 200, ErrorMessage = "Tu cuenta de facebook no puede tener más de 200 caracteres")]
        public string Facebook { get; set; }

        //private string instagram;
        [Display(Prompt = "Instagram del admin", Description = "Instagram del admin", Name = "Instagram")]
        [StringLength(maximumLength: 200, ErrorMessage = "Tu cuenta de instagram no puede tener más de 200 caracteres")]
        public string Instagram { get; set; }

        //private string twitter;
        [Display(Prompt = "Twitter del admin", Description = "Twitter del admin", Name = "Twitter")]
        [StringLength(maximumLength: 200, ErrorMessage = "Tu cuenta de twitter no puede tener más de 200 caracteres")]
        public string Twitter { get; set; }





        //private System.Collections.Generic.IList<RetoEN> reto;
        [Display(Prompt = "Retos del admin", Description = "Retos del admin", Name = "Retos")]
        public IList<Reto> Retos { get; set; }

        //private System.Collections.Generic.IList<Evento> evento2;        
        [Display(Prompt = "Eventos del admin", Description = "Eventos del admin", Name = "Eventos")]
        public IList<Evento> Eventos { get; set; }

        //private System.Collections.Generic.IList<Reporte> reporte2;
        [Display(Prompt = "Reportes del admin", Description = "Reportes del admin", Name = "Reportes")]
        public IList<Reporte> Reportes { get; set; }

        //private System.Collections.Generic.IList<Puntuacion> puntuacion;
        [Display(Prompt = "Puntuaciones del admin", Description = "Puntuaciones del admin", Name = "Puntuaciones")]
        public IList<Puntuacion> Puntuaciones { get; set; }

        //private System.Collections.Generic.IList<Comentario> comentario_admin2;
        [Display(Prompt = "Comentarios del admin", Description = "Comentarios del admin", Name = "Comentarios")]
        public IList<Comentario> Comentarios { get; set; }




        //private int iD;
        [ScaffoldColumn(false)]
        public int id { get; set; }

        //private IList<RetoEN> reto;
        [ScaffoldColumn(false)]
        public IList<RetoEN> reto { get; set; }

        //private IList<EventoEN> evento;        
        [ScaffoldColumn(false)]
        public IList<EventoEN> evento { get; set; }

        //private IList<ReporteEN> reporte;
        [ScaffoldColumn(false)]
        public IList<ReporteEN> reporte { get; set; }

        //private IList<PuntuacionEN> puntuacion;
        [ScaffoldColumn(false)]
        public IList<PuntuacionEN> puntuacion { get; set; }

        //private IList<ComentarioEN> comentario;
        //[ScaffoldColumn(false)]
        //public IList<ComentarioEN> comentario { get; set; }
    }
}