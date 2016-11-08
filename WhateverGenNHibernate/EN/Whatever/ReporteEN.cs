
using System;
// Definición clase ReporteEN
namespace WhateverGenNHibernate.EN.Whatever
{
public partial class ReporteEN
{
/**
 *	Atributo motivo
 */
private string motivo;



/**
 *	Atributo iD
 */
private int iD;



/**
 *	Atributo usuario_reporte
 */
private WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario_reporte;



/**
 *	Atributo admin_reporte
 */
private System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.AdminEN> admin_reporte;



/**
 *	Atributo reporte_reto2
 */
private System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.RetoEN> reporte_reto2;



/**
 *	Atributo reporte
 */
private WhateverGenNHibernate.EN.Whatever.EventoEN reporte;






public virtual string Motivo {
        get { return motivo; } set { motivo = value;  }
}



public virtual int ID {
        get { return iD; } set { iD = value;  }
}



public virtual WhateverGenNHibernate.EN.Whatever.UsuarioEN Usuario_reporte {
        get { return usuario_reporte; } set { usuario_reporte = value;  }
}



public virtual System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.AdminEN> Admin_reporte {
        get { return admin_reporte; } set { admin_reporte = value;  }
}



public virtual System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.RetoEN> Reporte_reto2 {
        get { return reporte_reto2; } set { reporte_reto2 = value;  }
}



public virtual WhateverGenNHibernate.EN.Whatever.EventoEN Reporte {
        get { return reporte; } set { reporte = value;  }
}





public ReporteEN()
{
        admin_reporte = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.AdminEN>();
        reporte_reto2 = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.RetoEN>();
}



public ReporteEN(int iD, string motivo, WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario_reporte, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.AdminEN> admin_reporte, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.RetoEN> reporte_reto2, WhateverGenNHibernate.EN.Whatever.EventoEN reporte
                 )
{
        this.init (ID, motivo, usuario_reporte, admin_reporte, reporte_reto2, reporte);
}


public ReporteEN(ReporteEN reporte)
{
        this.init (ID, reporte.Motivo, reporte.Usuario_reporte, reporte.Admin_reporte, reporte.Reporte_reto2, reporte.Reporte);
}

private void init (int ID
                   , string motivo, WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario_reporte, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.AdminEN> admin_reporte, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.RetoEN> reporte_reto2, WhateverGenNHibernate.EN.Whatever.EventoEN reporte)
{
        this.ID = ID;


        this.Motivo = motivo;

        this.Usuario_reporte = usuario_reporte;

        this.Admin_reporte = admin_reporte;

        this.Reporte_reto2 = reporte_reto2;

        this.Reporte = reporte;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ReporteEN t = obj as ReporteEN;
        if (t == null)
                return false;
        if (ID.Equals (t.ID))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.ID.GetHashCode ();
        return hash;
}
}
}
