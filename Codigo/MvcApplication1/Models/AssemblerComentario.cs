using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using WhateverGenNHibernate.EN.Whatever;

namespace MvcApplication1.Models
{
    public class AssemblerComentario
    {
        public Comentario ConvertENToModelUI(ComentarioEN comen)
        {
            if (comen!=null)
            {
                Comentario comentario = new Comentario();
                comentario.id = comen.ID;
                comentario.Texto = comen.Texto;
                comentario.comentario_usuario = comen.Comentario_usuario;
                comentario.comentario_evento2 = comen.Comentario_evento2;
                comentario.comentario_reto = comen.Comentario_reto;
                comentario.Creador = comen.Creador;
                return comentario; 
            }
            else
            {
                return null;
            }

        }
        public IList<Comentario> ConvertListENToModel(IList<ComentarioEN> ens)
        {
            IList<Comentario> comlist = new List<Comentario>();
            foreach (ComentarioEN comen in ens)
            {
                comlist.Add(ConvertENToModelUI(comen));
            }
            return comlist;
        }

    }
}
