
using System;
// Definición clase EventoEN
namespace WhateverGenNHibernate.EN.Whatever
{
public partial class EventoEN
{
/**
 *	Atributo titulo
 */
private string titulo;



/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo precio
 */
private int precio;



/**
 *	Atributo creador
 */
private string creador;



/**
 *	Atributo iD
 */
private int iD;



/**
 *	Atributo usuario_evento
 */
private WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario_evento;



/**
 *	Atributo puntuacion_evento2
 */
private System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> puntuacion_evento2;



/**
 *	Atributo evento_mapa
 */
private System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.MapaEN> evento_mapa;



/**
 *	Atributo comentario_evento
 */
private System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> comentario_evento;



/**
 *	Atributo reporte_evento2
 */
private System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> reporte_evento2;






public virtual string Titulo {
        get { return titulo; } set { titulo = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual int Precio {
        get { return precio; } set { precio = value;  }
}



public virtual string Creador {
        get { return creador; } set { creador = value;  }
}



public virtual int ID {
        get { return iD; } set { iD = value;  }
}



public virtual WhateverGenNHibernate.EN.Whatever.UsuarioEN Usuario_evento {
        get { return usuario_evento; } set { usuario_evento = value;  }
}



public virtual System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> Puntuacion_evento2 {
        get { return puntuacion_evento2; } set { puntuacion_evento2 = value;  }
}



public virtual System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.MapaEN> Evento_mapa {
        get { return evento_mapa; } set { evento_mapa = value;  }
}



public virtual System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> Comentario_evento {
        get { return comentario_evento; } set { comentario_evento = value;  }
}



public virtual System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> Reporte_evento2 {
        get { return reporte_evento2; } set { reporte_evento2 = value;  }
}





public EventoEN()
{
        puntuacion_evento2 = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.PuntuacionEN>();
        evento_mapa = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.MapaEN>();
        comentario_evento = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.ComentarioEN>();
        reporte_evento2 = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.ReporteEN>();
}



public EventoEN(int iD, string titulo, string descripcion, Nullable<DateTime> fecha, int precio, string creador, WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario_evento, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> puntuacion_evento2, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.MapaEN> evento_mapa, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> comentario_evento, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> reporte_evento2
                )
{
        this.init (ID, titulo, descripcion, fecha, precio, creador, usuario_evento, puntuacion_evento2, evento_mapa, comentario_evento, reporte_evento2);
}


public EventoEN(EventoEN evento)
{
        this.init (ID, evento.Titulo, evento.Descripcion, evento.Fecha, evento.Precio, evento.Creador, evento.Usuario_evento, evento.Puntuacion_evento2, evento.Evento_mapa, evento.Comentario_evento, evento.Reporte_evento2);
}

private void init (int ID
                   , string titulo, string descripcion, Nullable<DateTime> fecha, int precio, string creador, WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario_evento, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> puntuacion_evento2, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.MapaEN> evento_mapa, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> comentario_evento, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> reporte_evento2)
{
        this.ID = ID;


        this.Titulo = titulo;

        this.Descripcion = descripcion;

        this.Fecha = fecha;

        this.Precio = precio;

        this.Creador = creador;

        this.Usuario_evento = usuario_evento;

        this.Puntuacion_evento2 = puntuacion_evento2;

        this.Evento_mapa = evento_mapa;

        this.Comentario_evento = comentario_evento;

        this.Reporte_evento2 = reporte_evento2;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        EventoEN t = obj as EventoEN;
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
