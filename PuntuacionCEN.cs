

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

public int New_ (int p_usuario_puntuacion2, int p_reto_puntuacion, int p_evento_puntuacion, int p_id)
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

        puntuacionEN.Id = p_id;

        //Call to PuntuacionCAD

        oid = _IPuntuacionCAD.New_ (puntuacionEN);
        return oid;
}
}
}
