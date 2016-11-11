
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
public void HacerAdmin (int p_oid)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CP.Whatever_Usuario_hacerAdmin) ENABLED START*/

        IUsuarioCAD usuarioCAD = null;
        UsuarioCEN usuarioCEN = null;



        try
        {
                SessionInitializeTransaction ();
                usuarioCAD = new UsuarioCAD (session);
                usuarioCEN = new  UsuarioCEN (usuarioCAD);


                AdminCAD admincad = new AdminCAD ();
                UsuarioEN usuen = new UsuarioEN ();
                AdminEN admin = new AdminEN ();
                usuen = usuarioCAD.GetID (p_oid);
                usuarioCAD.Destroy (p_oid);
                admin.Contrasena = usuen.Contrasena;
                admin.Edad = usuen.Edad;
                admin.Email = usuen.Email;
                admin.Facebook = usuen.Facebook;
                admin.Foto = usuen.Foto;
                admin.Historial = usuen.Historial;
                admin.ID = usuen.ID;
                admin.Instagram = usuen.Instagram;
                admin.Nombre = usuen.Nombre;
                admin.Seguidores = admin.Seguidores;
                admin.Sexo = usuen.Sexo;

                admincad.New_ (admin);


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
