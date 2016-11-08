

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
 *      Definition of the class EventoCEN
 *
 */
public partial class EventoCEN
{
private IEventoCAD _IEventoCAD;

public EventoCEN()
{
        this._IEventoCAD = new EventoCAD ();
}

public EventoCEN(IEventoCAD _IEventoCAD)
{
        this._IEventoCAD = _IEventoCAD;
}

public IEventoCAD get_IEventoCAD ()
{
        return this._IEventoCAD;
}

public int New_ (string p_Titulo, string p_descripcion, Nullable<DateTime> p_fecha, int p_precio, string p_creador, int p_ID, int p_usuario_evento)
{
        EventoEN eventoEN = null;
        int oid;

        //Initialized EventoEN
        eventoEN = new EventoEN ();
        eventoEN.Titulo = p_Titulo;

        eventoEN.Descripcion = p_descripcion;

        eventoEN.Fecha = p_fecha;

        eventoEN.Precio = p_precio;

        eventoEN.Creador = p_creador;

        eventoEN.ID = p_ID;


        if (p_usuario_evento != -1) {
                // El argumento p_usuario_evento -> Property usuario_evento es oid = false
                // Lista de oids ID
                eventoEN.Usuario_evento = new WhateverGenNHibernate.EN.Whatever.UsuarioEN ();
                eventoEN.Usuario_evento.ID = p_usuario_evento;
        }

        //Call to EventoCAD

        oid = _IEventoCAD.New_ (eventoEN);
        return oid;
}

public void Modify (int p_Evento_OID, string p_Titulo, string p_descripcion, Nullable<DateTime> p_fecha, int p_precio, string p_creador)
{
        EventoEN eventoEN = null;

        //Initialized EventoEN
        eventoEN = new EventoEN ();
        eventoEN.ID = p_Evento_OID;
        eventoEN.Titulo = p_Titulo;
        eventoEN.Descripcion = p_descripcion;
        eventoEN.Fecha = p_fecha;
        eventoEN.Precio = p_precio;
        eventoEN.Creador = p_creador;
        //Call to EventoCAD

        _IEventoCAD.Modify (eventoEN);
}

public void Destroy (int ID
                     )
{
        _IEventoCAD.Destroy (ID);
}

public System.Collections.Generic.IList<EventoEN> GetAll (int first, int size)
{
        System.Collections.Generic.IList<EventoEN> list = null;

        list = _IEventoCAD.GetAll (first, size);
        return list;
}
public EventoEN GetID (int ID
                       )
{
        EventoEN eventoEN = null;

        eventoEN = _IEventoCAD.GetID (ID);
        return eventoEN;
}
}
}
