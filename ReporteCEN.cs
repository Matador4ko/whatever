

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.Exceptions;

using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;


namespace WhateverGenNHibernate.CEN.Whatever
{
/*
 *      Definition of the class ReporteCEN
 *
 */
public partial class ReporteCEN
{
private IReporteCAD _IReporteCAD;

public ReporteCEN()
{
        this._IReporteCAD = new ReporteCAD ();
}

public ReporteCEN(IReporteCAD _IReporteCAD)
{
        this._IReporteCAD = _IReporteCAD;
}

public IReporteCAD get_IReporteCAD ()
{
        return this._IReporteCAD;
}

public int New_ (string p_motivo, int p_ID, int p_usuario_reporte, System.Collections.Generic.IList<int> p_admin_reporte)
{
        ReporteEN reporteEN = null;
        int oid;

        //Initialized ReporteEN
        reporteEN = new ReporteEN ();
        reporteEN.Motivo = p_motivo;

        reporteEN.ID = p_ID;


        if (p_usuario_reporte != -1) {
                // El argumento p_usuario_reporte -> Property usuario_reporte es oid = false
                // Lista de oids ID
                reporteEN.Usuario_reporte = new WhateverGenNHibernate.EN.Whatever.UsuarioEN ();
                reporteEN.Usuario_reporte.ID = p_usuario_reporte;
        }


        reporteEN.Admin_reporte = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.AdminEN>();
        if (p_admin_reporte != null) {
                foreach (int item in p_admin_reporte) {
                        WhateverGenNHibernate.EN.Whatever.AdminEN en = new WhateverGenNHibernate.EN.Whatever.AdminEN ();
                        en.ID = item;
                        reporteEN.Admin_reporte.Add (en);
                }
        }

        else{
                reporteEN.Admin_reporte = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.AdminEN>();
        }

        //Call to ReporteCAD

        oid = _IReporteCAD.New_ (reporteEN);
        return oid;
}

public void Destroy (int ID
                     )
{
        _IReporteCAD.Destroy (ID);
}
}
}
