
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;



/*PROTECTED REGION ID(usingWhateverGenNHibernate.CP.Whatever_Usuario_hacerAdmin) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CP.Whatever
{
public partial class UsuarioCP : BasicCP
{
public bool HacerAdmin (int p_oid, string nombre)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CP.Whatever_Usuario_hacerAdmin) ENABLED START*/

        IUsuarioCAD usuarioCAD = null;
        UsuarioCEN usuarioCEN = null;

        return true;

        try
        {
                SessionInitializeTransaction ();
                usuarioCAD = new UsuarioCAD (session);
                usuarioCEN = new  UsuarioCEN (usuarioCAD);


                AdminCAD admincad = new AdminCAD (session);
                UsuarioEN usuen = new UsuarioEN ();
                AdminEN admin = new AdminEN ();
                usuen = usuarioCAD.GetID (p_oid);
                usuarioCAD.Destroy (p_oid);

                SessionCommit ();
        }
        catch (Exception ex)
        {
                SessionRollBack ();
                throw ex;
        }
        finally
        {
                SessionClose ();
        }


        /*PROTECTED REGION END*/
}
}
}
