
using System;
// Definición clase AdminEN
namespace WhateverGenNHibernate.EN.Whatever
{
public partial class AdminEN                                                                        : WhateverGenNHibernate.EN.Whatever.UsuarioEN


{
/**
 *	Atributo admin_reporte2
 */
private System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> admin_reporte2;






public virtual System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> Admin_reporte2 {
        get { return admin_reporte2; } set { admin_reporte2 = value;  }
}





public AdminEN() : base ()
{
        admin_reporte2 = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.ReporteEN>();
}



public AdminEN(int iD, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> admin_reporte2
               , string nombre, int edad, string sexo, string facebook, string instagram, string twitter, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.RetoEN> usuario_reto, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> usuario_reporte2, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> usuario_puntuacion, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> comentario_usuario2, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.EventoEN> usuario_evento2, String contrasena, string email, string foto
               )
{
        this.init (ID, admin_reporte2, nombre, edad, sexo, facebook, instagram, twitter, usuario_reto, usuario_reporte2, usuario_puntuacion, comentario_usuario2, usuario_evento2, contrasena, email, foto);
}


public AdminEN(AdminEN admin)
{
        this.init (ID, admin.Admin_reporte2, admin.Nombre, admin.Edad, admin.Sexo, admin.Facebook, admin.Instagram, admin.Twitter, admin.Usuario_reto, admin.Usuario_reporte2, admin.Usuario_puntuacion, admin.Comentario_usuario2, admin.Usuario_evento2, admin.Contrasena, admin.Email, admin.Foto);
}

private void init (int ID
                   , System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> admin_reporte2, string nombre, int edad, string sexo, string facebook, string instagram, string twitter, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.RetoEN> usuario_reto, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> usuario_reporte2, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> usuario_puntuacion, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> comentario_usuario2, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.EventoEN> usuario_evento2, String contrasena, string email, string foto)
{
        this.ID = ID;


        this.Admin_reporte2 = admin_reporte2;

        this.Nombre = nombre;

        this.Edad = edad;

        this.Sexo = sexo;

        this.Facebook = facebook;

        this.Instagram = instagram;

        this.Twitter = twitter;

        this.Usuario_reto = usuario_reto;

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
        AdminEN t = obj as AdminEN;
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
