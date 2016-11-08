
using System;
// Definición clase GymkanaEN
namespace WhateverGenNHibernate.EN.Whatever
{
public partial class GymkanaEN                                                                      : WhateverGenNHibernate.EN.Whatever.EventoEN


{
/**
 *	Atributo numPasos
 */
private int numPasos;



/**
 *	Atributo gymkana_paso
 */
private System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PasoEN> gymkana_paso;






public virtual int NumPasos {
        get { return numPasos; } set { numPasos = value;  }
}



public virtual System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PasoEN> Gymkana_paso {
        get { return gymkana_paso; } set { gymkana_paso = value;  }
}





public GymkanaEN() : base ()
{
        gymkana_paso = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.PasoEN>();
}



public GymkanaEN(int iD, int numPasos, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PasoEN> gymkana_paso
                 , string titulo, string descripcion, Nullable<DateTime> fecha, int precio, string creador, WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario_evento, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> puntuacion_evento2, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.MapaEN> evento_mapa, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> comentario_evento, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> reporte_evento2
                 )
{
        this.init (ID, numPasos, gymkana_paso, titulo, descripcion, fecha, precio, creador, usuario_evento, puntuacion_evento2, evento_mapa, comentario_evento, reporte_evento2);
}


public GymkanaEN(GymkanaEN gymkana)
{
        this.init (ID, gymkana.NumPasos, gymkana.Gymkana_paso, gymkana.Titulo, gymkana.Descripcion, gymkana.Fecha, gymkana.Precio, gymkana.Creador, gymkana.Usuario_evento, gymkana.Puntuacion_evento2, gymkana.Evento_mapa, gymkana.Comentario_evento, gymkana.Reporte_evento2);
}

private void init (int ID
                   , int numPasos, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PasoEN> gymkana_paso, string titulo, string descripcion, Nullable<DateTime> fecha, int precio, string creador, WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario_evento, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> puntuacion_evento2, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.MapaEN> evento_mapa, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> comentario_evento, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> reporte_evento2)
{
        this.ID = ID;


        this.NumPasos = numPasos;

        this.Gymkana_paso = gymkana_paso;

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
        GymkanaEN t = obj as GymkanaEN;
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
