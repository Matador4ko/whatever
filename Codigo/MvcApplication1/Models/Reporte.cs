using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WhateverGenNHibernate.EN.Whatever;

namespace MvcApplication1.Models
{
    public class Reporte
    {
        //private int iD;
        [ScaffoldColumn(false)]
        public int id { get; set; }

        //private string motivo;
        [Display(Prompt = "Motivo del reporte", Description = "Nombre del reporte", Name = "Nombre")]
        [Required(ErrorMessage = "Debe indicar un nombre para el reporte")]
        [StringLength(maximumLength: 100, ErrorMessage = "El nombre no puede tener más de 200 caracteres")]
        public string motivo { get; set; }
        
        //private WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario_reporte;
        [Display(Prompt = "Usuario del reporte", Description = "Usuario del reporte", Name = "Usuario")]
        public string Usuario { get; set; }
        
        //private System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.AdminEN> admin_reporte;
        
        
        //private WhateverGenNHibernate.EN.Whatever.RetoEN reporte_reto2;
        
        
        //private WhateverGenNHibernate.EN.Whatever.EventoEN reporte;


        


        public UsuarioEN usuario_reporte { get; set; }
        public IList<AdminEN> admin_reporte { get; set; }
        public RetoEN reporte_reto2 { get; set; }
        public EventoEN reporte { get; set; }
    }
}