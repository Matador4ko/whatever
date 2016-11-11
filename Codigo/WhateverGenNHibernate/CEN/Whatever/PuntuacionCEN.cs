

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.Exceptions;

using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;


namespace WhateverGenNHibernate.CEN.Whatever
{
/*
 *      Definition of the class PuntuacionCEN
 *
 */
public partial class PuntuacionCEN
{
private IPuntuacionCAD _IPuntuacionCAD;

public PuntuacionCEN()
{
        this._IPuntuacionCAD = new PuntuacionCAD ();
}

public PuntuacionCEN(IPuntuacionCAD _IPuntuacionCAD)
{
        this._IPuntuacionCAD = _IPuntuacionCAD;
}

public IPuntuacionCAD get_IPuntuacionCAD ()
{
        return this._IPuntuacionCAD;
}

public int New_ (int p_usuario_puntuacion2, int p_reto_puntuacion, int p_evento_puntuacion, int p_puntuacion)
{
        PuntuacionEN puntuacionEN = null;
        int oid;

        //Initialized PuntuacionEN
        puntuacionEN = new PuntuacionEN ();

        if (p_usuario_puntuacion2 != -1) {
                // El argumento p_usuario_puntuacion2 -> Property usuario_puntuacion2 es oid = false
                // Lista de oids id
                puntuacionEN.Usuario_puntuacion2 = new WhateverGenNHibernate.EN.Whatever.UsuarioEN ();
                puntuacionEN.Usuario_puntuacion2.ID = p_usuario_puntuacion2;
        }


        if (p_reto_puntuacion != -1) {
                // El argumento p_reto_puntuacion -> Property reto_puntuacion es oid = false
                // Lista de oids id
                puntuacionEN.Reto_puntuacion = new WhateverGenNHibernate.EN.Whatever.RetoEN ();
                puntuacionEN.Reto_puntuacion.ID = p_reto_puntuacion;
        }


        if (p_evento_puntuacion != -1) {
                // El argumento p_evento_puntuacion -> Property evento_puntuacion es oid = false
                // Lista de oids id
                puntuacionEN.Evento_puntuacion = new WhateverGenNHibernate.EN.Whatever.EventoEN ();
                puntuacionEN.Evento_puntuacion.ID = p_evento_puntuacion;
        }

        puntuacionEN.Puntuacion = p_puntuacion;

        //Call to PuntuacionCAD

        oid = _IPuntuacionCAD.New_ (puntuacionEN);
        return oid;
}

public System.Collections.Generic.IList<PuntuacionEN> GetPuntuaciones (int first, int size)
{
        System.Collections.Generic.IList<PuntuacionEN> list = null;

        list = _IPuntuacionCAD.GetPuntuaciones (first, size);
        return list;
}
public PuntuacionEN GetID (int id
                           )
{
        PuntuacionEN puntuacionEN = null;

        puntuacionEN = _IPuntuacionCAD.GetID (id);
        return puntuacionEN;
}

public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> FiltrarReto (int? id_reto, int ? id_usuario)
{
        return _IPuntuacionCAD.FiltrarReto (id_reto, id_usuario);
}
public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> FiltrarEvento (int? id_evento, int ? id_usuario)
{
        return _IPuntuacionCAD.FiltrarEvento (id_evento, id_usuario);
}
public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> FiltrarMediaEvento (int ? id_evento)
{
        return _IPuntuacionCAD.FiltrarMediaEvento (id_evento);
}
public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> FiltrarMediaReto (int ? id_reto)
{
        return _IPuntuacionCAD.FiltrarMediaReto (id_reto);
}
}
}
