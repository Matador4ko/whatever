
using System;
// Definición clase ComentarioEN
namespace WhateverGenNHibernate.EN.Whatever
{
public partial class ComentarioEN
{
/**
 *	Atributo texto
 */
private string texto;



/**
 *	Atributo creador
 */
private string creador;



/**
 *	Atributo iD
 */
private int iD;



/**
 *	Atributo comentario_usuario
 */
private WhateverGenNHibernate.EN.Whatever.UsuarioEN comentario_usuario;



/**
 *	Atributo comentario_evento2
 */
private WhateverGenNHibernate.EN.Whatever.EventoEN comentario_evento2;



/**
 *	Atributo comentario_reto
 */
private WhateverGenNHibernate.EN.Whatever.RetoEN comentario_reto;






public virtual string Texto {
        get { return texto; } set { texto = value;  }
}



public virtual string Creador {
        get { return creador; } set { creador = value;  }
}



public virtual int ID {
        get { return iD; } set { iD = value;  }
}



public virtual WhateverGenNHibernate.EN.Whatever.UsuarioEN Comentario_usuario {
        get { return comentario_usuario; } set { comentario_usuario = value;  }
}



public virtual WhateverGenNHibernate.EN.Whatever.EventoEN Comentario_evento2 {
        get { return comentario_evento2; } set { comentario_evento2 = value;  }
}



public virtual WhateverGenNHibernate.EN.Whatever.RetoEN Comentario_reto {
        get { return comentario_reto; } set { comentario_reto = value;  }
}





public ComentarioEN()
{
}



public ComentarioEN(int iD, string texto, string creador, WhateverGenNHibernate.EN.Whatever.UsuarioEN comentario_usuario, WhateverGenNHibernate.EN.Whatever.EventoEN comentario_evento2, WhateverGenNHibernate.EN.Whatever.RetoEN comentario_reto
                    )
{
        this.init (ID, texto, creador, comentario_usuario, comentario_evento2, comentario_reto);
}


public ComentarioEN(ComentarioEN comentario)
{
        this.init (ID, comentario.Texto, comentario.Creador, comentario.Comentario_usuario, comentario.Comentario_evento2, comentario.Comentario_reto);
}

private void init (int ID
                   , string texto, string creador, WhateverGenNHibernate.EN.Whatever.UsuarioEN comentario_usuario, WhateverGenNHibernate.EN.Whatever.EventoEN comentario_evento2, WhateverGenNHibernate.EN.Whatever.RetoEN comentario_reto)
{
        this.ID = ID;


        this.Texto = texto;

        this.Creador = creador;

        this.Comentario_usuario = comentario_usuario;

        this.Comentario_evento2 = comentario_evento2;

        this.Comentario_reto = comentario_reto;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ComentarioEN t = obj as ComentarioEN;
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
