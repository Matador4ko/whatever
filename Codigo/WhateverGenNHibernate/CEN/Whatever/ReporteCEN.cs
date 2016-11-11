

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

public int New_ (string p_motivo, int p_usuario_reporte, System.Collections.Generic.IList<int> p_admin_reporte, int p_reporte_reto2, int p_reporte)
{
        ReporteEN reporteEN = null;
        int oid;

        //Initialized ReporteEN
        reporteEN = new ReporteEN ();
        reporteEN.Motivo = p_motivo;


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


        if (p_reporte_reto2 != -1) {
                // El argumento p_reporte_reto2 -> Property reporte_reto2 es oid = false
                // Lista de oids ID
                reporteEN.Reporte_reto2 = new WhateverGenNHibernate.EN.Whatever.RetoEN ();
                reporteEN.Reporte_reto2.ID = p_reporte_reto2;
        }


        if (p_reporte != -1) {
                // El argumento p_reporte -> Property reporte es oid = false
                // Lista de oids ID
                reporteEN.Reporte = new WhateverGenNHibernate.EN.Whatever.EventoEN ();
                reporteEN.Reporte.ID = p_reporte;
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

public System.Collections.Generic.IList<ReporteEN> GetAll (int first, int size)
{
        System.Collections.Generic.IList<ReporteEN> list = null;

        list = _IReporteCAD.GetAll (first, size);
        return list;
}
public ReporteEN GetID (int ID
                        )
{
        ReporteEN reporteEN = null;

        reporteEN = _IReporteCAD.GetID (ID);
        return reporteEN;
}

public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> FiltrarEvento (int? id_evento, int ? id_usuario)
{
        return _IReporteCAD.FiltrarEvento (id_evento, id_usuario);
}
public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> FiltrarReto (int? id_reto, int ? id_usuario)
{
        return _IReporteCAD.FiltrarReto (id_reto, id_usuario);
}
}
}
