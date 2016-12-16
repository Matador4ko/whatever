
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;



/*PROTECTED REGION ID(usingWhateverGenNHibernate.CP.Whatever_Gymkana_borrarGymkana) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CP.Whatever
{
public partial class GymkanaCP : BasicCP
{
public void BorrarGymkana (int p_oid)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CP.Whatever_Gymkana_borrarGymkana) ENABLED START*/

        IGymkanaCAD gymkanaCAD = null;
        GymkanaCEN gymkanaCEN = null;



        try
        {
                SessionInitializeTransaction ();
                gymkanaCAD = new GymkanaCAD (session);
                gymkanaCEN = new  GymkanaCEN (gymkanaCAD);


                MapaCAD mapa = new MapaCAD (session);
                PuntuacionCAD punt = new PuntuacionCAD (session);
                ReporteCAD rep = new ReporteCAD (session);
                PasoCAD pas = new PasoCAD (session);

                System.Collections.Generic.IList<MapaEN> mapas;
                System.Collections.Generic.IList<PuntuacionEN> puntos;
                System.Collections.Generic.IList<ReporteEN> reportes;
                System.Collections.Generic.IList<PasoEN> pasos;

                gymkanaCAD.Destroy (p_oid);

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

                pasos = gymkanaCEN.VerPasos (p_oid);
                foreach (PasoEN element in pasos) {
                        pas.Destroy (element.ID);
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
