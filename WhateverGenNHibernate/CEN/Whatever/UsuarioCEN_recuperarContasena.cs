
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Usuario_recuperarContasena) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class UsuarioCEN
{
public void RecuperarContasena (String nombre, string correo)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Usuario_recuperarContasena) ENABLED START*/

        UsuarioEN[] list = GetAll (0,0);
        foreach(UsuarioEN element in list){
                if (user.Email.equals(correo) && users.Nombre.equals(correo)){
                        return user.ID;
                }
        }

        /*PROTECTED REGION END*/
}
}
}
