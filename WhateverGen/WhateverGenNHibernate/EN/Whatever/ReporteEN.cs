
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
 *	Atributo usuario
 */
private WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario;



/**
 *	Atributo reto
 */
private WhateverGenNHibernate.EN.Whatever.RetoEN reto;



/**
 *	Atributo evento
 */
private WhateverGenNHibernate.EN.Whatever.EventoEN evento;






public virtual string Motivo {
        get { return motivo; } set { motivo = value;  }
}



public virtual int ID {
        get { return iD; } set { iD = value;  }
}



public virtual WhateverGenNHibernate.EN.Whatever.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual WhateverGenNHibernate.EN.Whatever.RetoEN Reto {
        get { return reto; } set { reto = value;  }
}



public virtual WhateverGenNHibernate.EN.Whatever.EventoEN Evento {
        get { return evento; } set { evento = value;  }
}





public ReporteEN()
{
}



public ReporteEN(int iD, string motivo, WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario, WhateverGenNHibernate.EN.Whatever.RetoEN reto, WhateverGenNHibernate.EN.Whatever.EventoEN evento
                 )
{
        this.init (ID, motivo, usuario, reto, evento);
}


public ReporteEN(ReporteEN reporte)
{
        this.init (ID, reporte.Motivo, reporte.Usuario, reporte.Reto, reporte.Evento);
}

private void init (int ID
                   , string motivo, WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario, WhateverGenNHibernate.EN.Whatever.RetoEN reto, WhateverGenNHibernate.EN.Whatever.EventoEN evento)
{
        this.ID = ID;


        this.Motivo = motivo;

        this.Usuario = usuario;

        this.Reto = reto;

        this.Evento = evento;
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
