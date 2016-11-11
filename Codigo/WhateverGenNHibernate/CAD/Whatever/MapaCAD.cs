
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
 * Clase Mapa:
 *
 */

namespace WhateverGenNHibernate.CAD.Whatever
{
public partial class MapaCAD : BasicCAD, IMapaCAD
{
public MapaCAD() : base ()
{
}

public MapaCAD(ISession sessionAux) : base (sessionAux)
{
}



public MapaEN ReadOIDDefault (int id
                              )
{
        MapaEN mapaEN = null;

        try
        {
                SessionInitializeTransaction ();
                mapaEN = (MapaEN)session.Get (typeof(MapaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in MapaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return mapaEN;
}

public System.Collections.Generic.IList<MapaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<MapaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(MapaEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<MapaEN>();
                        else
                                result = session.CreateCriteria (typeof(MapaEN)).List<MapaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in MapaCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (MapaEN mapa)
{
        try
        {
                SessionInitializeTransaction ();
                MapaEN mapaEN = (MapaEN)session.Load (typeof(MapaEN), mapa.Id);



                mapaEN.Latitud = mapa.Latitud;


                mapaEN.Longitud = mapa.Longitud;


                mapaEN.Zoom = mapa.Zoom;

                session.Update (mapaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in MapaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (MapaEN mapa)
{
        try
        {
                SessionInitializeTransaction ();
                if (mapa.Evento_mapa2 != null) {
                        // Argumento OID y no colección.
                        mapa.Evento_mapa2 = (WhateverGenNHibernate.EN.Whatever.EventoEN)session.Load (typeof(WhateverGenNHibernate.EN.Whatever.EventoEN), mapa.Evento_mapa2.ID);

                        mapa.Evento_mapa2.Evento_mapa
                        .Add (mapa);
                }
                if (mapa.Paso_0 != null) {
                        // Argumento OID y no colección.
                        mapa.Paso_0 = (WhateverGenNHibernate.EN.Whatever.PasoEN)session.Load (typeof(WhateverGenNHibernate.EN.Whatever.PasoEN), mapa.Paso_0.ID);

                        mapa.Paso_0.Paso
                                = mapa;
                }

                session.Save (mapa);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in MapaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return mapa.Id;
}

public System.Collections.Generic.IList<MapaEN> GetAll (int first, int size)
{
        System.Collections.Generic.IList<MapaEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(MapaEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<MapaEN>();
                else
                        result = session.CreateCriteria (typeof(MapaEN)).List<MapaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in MapaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

//Sin e: GetID
//Con e: MapaEN
public MapaEN GetID (int id
                     )
{
        MapaEN mapaEN = null;

        try
        {
                SessionInitializeTransaction ();
                mapaEN = (MapaEN)session.Get (typeof(MapaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in MapaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return mapaEN;
}

public void Modify (MapaEN mapa)
{
        try
        {
                SessionInitializeTransaction ();
                MapaEN mapaEN = (MapaEN)session.Load (typeof(MapaEN), mapa.Id);

                mapaEN.Latitud = mapa.Latitud;


                mapaEN.Longitud = mapa.Longitud;


                mapaEN.Zoom = mapa.Zoom;

                session.Update (mapaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in MapaCAD.", ex);
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
                MapaEN mapaEN = (MapaEN)session.Load (typeof(MapaEN), id);
                session.Delete (mapaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in MapaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.MapaEN> FiltrarEventos ()
{
        System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.MapaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM MapaEN self where FROM MapaEN, Evento as ev WHERE ev.ID != -1";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("MapaENfiltrarEventosHQL");

                result = query.List<WhateverGenNHibernate.EN.Whatever.MapaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in MapaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.MapaEN> FiltrarPorEvento (int ? id_evento)
{
        System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.MapaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM MapaEN self where FROM MapaEN, EventoEN as ev WHERE ev.ID=:id_evento";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("MapaENFiltrarPorEventoHQL");
                query.SetParameter ("id_evento", id_evento);

                result = query.List<WhateverGenNHibernate.EN.Whatever.MapaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in MapaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.MapaEN> FiltrarPorPaso (int ? id_paso)
{
        System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.MapaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM MapaEN self where FROM MapaEN, PasoEN as pa WHERE pa.ID=:id_paso";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("MapaENFiltrarPorPasoHQL");
                query.SetParameter ("id_paso", id_paso);

                result = query.List<WhateverGenNHibernate.EN.Whatever.MapaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in MapaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
