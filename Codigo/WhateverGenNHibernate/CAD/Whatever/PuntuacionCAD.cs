
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
 * Clase Puntuacion:
 *
 */

namespace WhateverGenNHibernate.CAD.Whatever
{
public partial class PuntuacionCAD : BasicCAD, IPuntuacionCAD
{
public PuntuacionCAD() : base ()
{
}

public PuntuacionCAD(ISession sessionAux) : base (sessionAux)
{
}



public PuntuacionEN ReadOIDDefault (int id
                                    )
{
        PuntuacionEN puntuacionEN = null;

        try
        {
                SessionInitializeTransaction ();
                puntuacionEN = (PuntuacionEN)session.Get (typeof(PuntuacionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return puntuacionEN;
}

public System.Collections.Generic.IList<PuntuacionEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PuntuacionEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PuntuacionEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<PuntuacionEN>();
                        else
                                result = session.CreateCriteria (typeof(PuntuacionEN)).List<PuntuacionEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PuntuacionEN puntuacion)
{
        try
        {
                SessionInitializeTransaction ();
                PuntuacionEN puntuacionEN = (PuntuacionEN)session.Load (typeof(PuntuacionEN), puntuacion.Id);




                puntuacionEN.Puntuacion = puntuacion.Puntuacion;

                session.Update (puntuacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (PuntuacionEN puntuacion)
{
        try
        {
                SessionInitializeTransaction ();
                if (puntuacion.Usuario_puntuacion2 != null) {
                        // Argumento OID y no colección.
                        puntuacion.Usuario_puntuacion2 = (WhateverGenNHibernate.EN.Whatever.UsuarioEN)session.Load (typeof(WhateverGenNHibernate.EN.Whatever.UsuarioEN), puntuacion.Usuario_puntuacion2.ID);

                        puntuacion.Usuario_puntuacion2.Usuario_puntuacion
                        .Add (puntuacion);
                }
                if (puntuacion.Reto_puntuacion != null) {
                        // Argumento OID y no colección.
                        puntuacion.Reto_puntuacion = (WhateverGenNHibernate.EN.Whatever.RetoEN)session.Load (typeof(WhateverGenNHibernate.EN.Whatever.RetoEN), puntuacion.Reto_puntuacion.ID);

                        puntuacion.Reto_puntuacion.Reto_puntuacion2
                        .Add (puntuacion);
                }
                if (puntuacion.Evento_puntuacion != null) {
                        // Argumento OID y no colección.
                        puntuacion.Evento_puntuacion = (WhateverGenNHibernate.EN.Whatever.EventoEN)session.Load (typeof(WhateverGenNHibernate.EN.Whatever.EventoEN), puntuacion.Evento_puntuacion.ID);

                        puntuacion.Evento_puntuacion.Puntuacion_evento2
                        .Add (puntuacion);
                }

                session.Save (puntuacion);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return puntuacion.Id;
}

public System.Collections.Generic.IList<PuntuacionEN> GetPuntuaciones (int first, int size)
{
        System.Collections.Generic.IList<PuntuacionEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(PuntuacionEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<PuntuacionEN>();
                else
                        result = session.CreateCriteria (typeof(PuntuacionEN)).List<PuntuacionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

//Sin e: GetID
//Con e: PuntuacionEN
public PuntuacionEN GetID (int id
                           )
{
        PuntuacionEN puntuacionEN = null;

        try
        {
                SessionInitializeTransaction ();
                puntuacionEN = (PuntuacionEN)session.Get (typeof(PuntuacionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return puntuacionEN;
}

public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> FiltrarReto (int? id_reto, int ? id_usuario)
{
        System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PuntuacionEN self where FROM PuntuacionEN,UsuarioEN as usu, RetoEN as re WHERE re.ID=:id_reto and usu.ID=:id_usuario";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PuntuacionENfiltrarRetoHQL");
                query.SetParameter ("id_reto", id_reto);
                query.SetParameter ("id_usuario", id_usuario);

                result = query.List<WhateverGenNHibernate.EN.Whatever.PuntuacionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> FiltrarEvento (int? id_evento, int ? id_usuario)
{
        System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PuntuacionEN self where FROM PuntuacionEN,UsuarioEN as usu, EventoEN as ev WHERE ev.ID=:id_evento and usu.ID=:id_usuario";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PuntuacionENfiltrarEventoHQL");
                query.SetParameter ("id_evento", id_evento);
                query.SetParameter ("id_usuario", id_usuario);

                result = query.List<WhateverGenNHibernate.EN.Whatever.PuntuacionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> FiltrarMediaEvento (int ? id_evento)
{
        System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PuntuacionEN self where FROM PuntuacionEN, EventoEN as ev WHERE ev.ID=:id_evento";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PuntuacionENfiltrarMediaEventoHQL");
                query.SetParameter ("id_evento", id_evento);

                result = query.List<WhateverGenNHibernate.EN.Whatever.PuntuacionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> FiltrarMediaReto (int ? id_reto)
{
        System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PuntuacionEN self where FROM PuntuacionEN, RetoEN as re WHERE re.ID=:id_reto";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PuntuacionENfiltrarMediaRetoHQL");
                query.SetParameter ("id_reto", id_reto);

                result = query.List<WhateverGenNHibernate.EN.Whatever.PuntuacionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public void Modify (PuntuacionEN puntuacion)
{
        try
        {
                SessionInitializeTransaction ();
                PuntuacionEN puntuacionEN = (PuntuacionEN)session.Load (typeof(PuntuacionEN), puntuacion.Id);

                puntuacionEN.Puntuacion = puntuacion.Puntuacion;

                session.Update (puntuacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int id
                     )
{
        try
        {
                SessionInitializeTransaction ();
                PuntuacionEN puntuacionEN = (PuntuacionEN)session.Load (typeof(PuntuacionEN), id);
                session.Delete (puntuacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> FiltrarTodosEventos (int ? id_evento)
{
        System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PuntuacionEN self where FROM PuntuacionEN, EventoEN as ev WHERE ev.ID=:id_evento";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PuntuacionENfiltrarTodosEventosHQL");
                query.SetParameter ("id_evento", id_evento);

                result = query.List<WhateverGenNHibernate.EN.Whatever.PuntuacionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> FiltrarTodosRetos (int ? id_reto)
{
        System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PuntuacionEN self where FROM PuntuacionEN, RetoEN as re WHERE re.ID=:id_reto ";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PuntuacionENfiltrarTodosRetosHQL");
                query.SetParameter ("id_reto", id_reto);

                result = query.List<WhateverGenNHibernate.EN.Whatever.PuntuacionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> FiltrarPorUsuario (int ? id_usuario)
{
        System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PuntuacionEN self where FROM PuntuacionEN, UsuarioEN as us WHERE us.ID=:id_usuario";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PuntuacionENfiltrarPorUsuarioHQL");
                query.SetParameter ("id_usuario", id_usuario);

                result = query.List<WhateverGenNHibernate.EN.Whatever.PuntuacionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
