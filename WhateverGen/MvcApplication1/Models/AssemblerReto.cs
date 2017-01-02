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
            if (reten != null)
            {

                AssemblerReporte assR = new AssemblerReporte();
                ComentarioCEN c = new ComentarioCEN();
                PuntuacionCEN p = new PuntuacionCEN();
                Reto reto = new Reto();
                reto.Titulo = reten.Titulo;
                reto.Descripcion = reten.Descripcion;
                reto.Tipo = reten.Tipo;
                reto.Precio = reten.Precio;
                reto.Imagen = reten.Imagen;
                reto.Creador = reten.Usuario.Nombre;
                //puntuacion
                reto.Puntuacion = p.VerMediaReto(reten.ID);

                //comentarios
                IList<ComentarioEN> listafiltro = new List<ComentarioEN>();
                listafiltro = c.FiltrarComentarioPorReto(reten.ID);

                AssemblerComentario ass = new AssemblerComentario();
                reto.Comentarios = ass.ConvertListENToModel(listafiltro);

                //atributos ocultos del model
                reto.id = reten.ID;
                reto.usuario = reten.Usuario;
                reto.idMapas = reten.Id_mapa;

                //reportes
                IList<Reporte> aux3 = new List<Reporte>();
                ReporteCEN reportecen = new ReporteCEN();
                aux3 = assR.ConvertListENToModel(reportecen.FiltrarReportesPorReto(reten.ID));
                reto.Reportes = aux3;

                return reto;
            }
            else
            {
                return null;
            }
        }

        public IList<Reto> ConvertListENToModel(IList<RetoEN> ens)
        {
            if (ens != null && ens.Count > 0)
            {
                IList<Reto> retlist = new List<Reto>();
                foreach (RetoEN reten in ens)
                {
                    retlist.Add(ConvertENToModelUI(reten));
                }
                return retlist;
            }
            else
            {
                return null;
            }
        }

    }
}