using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WhateverGenNHibernate.EN.Whatever;

namespace MvcApplication1.Models
{
    public class AssemblerReto
    {
        public Reto ConvertENToModelUI(RetoEN en)
        {
            Reto ret = new Reto();
            ret.id = en.ID;
            ret.Precio = en.Precio;
            ret.Descripcion = en.Descripcion;
            ret.Imagen = en.Imagen;
            ret.Tipo = en.Tipo;
            ret.Usuario = en.Usuario_reto2;
            ret.Puntuacion = en.Reto_puntuacion2;
            //ret.Comentarios=en.comentario_reto2;
            //ret.Reporte = en.reporte;
            return ret;


        }
        public IList<Reto> ConvertListENToModel(IList<RetoEN> ens)
        {
            IList<Reto> rets = new List<Reto>();
            foreach (RetoEN en in ens)
            {
                rets.Add(ConvertENToModelUI(en));
            }
            return rets;
        }
        /*
        private string titulo;
        private string descripcion;
        private string tipo;
        private int precio;
        private string imagen;
        private int iD;
        private WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario_reto2;
        private System.Collections.Generic.IList<int> id_mapa; :roto2: 
        private System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> reto_puntuacion2;
        private System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> comentario_reto2;
        private System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> reporte;
        */
    }
}