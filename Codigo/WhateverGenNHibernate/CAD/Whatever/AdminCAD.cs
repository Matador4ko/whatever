
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
 * Clase Admin:
 *
 */

namespace WhateverGenNHibernate.CAD.Whatever
{
public partial class AdminCAD : BasicCAD, IAdminCAD
{
public AdminCAD() : base ()
{
}

public AdminCAD(ISession sessionAux) : base (sessionAux)
{
}



public AdminEN ReadOIDDefault (int ID
                               )
{
        AdminEN adminEN = null;

        try
        {
                SessionInitializeTransaction ();
                adminEN = (AdminEN)session.Get (typeof(AdminEN), ID);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in AdminCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return adminEN;
}

public System.Collections.Generic.IList<AdminEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<AdminEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(AdminEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<AdminEN>();
                        else
                                result = session.CreateCriteria (typeof(AdminEN)).List<AdminEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in AdminCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (AdminEN admin)
{
        try
        {
                SessionInitializeTransaction ();
                AdminEN adminEN = (AdminEN)session.Load (typeof(AdminEN), admin.ID);

                session.Update (adminEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in AdminCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (AdminEN admin)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (admin);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in AdminCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return admin.ID;
}

public void Modify (AdminEN admin)
{
        try
        {
                SessionInitializeTransaction ();
                AdminEN adminEN = (AdminEN)session.Load (typeof(AdminEN), admin.ID);

                adminEN.Nombre = admin.Nombre;


                adminEN.Seguidores = admin.Seguidores;


                adminEN.Edad = admin.Edad;


                adminEN.Sexo = admin.Sexo;


                adminEN.Facebook = admin.Facebook;


                adminEN.Instagram = admin.Instagram;


                adminEN.Historial = admin.Historial;


                adminEN.Contrasena = admin.Contrasena;


                adminEN.Email = admin.Email;


                adminEN.Foto = admin.Foto;

                session.Update (adminEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in AdminCAD.", ex);
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
                AdminEN adminEN = (AdminEN)session.Load (typeof(AdminEN), ID);
                session.Delete (adminEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in AdminCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<AdminEN> GetAll (int first, int size)
{
        System.Collections.Generic.IList<AdminEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(AdminEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<AdminEN>();
                else
                        result = session.CreateCriteria (typeof(AdminEN)).List<AdminEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in AdminCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

//Sin e: GetID
//Con e: AdminEN
public AdminEN GetID (int ID
                      )
{
        AdminEN adminEN = null;

        try
        {
                SessionInitializeTransaction ();
                adminEN = (AdminEN)session.Get (typeof(AdminEN), ID);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in AdminCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return adminEN;
}

public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.AdminEN> FiltrarMapa ()
{
        System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.AdminEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM AdminEN self where FROM AdminEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("AdminENfiltrarMapaHQL");

                result = query.List<WhateverGenNHibernate.EN.Whatever.AdminEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in AdminCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
