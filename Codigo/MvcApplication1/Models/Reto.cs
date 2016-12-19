using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Reto
    {
        [ScaffoldColumn(false)]
        public int id { get; set; }

        [ScaffoldColumn(false)]
        public int idUsuario { get; set; }

        [ScaffoldColumn(false)]
        public int idPuntuacion { get; set; }

        [ScaffoldColumn(false)]
        public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> Comentarios;

        [ScaffoldColumn(false)]
        public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> Reporte;


        [Display(Prompt = "Título del reto", Description = "Título del reto", Name = "Titulo")]
        [Required(ErrorMessage = "Debe indicar un nombre para el reto")]
        [StringLength(maximumLength: 200, ErrorMessage = "El nombre no puede tener más de 200 caracteres")]
        public string Titulo { get; set; }

        [Display(Prompt = "Precio del reto", Description = "Precio del reto", Name = "Precio ")]
        [Required(ErrorMessage = "Debe indicar un precio para el reto")]
        [DataType(DataType.Currency, ErrorMessage = "El precio debe ser un valor numérico")]
        [Range(minimum: 0, maximum: 10000, ErrorMessage = "El precio debe ser mayor que cero y menor de 10000")]
        public double Precio { get; set; }

        [Display(Prompt = "Descripción del reto", Description = "Descripción del reto", Name = "Descripción ")]
        [Required(ErrorMessage = "Debe indicar una descripción para el reto")]
        [StringLength(maximumLength: 200, ErrorMessage = "El nombre no puede tener más de 200 caracteres")]
        public string Descripcion { get; set; }

        [Display(Prompt = "Tipo del reto", Description = "Tipo del reto", Name = "Tipo ")]
        [Required(ErrorMessage = "Debe indicar un tipo del reto")]
        [StringLength(maximumLength: 200, ErrorMessage = "El nombre no puede tener más de 200 caracteres")]
        public string Tipo { get; set; }

        [Display(Prompt = "Imagen del reto", Description = "Unidades del reto", Name = "Imagen ")]
        [Required(ErrorMessage = "Debe indicar una imagen del reto")]
        public string Imagen { get; set; }


    }
}
