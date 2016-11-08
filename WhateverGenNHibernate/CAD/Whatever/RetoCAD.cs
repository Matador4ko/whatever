
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
 * Clase Reto:
 *
 */

namespace WhateverGenNHibernate.CAD.Whatever
{
public partial class RetoCAD : BasicCAD, IRetoCAD
{
public RetoCAD() : base ()
{
}

public RetoCAD(ISession sessionAux) : base (sessionAux)
{
}



public RetoEN ReadOIDDefault (int ID
                              )
{
        RetoEN retoEN = null;

        try
        {
                SessionInitializeTransaction ();
                retoEN = (RetoEN)session.Get (typeof(RetoEN), ID);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in RetoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return retoEN;
}

public System.Collections.Generic.IList<RetoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<RetoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(RetoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<RetoEN>();
                        else
                                result = session.CreateCriteria (typeof(RetoEN)).List<RetoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in RetoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (RetoEN reto)
{
        try
        {
                SessionInitializeTransaction ();
                RetoEN retoEN = (RetoEN)session.Load (typeof(RetoEN), reto.ID);

                retoEN.Titulo = reto.Titulo;


                retoEN.Descripcion = reto.Descripcion;


                retoEN.Tipo = reto.Tipo;


                retoEN.Precio = reto.Precio;


                retoEN.Imagen = reto.Imagen;


                retoEN.Creador = reto.Creador;



                retoEN.Id_mapa = reto.Id_mapa;





                session.Update (retoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in RetoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (RetoEN reto)
{
        try
        {
                SessionInitializeTransaction ();
                if (reto.Usuario_reto2 != null) {
                        // Argumento OID y no colección.
                        reto.Usuario_reto2 = (WhateverGenNHibernate.EN.Whatever.UsuarioEN)session.Load (typeof(WhateverGenNHibernate.EN.Whatever.UsuarioEN), reto.Usuario_reto2.ID);

                        reto.Usuario_reto2.Usuario_reto
                        .Add (reto);
                }

                session.Save (reto);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in RetoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return reto.ID;
}

public void Modify (RetoEN reto)
{
        try
        {
                SessionInitializeTransaction ();
                RetoEN retoEN = (RetoEN)session.Load (typeof(RetoEN), reto.ID);

                retoEN.Titulo = reto.Titulo;


                retoEN.Descripcion = reto.Descripcion;


                retoEN.Tipo = reto.Tipo;


                retoEN.Precio = reto.Precio;


                retoEN.Imagen = reto.Imagen;


                retoEN.Creador = reto.Creador;

                session.Update (retoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in RetoCAD.", ex);
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
                RetoEN retoEN = (RetoEN)session.Load (typeof(RetoEN), ID);
                session.Delete (retoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in RetoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<RetoEN> GetAll (int first, int size)
{
        System.Collections.Generic.IList<RetoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(RetoEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<RetoEN>();
                else
                        result = session.CreateCriteria (typeof(RetoEN)).List<RetoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in RetoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

//Sin e: GetID
//Con e: RetoEN
public RetoEN GetID (int ID
                     )
{
        RetoEN retoEN = null;

        try
        {
                SessionInitializeTransaction ();
                retoEN = (RetoEN)session.Get (typeof(RetoEN), ID);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in RetoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return retoEN;
}
}
}
