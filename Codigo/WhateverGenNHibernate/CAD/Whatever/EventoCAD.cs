
using System;
using System.Text;
using WhateverGenNHibernate.CEN.Whatever;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.Exceptions;


/*
 * Clase Evento:
 *
 */

namespace WhateverGenNHibernate.CAD.Whatever
{
public partial class EventoCAD : BasicCAD, IEventoCAD
{
public EventoCAD() : base ()
{
}

public EventoCAD(ISession sessionAux) : base (sessionAux)
{
}



public EventoEN ReadOIDDefault (int ID
                                )
{
        EventoEN eventoEN = null;

        try
        {
                SessionInitializeTransaction ();
                eventoEN = (EventoEN)session.Get (typeof(EventoEN), ID);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in EventoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return eventoEN;
}

public System.Collections.Generic.IList<EventoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<EventoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(EventoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<EventoEN>();
                        else
                                result = session.CreateCriteria (typeof(EventoEN)).List<EventoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in EventoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (EventoEN evento)
{
        try
        {
                SessionInitializeTransaction ();
                EventoEN eventoEN = (EventoEN)session.Load (typeof(EventoEN), evento.ID);

                eventoEN.Titulo = evento.Titulo;


                eventoEN.Descripcion = evento.Descripcion;


                eventoEN.Fecha = evento.Fecha;


                eventoEN.Precio = evento.Precio;






                session.Update (eventoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in EventoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (EventoEN evento)
{
        try
        {
                SessionInitializeTransaction ();
                if (evento.Usuario_evento != null) {
                        // Argumento OID y no colección.
                        evento.Usuario_evento = (WhateverGenNHibernate.EN.Whatever.UsuarioEN)session.Load (typeof(WhateverGenNHibernate.EN.Whatever.UsuarioEN), evento.Usuario_evento.ID);

                        evento.Usuario_evento.Usuario_evento2
                        .Add (evento);
                }

                session.Save (evento);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in EventoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return evento.ID;
}

public void Modify (EventoEN evento)
{
        try
        {
                SessionInitializeTransaction ();
                EventoEN eventoEN = (EventoEN)session.Load (typeof(EventoEN), evento.ID);

                eventoEN.Titulo = evento.Titulo;


                eventoEN.Descripcion = evento.Descripcion;


                eventoEN.Fecha = evento.Fecha;


                eventoEN.Precio = evento.Precio;

                session.Update (eventoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in EventoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int ID
                     )
{
        try
        {
                SessionInitializeTransaction ();
                EventoEN eventoEN = (EventoEN)session.Load (typeof(EventoEN), ID);
                session.Delete (eventoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in EventoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<EventoEN> GetAll (int first, int size)
{
        System.Collections.Generic.IList<EventoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(EventoEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<EventoEN>();
                else
                        result = session.CreateCriteria (typeof(EventoEN)).List<EventoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in EventoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

//Sin e: GetID
//Con e: EventoEN
public EventoEN GetID (int ID
                       )
{
        EventoEN eventoEN = null;

        try
        {
                SessionInitializeTransaction ();
                eventoEN = (EventoEN)session.Get (typeof(EventoEN), ID);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in EventoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return eventoEN;
}

public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.EventoEN> FiltrarPorUsuario (int ? id_usu)
{
        System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.EventoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM EventoEN self where FROM EventoEN as ev, UsuarioEN as us WHERE us.ID=:id_usu";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("EventoENfiltrarPorUsuarioHQL");
                query.SetParameter ("id_usu", id_usu);

                result = query.List<WhateverGenNHibernate.EN.Whatever.EventoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in EventoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public void AnadirMapa (int p_Evento_OID, System.Collections.Generic.IList<int> p_evento_mapa_OIDs)
{
        WhateverGenNHibernate.EN.Whatever.EventoEN eventoEN = null;
        try
        {
                SessionInitializeTransaction ();
                eventoEN = (EventoEN)session.Load (typeof(EventoEN), p_Evento_OID);
                WhateverGenNHibernate.EN.Whatever.MapaEN evento_mapaENAux = null;
                if (eventoEN.Evento_mapa == null) {
                        eventoEN.Evento_mapa = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.MapaEN>();
                }

                foreach (int item in p_evento_mapa_OIDs) {
                        evento_mapaENAux = new WhateverGenNHibernate.EN.Whatever.MapaEN ();
                        evento_mapaENAux = (WhateverGenNHibernate.EN.Whatever.MapaEN)session.Load (typeof(WhateverGenNHibernate.EN.Whatever.MapaEN), item);
                        evento_mapaENAux.Evento_mapa2 = eventoEN;

                        eventoEN.Evento_mapa.Add (evento_mapaENAux);
                }


                session.Update (eventoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in EventoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void EliminarMapa (int p_Evento_OID, System.Collections.Generic.IList<int> p_evento_mapa_OIDs)
{
        try
        {
                SessionInitializeTransaction ();
                WhateverGenNHibernate.EN.Whatever.EventoEN eventoEN = null;
                eventoEN = (EventoEN)session.Load (typeof(EventoEN), p_Evento_OID);

                WhateverGenNHibernate.EN.Whatever.MapaEN evento_mapaENAux = null;
                if (eventoEN.Evento_mapa != null) {
                        foreach (int item in p_evento_mapa_OIDs) {
                                evento_mapaENAux = (WhateverGenNHibernate.EN.Whatever.MapaEN)session.Load (typeof(WhateverGenNHibernate.EN.Whatever.MapaEN), item);
                                if (eventoEN.Evento_mapa.Contains (evento_mapaENAux) == true) {
                                        eventoEN.Evento_mapa.Remove (evento_mapaENAux);
                                        evento_mapaENAux.Evento_mapa2 = null;
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_evento_mapa_OIDs you are trying to unrelationer, doesn't exist in EventoEN");
                        }
                }

                session.Update (eventoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in EventoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
