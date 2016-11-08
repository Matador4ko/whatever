
using System;
// Definición clase RetoEN
namespace WhateverGenNHibernate.EN.Whatever
{
public partial class RetoEN
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
 *	Atributo tipo
 */
private string tipo;



/**
 *	Atributo precio
 */
private int precio;



/**
 *	Atributo imagen
 */
private string imagen;



/**
 *	Atributo creador
 */
private string creador;



/**
 *	Atributo iD
 */
private int iD;



/**
 *	Atributo usuario_reto2
 */
private WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario_reto2;



/**
 *	Atributo id_mapa
 */
private System.Collections.Generic.IList<int> id_mapa;



/**
 *	Atributo reto_mapa2
 */
private System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.MapaEN> reto_mapa2;



/**
 *	Atributo reto_puntuacion2
 */
private System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> reto_puntuacion2;



/**
 *	Atributo comentario_reto2
 */
private System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> comentario_reto2;



/**
 *	Atributo reporte
 */
private WhateverGenNHibernate.EN.Whatever.ReporteEN reporte;






public virtual string Titulo {
        get { return titulo; } set { titulo = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual string Tipo {
        get { return tipo; } set { tipo = value;  }
}



public virtual int Precio {
        get { return precio; } set { precio = value;  }
}



public virtual string Imagen {
        get { return imagen; } set { imagen = value;  }
}



public virtual string Creador {
        get { return creador; } set { creador = value;  }
}



public virtual int ID {
        get { return iD; } set { iD = value;  }
}



public virtual WhateverGenNHibernate.EN.Whatever.UsuarioEN Usuario_reto2 {
        get { return usuario_reto2; } set { usuario_reto2 = value;  }
}



public virtual System.Collections.Generic.IList<int> Id_mapa {
        get { return id_mapa; } set { id_mapa = value;  }
}



public virtual System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.MapaEN> Reto_mapa2 {
        get { return reto_mapa2; } set { reto_mapa2 = value;  }
}



public virtual System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> Reto_puntuacion2 {
        get { return reto_puntuacion2; } set { reto_puntuacion2 = value;  }
}



public virtual System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> Comentario_reto2 {
        get { return comentario_reto2; } set { comentario_reto2 = value;  }
}



public virtual WhateverGenNHibernate.EN.Whatever.ReporteEN Reporte {
        get { return reporte; } set { reporte = value;  }
}





public RetoEN()
{
        reto_mapa2 = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.MapaEN>();
        reto_puntuacion2 = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.PuntuacionEN>();
        comentario_reto2 = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.ComentarioEN>();
}



public RetoEN(int iD, string titulo, string descripcion, string tipo, int precio, string imagen, string creador, WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario_reto2, System.Collections.Generic.IList<int> id_mapa, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.MapaEN> reto_mapa2, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> reto_puntuacion2, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> comentario_reto2, WhateverGenNHibernate.EN.Whatever.ReporteEN reporte
              )
{
        this.init (ID, titulo, descripcion, tipo, precio, imagen, creador, usuario_reto2, id_mapa, reto_mapa2, reto_puntuacion2, comentario_reto2, reporte);
}


public RetoEN(RetoEN reto)
{
        this.init (ID, reto.Titulo, reto.Descripcion, reto.Tipo, reto.Precio, reto.Imagen, reto.Creador, reto.Usuario_reto2, reto.Id_mapa, reto.Reto_mapa2, reto.Reto_puntuacion2, reto.Comentario_reto2, reto.Reporte);
}

private void init (int ID
                   , string titulo, string descripcion, string tipo, int precio, string imagen, string creador, WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario_reto2, System.Collections.Generic.IList<int> id_mapa, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.MapaEN> reto_mapa2, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> reto_puntuacion2, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> comentario_reto2, WhateverGenNHibernate.EN.Whatever.ReporteEN reporte)
{
        this.ID = ID;


        this.Titulo = titulo;

        this.Descripcion = descripcion;

        this.Tipo = tipo;

        this.Precio = precio;

        this.Imagen = imagen;

        this.Creador = creador;

        this.Usuario_reto2 = usuario_reto2;

        this.Id_mapa = id_mapa;

        this.Reto_mapa2 = reto_mapa2;

        this.Reto_puntuacion2 = reto_puntuacion2;

        this.Comentario_reto2 = comentario_reto2;

        this.Reporte = reporte;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        RetoEN t = obj as RetoEN;
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
