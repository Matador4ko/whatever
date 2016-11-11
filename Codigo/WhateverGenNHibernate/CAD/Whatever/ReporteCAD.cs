
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
 * Clase Reporte:
 *
 */

namespace WhateverGenNHibernate.CAD.Whatever
{
public partial class ReporteCAD : BasicCAD, IReporteCAD
{
public ReporteCAD() : base ()
{
}

public ReporteCAD(ISession sessionAux) : base (sessionAux)
{
}



public ReporteEN ReadOIDDefault (int ID
                                 )
{
        ReporteEN reporteEN = null;

        try
        {
                SessionInitializeTransaction ();
                reporteEN = (ReporteEN)session.Get (typeof(ReporteEN), ID);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return reporteEN;
}

public System.Collections.Generic.IList<ReporteEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ReporteEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ReporteEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ReporteEN>();
                        else
                                result = session.CreateCriteria (typeof(ReporteEN)).List<ReporteEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ReporteEN reporte)
{
        try
        {
                SessionInitializeTransaction ();
                ReporteEN reporteEN = (ReporteEN)session.Load (typeof(ReporteEN), reporte.ID);

                reporteEN.Motivo = reporte.Motivo;





                session.Update (reporteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (ReporteEN reporte)
{
        try
        {
                SessionInitializeTransaction ();
                if (reporte.Usuario_reporte != null) {
                        // Argumento OID y no colección.
                        reporte.Usuario_reporte = (WhateverGenNHibernate.EN.Whatever.UsuarioEN)session.Load (typeof(WhateverGenNHibernate.EN.Whatever.UsuarioEN), reporte.Usuario_reporte.ID);

                        reporte.Usuario_reporte.Usuario_reporte2
                        .Add (reporte);
                }
                if (reporte.Admin_reporte != null) {
                        for (int i = 0; i < reporte.Admin_reporte.Count; i++) {
                                reporte.Admin_reporte [i] = (WhateverGenNHibernate.EN.Whatever.AdminEN)session.Load (typeof(WhateverGenNHibernate.EN.Whatever.AdminEN), reporte.Admin_reporte [i].ID);
                                reporte.Admin_reporte [i].Admin_reporte2.Add (reporte);
                        }
                }
                if (reporte.Reporte_reto2 != null) {
                        // Argumento OID y no colección.
                        reporte.Reporte_reto2 = (WhateverGenNHibernate.EN.Whatever.RetoEN)session.Load (typeof(WhateverGenNHibernate.EN.Whatever.RetoEN), reporte.Reporte_reto2.ID);

                        reporte.Reporte_reto2.Reporte
                        .Add (reporte);
                }
                if (reporte.Reporte != null) {
                        // Argumento OID y no colección.
                        reporte.Reporte = (WhateverGenNHibernate.EN.Whatever.EventoEN)session.Load (typeof(WhateverGenNHibernate.EN.Whatever.EventoEN), reporte.Reporte.ID);

                        reporte.Reporte.Reporte_evento2
                        .Add (reporte);
                }

                session.Save (reporte);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return reporte.ID;
}

public void Destroy (int ID
                     )
{
        try
        {
                SessionInitializeTransaction ();
                ReporteEN reporteEN = (ReporteEN)session.Load (typeof(ReporteEN), ID);
                session.Delete (reporteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<ReporteEN> GetAll (int first, int size)
{
        System.Collections.Generic.IList<ReporteEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ReporteEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ReporteEN>();
                else
                        result = session.CreateCriteria (typeof(ReporteEN)).List<ReporteEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

//Sin e: GetID
//Con e: ReporteEN
public ReporteEN GetID (int ID
                        )
{
        ReporteEN reporteEN = null;

        try
        {
                SessionInitializeTransaction ();
                reporteEN = (ReporteEN)session.Get (typeof(ReporteEN), ID);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return reporteEN;
}

public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> FiltrarEvento (int? id_evento, int ? id_usuario)
{
        System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReporteEN self where FROM ReporteEN,UsuarioEN as usu, EventoEN as ev WHERE ev.ID=:id_evento and usu.ID=:id_usuario";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReporteENfiltrarEventoHQL");
                query.SetParameter ("id_evento", id_evento);
                query.SetParameter ("id_usuario", id_usuario);

                result = query.List<WhateverGenNHibernate.EN.Whatever.ReporteEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> FiltrarReto (int? id_reto, int ? id_usuario)
{
        System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReporteEN self where FROM ReporteEN,UsuarioEN as usu, RetoEN as re WHERE re.ID=:id_reto and usu.ID=:id_usuario";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReporteENfiltrarRetoHQL");
                query.SetParameter ("id_reto", id_reto);
                query.SetParameter ("id_usuario", id_usuario);

                result = query.List<WhateverGenNHibernate.EN.Whatever.ReporteEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> FiltrarTodosEventos (int ? id_evento)
{
        System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReporteEN self where FROM ReporteEN, EventoEN as ev WHERE ev.ID=:id_evento";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReporteENfiltrarTodosEventosHQL");
                query.SetParameter ("id_evento", id_evento);

                result = query.List<WhateverGenNHibernate.EN.Whatever.ReporteEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> FiltrarTodosRetos (int ? id_reto)
{
        System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReporteEN self where FROM ReporteEN, RetoEN as re WHERE re.ID=:id_reto";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReporteENfiltrarTodosRetosHQL");
                query.SetParameter ("id_reto", id_reto);

                result = query.List<WhateverGenNHibernate.EN.Whatever.ReporteEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> FiltrarPorUsuario (int ? id_usuario)
{
        System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReporteEN self where FROM ReporteEN, UsuarioEN as us WHERE us.ID=:id_usuario";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReporteENfiltrarPorUsuarioHQL");
                query.SetParameter ("id_usuario", id_usuario);

                result = query.List<WhateverGenNHibernate.EN.Whatever.ReporteEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
