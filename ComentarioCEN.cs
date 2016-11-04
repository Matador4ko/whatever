

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
 *      Definition of the class ComentarioCEN
 *
 */
public partial class ComentarioCEN
{
private IComentarioCAD _IComentarioCAD;

public ComentarioCEN()
{
        this._IComentarioCAD = new ComentarioCAD ();
}

public ComentarioCEN(IComentarioCAD _IComentarioCAD)
{
        this._IComentarioCAD = _IComentarioCAD;
}

public IComentarioCAD get_IComentarioCAD ()
{
        return this._IComentarioCAD;
}

public int New_ (string p_texto, string p_creador, int p_ID, int p_comentario_usuario, int p_comentario_reto, int p_comentario_evento2)
{
        ComentarioEN comentarioEN = null;
        int oid;

        //Initialized ComentarioEN
        comentarioEN = new ComentarioEN ();
        comentarioEN.Texto = p_texto;

        comentarioEN.Creador = p_creador;

        comentarioEN.ID = p_ID;


        if (p_comentario_usuario != -1) {
                // El argumento p_comentario_usuario -> Property comentario_usuario es oid = false
                // Lista de oids ID
                comentarioEN.Comentario_usuario = new WhateverGenNHibernate.EN.Whatever.UsuarioEN ();
                comentarioEN.Comentario_usuario.ID = p_comentario_usuario;
        }


        if (p_comentario_reto != -1) {
                // El argumento p_comentario_reto -> Property comentario_reto es oid = false
                // Lista de oids ID
                comentarioEN.Comentario_reto = new WhateverGenNHibernate.EN.Whatever.RetoEN ();
                comentarioEN.Comentario_reto.ID = p_comentario_reto;
        }


        if (p_comentario_evento2 != -1) {
                // El argumento p_comentario_evento2 -> Property comentario_evento2 es oid = false
                // Lista de oids ID
                comentarioEN.Comentario_evento2 = new WhateverGenNHibernate.EN.Whatever.EventoEN ();
                comentarioEN.Comentario_evento2.ID = p_comentario_evento2;
        }

        //Call to ComentarioCAD

        oid = _IComentarioCAD.New_ (comentarioEN);
        return oid;
}

public void Destroy (int ID
                     )
{
        _IComentarioCAD.Destroy (ID);
}
}
}
