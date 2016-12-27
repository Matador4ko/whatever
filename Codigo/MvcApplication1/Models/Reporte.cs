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
        //private string motivo;
        [Display(Prompt = "Motivo del reporte", Description = "Motivo del reporte", Name = "Motivo")]
        [Required(ErrorMessage = "Debe indicar un motivo para el reporte")]
        [StringLength(maximumLength: 200, ErrorMessage = "El motivo no puede tener más de 200 caracteres")]
        public string Motivo { get; set; }
        
        //private WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario_reporte;
        [Display(Prompt = "Usuario del reporte", Description = "Usuario del reporte", Name = "Usuario")]
        public string Usuario { get; set; }

        //private int iD;
        [ScaffoldColumn(false)]
        public int id { get; set; }

        //private WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario_reporte;
        [ScaffoldColumn(false)]
        public UsuarioEN usuario_reporte { get; set; }
        
        //private System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.AdminEN> admin_reporte;
        [ScaffoldColumn(false)]
        public IList<AdminEN> admin_reporte { get; set; }
        
        //private WhateverGenNHibernate.EN.Whatever.RetoEN reporte_reto2;
        [ScaffoldColumn(false)]
        public RetoEN reporte_reto2 { get; set; }

        //private WhateverGenNHibernate.EN.Whatever.EventoEN reporte;
        [ScaffoldColumn(false)]
        public EventoEN reporte_evento { get; set; }       


    }
z}