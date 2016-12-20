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

        //public int puntuacion;
        [Display(Prompt = "Puntuacion", Description = "Puntuacion", Name = "Puntuacion")]
        public int puntuacion{ get; set; }

        //public WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario_puntuacion2;
        [Display(Prompt = "Puntuacion del usuario", Description = "Puntuacion del usuario" , Name = "PuntuacionUsuario")]
        public UsuarioEN usuario_puntuacion2{ get; set; }

        //public WhateverGenNHibernate.EN.Whatever.RetoEN reto_puntuacion;
        [Display(Prompt = "Puntuacion del reto", Description = "Puntuacion del reto", Name = "PuntuacionReto")]
        public RetoEN reto_puntuacion{ get; set; }

        //public WhateverGenNHibernate.EN.Whatever.EventoEN evento_puntuacion;
        [Display(Prompt = "Puntuacion del evento", Description = "Puntuacion del evento", Name = "PuntuacionEvento")]
        public EventoEN evento_puntuacion{ get; set; }


    }
}