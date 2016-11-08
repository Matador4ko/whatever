
using System;
// Definición clase UsuarioEN
namespace WhateverGenNHibernate.EN.Whatever
{
public partial class UsuarioEN
{
/**
 *	Atributo iD
 */
private int iD;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo seguidores
 */
private int seguidores;



/**
 *	Atributo edad
 */
private int edad;



/**
 *	Atributo sexo
 */
private string sexo;



/**
 *	Atributo facebook
 */
private string facebook;



/**
 *	Atributo instagram
 */
private string instagram;



/**
 *	Atributo historial
 */
private string historial;



/**
 *	Atributo usuario_reto
 */
private System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.RetoEN> usuario_reto;



/**
 *	Atributo usuario_usuario
 */
private System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.UsuarioEN> usuario_usuario;



/**
 *	Atributo usuario_usuario2
 */
private System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.UsuarioEN> usuario_usuario2;



/**
 *	Atributo usuario_reporte2
 */
private System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> usuario_reporte2;



/**
 *	Atributo usuario_puntuacion
 */
private System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> usuario_puntuacion;



/**
 *	Atributo comentario_usuario2
 */
private System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> comentario_usuario2;



/**
 *	Atributo usuario_evento2
 */
private System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.EventoEN> usuario_evento2;



/**
 *	Atributo contrasena
 */
private String contrasena;



/**
 *	Atributo email
 */
private string email;



/**
 *	Atributo foto
 */
private string foto;






public virtual int ID {
        get { return iD; } set { iD = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual int Seguidores {
        get { return seguidores; } set { seguidores = value;  }
}



public virtual int Edad {
        get { return edad; } set { edad = value;  }
}



public virtual string Sexo {
        get { return sexo; } set { sexo = value;  }
}



public virtual string Facebook {
        get { return facebook; } set { facebook = value;  }
}



public virtual string Instagram {
        get { return instagram; } set { instagram = value;  }
}



public virtual string Historial {
        get { return historial; } set { historial = value;  }
}



public virtual System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.RetoEN> Usuario_reto {
        get { return usuario_reto; } set { usuario_reto = value;  }
}



public virtual System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.UsuarioEN> Usuario_usuario {
        get { return usuario_usuario; } set { usuario_usuario = value;  }
}



public virtual System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.UsuarioEN> Usuario_usuario2 {
        get { return usuario_usuario2; } set { usuario_usuario2 = value;  }
}



public virtual System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> Usuario_reporte2 {
        get { return usuario_reporte2; } set { usuario_reporte2 = value;  }
}



public virtual System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> Usuario_puntuacion {
        get { return usuario_puntuacion; } set { usuario_puntuacion = value;  }
}



public virtual System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> Comentario_usuario2 {
        get { return comentario_usuario2; } set { comentario_usuario2 = value;  }
}



public virtual System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.EventoEN> Usuario_evento2 {
        get { return usuario_evento2; } set { usuario_evento2 = value;  }
}



public virtual String Contrasena {
        get { return contrasena; } set { contrasena = value;  }
}



public virtual string Email {
        get { return email; } set { email = value;  }
}



public virtual string Foto {
        get { return foto; } set { foto = value;  }
}





public UsuarioEN()
{
        usuario_reto = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.RetoEN>();
        usuario_usuario = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.UsuarioEN>();
        usuario_usuario2 = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.UsuarioEN>();
        usuario_reporte2 = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.ReporteEN>();
        usuario_puntuacion = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.PuntuacionEN>();
        comentario_usuario2 = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.ComentarioEN>();
        usuario_evento2 = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.EventoEN>();
}



public UsuarioEN(int iD, string nombre, int seguidores, int edad, string sexo, string facebook, string instagram, string historial, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.RetoEN> usuario_reto, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.UsuarioEN> usuario_usuario, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.UsuarioEN> usuario_usuario2, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> usuario_reporte2, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> usuario_puntuacion, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> comentario_usuario2, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.EventoEN> usuario_evento2, String contrasena, string email, string foto
                 )
{
        this.init (ID, nombre, seguidores, edad, sexo, facebook, instagram, historial, usuario_reto, usuario_usuario, usuario_usuario2, usuario_reporte2, usuario_puntuacion, comentario_usuario2, usuario_evento2, contrasena, email, foto);
}


public UsuarioEN(UsuarioEN usuario)
{
        this.init (ID, usuario.Nombre, usuario.Seguidores, usuario.Edad, usuario.Sexo, usuario.Facebook, usuario.Instagram, usuario.Historial, usuario.Usuario_reto, usuario.Usuario_usuario, usuario.Usuario_usuario2, usuario.Usuario_reporte2, usuario.Usuario_puntuacion, usuario.Comentario_usuario2, usuario.Usuario_evento2, usuario.Contrasena, usuario.Email, usuario.Foto);
}

private void init (int ID
                   , string nombre, int seguidores, int edad, string sexo, string facebook, string instagram, string historial, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.RetoEN> usuario_reto, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.UsuarioEN> usuario_usuario, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.UsuarioEN> usuario_usuario2, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> usuario_reporte2, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> usuario_puntuacion, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> comentario_usuario2, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.EventoEN> usuario_evento2, String contrasena, string email, string foto)
{
        this.ID = ID;


        this.Nombre = nombre;

        this.Seguidores = seguidores;

        this.Edad = edad;

        this.Sexo = sexo;

        this.Facebook = facebook;

        this.Instagram = instagram;

        this.Historial = historial;

        this.Usuario_reto = usuario_reto;

        this.Usuario_usuario = usuario_usuario;

        this.Usuario_usuario2 = usuario_usuario2;

        this.Usuario_reporte2 = usuario_reporte2;

        this.Usuario_puntuacion = usuario_puntuacion;

        this.Comentario_usuario2 = comentario_usuario2;

        this.Usuario_evento2 = usuario_evento2;

        this.Contrasena = contrasena;

        this.Email = email;

        this.Foto = foto;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        UsuarioEN t = obj as UsuarioEN;
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
