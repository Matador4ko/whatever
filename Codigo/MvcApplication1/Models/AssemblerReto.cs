using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CP.Whatever;
using WhateverGenNHibernate.CEN.Whatever;

namespace MvcApplication1.Models
{
    public class AssemblerReto
    {
        public Reto ConvertENToModelUI(RetoEN reten)
        {
            ComentarioCEN c = new ComentarioCEN();
            PuntuacionCEN p = new PuntuacionCEN();
            Reto reto = new Reto();
            reto.Titulo = reten.Titulo;
            reto.Descripcion = reten.Descripcion;
            reto.Tipo = reten.Tipo;
            reto.Precio = reten.Precio;
            reto.Imagen = reten.Imagen;
            reto.Creador = reten.Usuario_reto2.Nombre;
            //puntuacion
            reto.Puntuacion = p.VerMedia(-1, reten.ID);

            //comentarios
            IList<ComentarioEN> listafiltro = new List<ComentarioEN>();
            listafiltro = c.PABLOFILTROCOMENTAROSRETO(reten.ID);
            
            AssemblerComentario ass = new AssemblerComentario();
            reto.Comentarios = ass.ConvertListENToModel(listafiltro);
            
            //atributos ocultos del model
            reto.id = reten.ID;
            reto.usuario_reto = reten.Usuario_reto2;
            reto.idMapas = reten.Id_mapa;

            //retos
            IList<ReporteEN> aux3 = new List<ReporteEN>();
            ReporteCEN reportecen = new ReporteCEN();
            aux3 = reportecen.FiltrarTodosRetos(reten.ID); 
            reto.reportes = aux3;
            return reto;
        }

        public IList<Reto> ConvertListENToModel(IList<RetoEN> ens)
        {
            IList<Reto> retlist = new List<Reto>();
            foreach (RetoEN reten in ens)
            {
                retlist.Add(ConvertENToModelUI(reten));
            }
            return retlist;
        }

    }
}