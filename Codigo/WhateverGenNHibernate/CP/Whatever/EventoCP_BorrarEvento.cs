
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;



/*PROTECTED REGION ID(usingWhateverGenNHibernate.CP.Whatever_Evento_borrarEvento) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CP.Whatever
{
public partial class EventoCP : BasicCP
{
public void BorrarEvento (int p_oid)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CP.Whatever_Evento_borrarEvento) ENABLED START*/

        IEventoCAD eventoCAD = null;
        EventoCEN eventoCEN = null;



        try
        {
                SessionInitializeTransaction ();
                eventoCAD = new EventoCAD (session);
                eventoCEN = new  EventoCEN (eventoCAD);

                MapaCAD mapa = new MapaCAD ();
                PuntuacionCAD punt = new PuntuacionCAD ();
                ReporteCAD rep = new ReporteCAD ();

                System.Collections.Generic.IList<MapaEN> mapas;
                System.Collections.Generic.IList<PuntuacionEN> puntos;
                System.Collections.Generic.IList<ReporteEN> reportes;

                eventoCAD.Destroy (p_oid);

                mapas = mapa.FiltrarPorEvento (p_oid);
                mapa.Destroy (mapas [0].Id);

                puntos = punt.FiltrarTodosEventos (p_oid);
                foreach (PuntuacionEN element in puntos) {
                        punt.Destroy (element.Id);
                }

                reportes = rep.FiltrarTodosEventos (p_oid);
                foreach (ReporteEN element in reportes) {
                        rep.Destroy (element.ID);
                }


                SessionCommit ();
        }
        catch (Exception ex)
        {
                SessionRollBack ();
                throw ex;
        }
        finally
        {
                SessionClose ();
        }


        /*PROTECTED REGION END*/
}
}
}
