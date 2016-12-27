using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WhateverGenNHibernate.EN.Whatever;

namespace MvcApplication1.Models
{
    public class Puntuacion
    {
        //public int id;
        [ScaffoldColumn(false)]
        public int id{ get; set; }

        //public WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario_puntuacion2;
        [ScaffoldColumn(false)]
        public int idUsuario { get; set; }

        //public WhateverGenNHibernate.EN.Whatever.RetoEN reto_puntuacion;
        [ScaffoldColumn(false)]
        public int idReto { get; set; }

        //public WhateverGenNHibernate.EN.Whatever.EventoEN evento_puntuacion;
        [ScaffoldColumn(false)]
        public int idEvento { get; set; }
        
        //public int puntuacion;
        [Display(Prompt = "Puntuacion", Description = "Puntuacion", Name = "Puntuacion")]
        public int puntuacion{ get; set; }
    }
}