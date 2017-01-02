
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;



/*PROTECTED REGION ID(usingWhateverGenNHibernate.CP.Whatever_Reporte_borrarUnReporte) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CP.Whatever
{
public partial class ReporteCP : BasicCP
{
public void BorrarUnReporte (int p_oid)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CP.Whatever_Reporte_borrarUnReporte) ENABLED START*/

        IReporteCAD reporteCAD = null;
        ReporteCEN reporteCEN = null;



        try
        {
                SessionInitializeTransaction ();
                reporteCAD = new ReporteCAD (session);
                reporteCEN = new  ReporteCEN (reporteCAD);



                // Write here your custom transaction ...

                EventoEN even = new EventoEN ();
                even = reporteCAD.GetID (p_oid).Evento;
                RetoEN reten = new RetoEN ();
                reten = reporteCAD.GetID (p_oid).Reto;
                if (even != null) {
                        reporteCAD.UnrelationerReporteEvento (p_oid, even.ID);
                        reporteCAD.Destroy (p_oid);
                }
                else{
                        reporteCAD.UnrelationerReporteReto (p_oid, reten.ID);
                        reporteCAD.Destroy (p_oid);
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
