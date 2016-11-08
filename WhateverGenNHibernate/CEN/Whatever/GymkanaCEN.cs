

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
 *      Definition of the class GymkanaCEN
 *
 */
public partial class GymkanaCEN
{
private IGymkanaCAD _IGymkanaCAD;

public GymkanaCEN()
{
        this._IGymkanaCAD = new GymkanaCAD ();
}

public GymkanaCEN(IGymkanaCAD _IGymkanaCAD)
{
        this._IGymkanaCAD = _IGymkanaCAD;
}

public IGymkanaCAD get_IGymkanaCAD ()
{
        return this._IGymkanaCAD;
}

public int New_ (string p_Titulo, string p_descripcion, Nullable<DateTime> p_fecha, int p_precio, string p_creador, int p_ID, int p_usuario_evento, int p_numPasos)
{
        GymkanaEN gymkanaEN = null;
        int oid;

        //Initialized GymkanaEN
        gymkanaEN = new GymkanaEN ();
        gymkanaEN.Titulo = p_Titulo;

        gymkanaEN.Descripcion = p_descripcion;

        gymkanaEN.Fecha = p_fecha;

        gymkanaEN.Precio = p_precio;

        gymkanaEN.Creador = p_creador;

        gymkanaEN.ID = p_ID;


        if (p_usuario_evento != -1) {
                // El argumento p_usuario_evento -> Property usuario_evento es oid = false
                // Lista de oids ID
                gymkanaEN.Usuario_evento = new WhateverGenNHibernate.EN.Whatever.UsuarioEN ();
                gymkanaEN.Usuario_evento.ID = p_usuario_evento;
        }

        gymkanaEN.NumPasos = p_numPasos;

        //Call to GymkanaCAD

        oid = _IGymkanaCAD.New_ (gymkanaEN);
        return oid;
}
}
}
