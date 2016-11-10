
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Usuario_consultarUsuario) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class UsuarioCEN
{
public UsuarioEn ConsultarUsuario (int p_oid)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Usuario_consultarUsuario) ENABLED START*/

        UsuarioEN user = new UsuarioEN();
        return user.getID();

        /*PROTECTED REGION END*/
}
}
}
