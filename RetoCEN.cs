

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
 *      Definition of the class RetoCEN
 *
 */
public partial class RetoCEN
{
private IRetoCAD _IRetoCAD;

public RetoCEN()
{
        this._IRetoCAD = new RetoCAD ();
}

public RetoCEN(IRetoCAD _IRetoCAD)
{
        this._IRetoCAD = _IRetoCAD;
}

public IRetoCAD get_IRetoCAD ()
{
        return this._IRetoCAD;
}

public RetoEN ReadOID (int ID
                       )
{
        RetoEN retoEN = null;

        retoEN = _IRetoCAD.ReadOID (ID);
        return retoEN;
}

public System.Collections.Generic.IList<RetoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<RetoEN> list = null;

        list = _IRetoCAD.ReadAll (first, size);
        return list;
}
public int CrearReto (string p_titulo, string p_descripcion, string p_tipo, string p_imagen, int p_precio, string p_creador, int p_ID, int p_usuario_reto2)
{
        RetoEN retoEN = null;
        int oid;

        //Initialized RetoEN
        retoEN = new RetoEN ();
        retoEN.Titulo = p_titulo;

        retoEN.Descripcion = p_descripcion;

        retoEN.Tipo = p_tipo;

        retoEN.Precio = p_precio;

        retoEN.Imagen = p_imagen;

        retoEN.Creador = p_creador;

        retoEN.ID = p_ID;


        if (p_usuario_reto2 != -1) {
                // El argumento p_usuario_reto2 -> Property usuario_reto2 es oid = false
                // Lista de oids ID
                retoEN.Usuario_reto2 = new WhateverGenNHibernate.EN.Whatever.UsuarioEN ();
                retoEN.Usuario_reto2.ID = p_usuario_reto2;
        }

        //Call to RetoCAD

        oid = _IRetoCAD.CrearReto (retoEN);
        return oid;
}
}
}
