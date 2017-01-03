
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
 *	Atributo paso
 */
private System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PasoEN> paso;






public virtual int NumPasos {
        get { return numPasos; } set { numPasos = value;  }
}



public virtual System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PasoEN> Paso {
        get { return paso; } set { paso = value;  }
}





public GymkanaEN() : base ()
{
        paso = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.PasoEN>();
}



public GymkanaEN(int iD, int numPasos, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PasoEN> paso
                 , string titulo, string descripcion, Nullable<DateTime> fecha, double precio, WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> puntuacion, WhateverGenNHibernate.EN.Whatever.MapaEN mapa, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> comentario, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> reporte
                 )
{
        this.init (ID, numPasos, paso, titulo, descripcion, fecha, precio, usuario, puntuacion, mapa, comentario, reporte);
}


public GymkanaEN(GymkanaEN gymkana)
{
        this.init (ID, gymkana.NumPasos, gymkana.Paso, gymkana.Titulo, gymkana.Descripcion, gymkana.Fecha, gymkana.Precio, gymkana.Usuario, gymkana.Puntuacion, gymkana.Mapa, gymkana.Comentario, gymkana.Reporte);
}

private void init (int ID
                   , int numPasos, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PasoEN> paso, string titulo, string descripcion, Nullable<DateTime> fecha, double precio, WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> puntuacion, WhateverGenNHibernate.EN.Whatever.MapaEN mapa, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> comentario, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> reporte)
{
        this.ID = ID;


        this.NumPasos = numPasos;

        this.Paso = paso;

        this.Titulo = titulo;

        this.Descripcion = descripcion;

        this.Fecha = fecha;

        this.Precio = precio;

        this.Usuario = usuario;

        this.Puntuacion = puntuacion;

        this.Mapa = mapa;

        this.Comentario = comentario;

        this.Reporte = reporte;
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
