
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;



/*PROTECTED REGION ID(usingWhateverGenNHibernate.CP.Whatever_Reporte_operation2) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CP.Whatever
{
public partial class ReporteCP : BasicCP
{
public WhateverGenNHibernate.EN.Whatever.ReporteEN Operation2 (string p_motivo, int p_ID, int p_usuario_reporte, System.Collections.Generic.IList<int> p_admin_reporte)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CP.Whatever_Reporte_operation2) ENABLED START*/

        IReporteCAD reporteCAD = null;
        ReporteCEN reporteCEN = null;

        WhateverGenNHibernate.EN.Whatever.ReporteEN result = null;


        try
        {
                SessionInitializeTransaction ();
                reporteCAD = new ReporteCAD (session);
                reporteCEN = new  ReporteCEN (reporteCAD);




                int oid;
                //Initialized ReporteEN
                ReporteEN reporteEN;
                reporteEN = new ReporteEN ();
                reporteEN.Motivo = p_motivo;

                reporteEN.ID = p_ID;


                if (p_usuario_reporte != -1) {
                        reporteEN.Usuario_reporte = new WhateverGenNHibernate.EN.Whatever.UsuarioEN ();
                        reporteEN.Usuario_reporte.ID = p_usuario_reporte;
                }


                reporteEN.Admin_reporte = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.AdminEN>();
                if (p_admin_reporte != null) {
                        for (int item : p_admin_reporte) {
                                WhateverGenNHibernate.EN.Whatever.AdminEN en = new WhateverGenNHibernate.EN.Whatever.AdminEN ();
                                en.ID = item;
                                reporteEN.Admin_reporte ().Add (en);
                        }
                }

                else{
                        reporteEN.Admin_reporte = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.AdminEN>();
                }

                //Call to ReporteCAD

                oid = reporteCAD.Operation2 (reporteEN);
                result = reporteCAD.ReadOIDDefault (oid);



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
        return result;


        /*PROTECTED REGION END*/
}
}
}
