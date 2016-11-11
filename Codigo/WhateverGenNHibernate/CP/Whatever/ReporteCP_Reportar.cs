
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;



/*PROTECTED REGION ID(usingWhateverGenNHibernate.CP.Whatever_Reporte_Reportar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CP.Whatever
{
public partial class ReporteCP : BasicCP
{
public void Reportar (int id_usuario, int id_gym, int id_reto, string motivo)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CP.Whatever_Reporte_Reportar) ENABLED START*/

        IReporteCAD reporteCAD = null;
        ReporteCEN reporteCEN = null;



        try
        {
                SessionInitializeTransaction ();
                reporteCAD = new ReporteCAD (session);
                reporteCEN = new  ReporteCEN (reporteCAD);



                ReporteEN repor = new ReporteEN ();
                ReporteCAD reporcad = new ReporteCAD ();
                AdminCEN admincen = new AdminCEN ();

                System.Collections.Generic.IList<AdminEN> admin = null;
                System.Collections.Generic.IList<AdminEN> numadmins = null;
                System.Collections.Generic.IList<ReporteEN> listareporte;
                listareporte = reporcad.GetAll (0, 0);
                int aux = 0;

                foreach (AdminEN element in admin) {
                        numadmins.Add (element);
                }
                aux = listareporte [listareporte.Count - 1].ID;

                admin = admincen.GetAll (0, 0);
                repor.Admin_reporte = numadmins;
                repor.Motivo = motivo;
                repor.Reporte.ID = id_gym;
                repor.Reporte_reto2.ID = id_reto;
                repor.Usuario_reporte.ID = id_usuario;


                reporcad.New_ (repor);


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
