
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
 * Clase Gymkana:
 *
 */

namespace WhateverGenNHibernate.CAD.Whatever
{
public partial class GymkanaCAD : BasicCAD, IGymkanaCAD
{
public GymkanaCAD() : base ()
{
}

public GymkanaCAD(ISession sessionAux) : base (sessionAux)
{
}



public GymkanaEN ReadOIDDefault (int ID
                                 )
{
        GymkanaEN gymkanaEN = null;

        try
        {
                SessionInitializeTransaction ();
                gymkanaEN = (GymkanaEN)session.Get (typeof(GymkanaEN), ID);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in GymkanaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return gymkanaEN;
}

public System.Collections.Generic.IList<GymkanaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<GymkanaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(GymkanaEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<GymkanaEN>();
                        else
                                result = session.CreateCriteria (typeof(GymkanaEN)).List<GymkanaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in GymkanaCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (GymkanaEN gymkana)
{
        try
        {
                SessionInitializeTransaction ();
                GymkanaEN gymkanaEN = (GymkanaEN)session.Load (typeof(GymkanaEN), gymkana.ID);

                gymkanaEN.NumPasos = gymkana.NumPasos;


                session.Update (gymkanaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in GymkanaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (GymkanaEN gymkana)
{
        try
        {
                SessionInitializeTransaction ();
                if (gymkana.Usuario_evento != null) {
                        // Argumento OID y no colección.
                        gymkana.Usuario_evento = (WhateverGenNHibernate.EN.Whatever.UsuarioEN)session.Load (typeof(WhateverGenNHibernate.EN.Whatever.UsuarioEN), gymkana.Usuario_evento.ID);

                        gymkana.Usuario_evento.Usuario_evento2
                        .Add (gymkana);
                }

                session.Save (gymkana);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in GymkanaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return gymkana.ID;
}
}
}
