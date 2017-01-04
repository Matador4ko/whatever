
using System;
// Definición clase AdminEN
namespace WhateverGenNHibernate.EN.Whatever
{
public partial class AdminEN                                                                        : WhateverGenNHibernate.EN.Whatever.UsuarioEN


{
public AdminEN() : base ()
{
}



public AdminEN(int iD,
               string nombre, int edad, string sexo, string facebook, string instagram, string twitter, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.RetoEN> reto, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> reporte, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> puntuacion, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> comentario, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.EventoEN> evento, String contrasena, string email, string foto, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.GymkanaEN> gymkana
               )
{
        this.init (ID, nombre, edad, sexo, facebook, instagram, twitter, reto, reporte, puntuacion, comentario, evento, contrasena, email, foto, gymkana);
}


public AdminEN(AdminEN admin)
{
        this.init (ID, admin.Nombre, admin.Edad, admin.Sexo, admin.Facebook, admin.Instagram, admin.Twitter, admin.Reto, admin.Reporte, admin.Puntuacion, admin.Comentario, admin.Evento, admin.Contrasena, admin.Email, admin.Foto, admin.Gymkana);
}

private void init (int ID
                   , string nombre, int edad, string sexo, string facebook, string instagram, string twitter, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.RetoEN> reto, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> reporte, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> puntuacion, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> comentario, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.EventoEN> evento, String contrasena, string email, string foto, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.GymkanaEN> gymkana)
{
        this.ID = ID;


        this.Nombre = nombre;

        this.Edad = edad;

        this.Sexo = sexo;

        this.Facebook = facebook;

        this.Instagram = instagram;

        this.Twitter = twitter;

        this.Reto = reto;

        this.Reporte = reporte;

        this.Puntuacion = puntuacion;

        this.Comentario = comentario;

        this.Evento = evento;

        this.Contrasena = contrasena;

        this.Email = email;

        this.Foto = foto;

        this.Gymkana = gymkana;
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
