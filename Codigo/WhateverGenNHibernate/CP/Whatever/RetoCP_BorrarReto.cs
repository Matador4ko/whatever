
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;



/*PROTECTED REGION ID(usingWhateverGenNHibernate.CP.Whatever_Reto_borrarReto) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CP.Whatever
{
public partial class RetoCP : BasicCP
{
public void BorrarReto (int p_oid)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CP.Whatever_Reto_borrarReto) ENABLED START*/

        IRetoCAD retoCAD = null;
        RetoCEN retoCEN = null;



        try
        {
                SessionInitializeTransaction ();
                retoCAD = new RetoCAD (session);
                retoCEN = new  RetoCEN (retoCAD);


                PuntuacionCAD punt = new PuntuacionCAD (session);
                ReporteCAD rep = new ReporteCAD (session);

                System.Collections.Generic.IList<PuntuacionEN> puntos;
                System.Collections.Generic.IList<ReporteEN> reportes;

                retoCAD.Destroy (p_oid);

                puntos = punt.FiltrarTodosRetos (p_oid);
                foreach (PuntuacionEN element in puntos) {
                        punt.Destroy (element.Id);
                }

                reportes = rep.FiltrarTodosRetos (p_oid);
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
