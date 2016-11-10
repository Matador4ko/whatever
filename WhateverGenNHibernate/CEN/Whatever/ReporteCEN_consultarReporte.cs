
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Reporte_consultarReporte) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class ReporteCEN
{
public string ConsultarReporte (int id_usuario, int id_reto, int id_gym)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Reporte_consultarReporte) ENABLED START*/

        // Write here your custom code...
        if (id_gym != -1 && id_reto == -1) {
                ReporteCEN report = new ReporteCEN ();
                //ReporteEN reporteBueno = new ReporteEN();

                System.Collections.Generic.IList<ReporteEN> listaR;
                listaR = report.GetAll (0, 0);
                foreach (ReporteEN element in listaR) {
                        if (element.Reporte.ID == id_gym && id_usuario == element.Usuario_reporte.ID) {
                                return element.Motivo;
                        }
                        else if (element.Reporte.ID == id_gym && id_usuario != element.Usuario_reporte.ID) {
                                return null;
                        }
                }
        }
        else{
                ReporteCEN report = new ReporteCEN ();
                //ReporteEN reporteBueno = new ReporteEN();

                System.Collections.Generic.IList<ReporteEN> listaR;
                listaR = report.GetAll (0, 0);
                foreach (ReporteEN element in listaR) {
                        if (element.Reporte_reto2.ID == id_reto && id_usuario == element.Usuario_reporte.ID) {
                                return element.Motivo;
                        }
                        else if (element.Reporte_reto2.ID == id_reto && id_usuario != element.Usuario_reporte.ID) {
                                return null;
                        }
                }
        }
        return null;
        /*PROTECTED REGION END*/
}
}
}
