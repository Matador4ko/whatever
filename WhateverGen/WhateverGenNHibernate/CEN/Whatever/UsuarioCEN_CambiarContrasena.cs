
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Usuario_cambiarContrasena) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class UsuarioCEN
{
public bool CambiarContrasena (int p_oid, String contra)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Usuario_cambiarContrasena) ENABLED START*/

        // Write here your custom code...


        UsuarioEN user = GetID (p_oid);
        String aux = user.Contrasena;
        UsuarioCEN usucen = new UsuarioCEN ();

        usucen.GetID (p_oid);

        Modify (user.ID, user.Nombre, user.Edad, user.Sexo, user.Facebook, user.Instagram, user.Twitter, contra, user.Email, user.Foto);

        if (!aux.Equals (user.Contrasena)) {
                return true;
        }
        return false;

        /*PROTECTED REGION END*/
}
}
}
