
using System;
// Definición clase PuntuacionEN
namespace WhateverGenNHibernate.EN.Whatever
{
public partial class PuntuacionEN
{
/**
 *	Atributo usuario_puntuacion2
 */
private WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario_puntuacion2;



/**
 *	Atributo reto_puntuacion
 */
private WhateverGenNHibernate.EN.Whatever.RetoEN reto_puntuacion;



/**
 *	Atributo evento_puntuacion
 */
private WhateverGenNHibernate.EN.Whatever.EventoEN evento_puntuacion;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo puntuacion
 */
private int puntuacion;






public virtual WhateverGenNHibernate.EN.Whatever.UsuarioEN Usuario_puntuacion2 {
        get { return usuario_puntuacion2; } set { usuario_puntuacion2 = value;  }
}



public virtual WhateverGenNHibernate.EN.Whatever.RetoEN Reto_puntuacion {
        get { return reto_puntuacion; } set { reto_puntuacion = value;  }
}



public virtual WhateverGenNHibernate.EN.Whatever.EventoEN Evento_puntuacion {
        get { return evento_puntuacion; } set { evento_puntuacion = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual int Puntuacion {
        get { return puntuacion; } set { puntuacion = value;  }
}





public PuntuacionEN()
{
}



public PuntuacionEN(int id, WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario_puntuacion2, WhateverGenNHibernate.EN.Whatever.RetoEN reto_puntuacion, WhateverGenNHibernate.EN.Whatever.EventoEN evento_puntuacion, int puntuacion
                    )
{
        this.init (Id, usuario_puntuacion2, reto_puntuacion, evento_puntuacion, puntuacion);
}


public PuntuacionEN(PuntuacionEN puntuacion)
{
        this.init (Id, puntuacion.Usuario_puntuacion2, puntuacion.Reto_puntuacion, puntuacion.Evento_puntuacion, puntuacion.Puntuacion);
}

private void init (int id
                   , WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario_puntuacion2, WhateverGenNHibernate.EN.Whatever.RetoEN reto_puntuacion, WhateverGenNHibernate.EN.Whatever.EventoEN evento_puntuacion, int puntuacion)
{
        this.Id = id;


        this.Usuario_puntuacion2 = usuario_puntuacion2;

        this.Reto_puntuacion = reto_puntuacion;

        this.Evento_puntuacion = evento_puntuacion;

        this.Puntuacion = puntuacion;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PuntuacionEN t = obj as PuntuacionEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
