
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Comentario_modificarComentario) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class ComentarioCEN
{
public void ModificarComentario (string comentario, int id)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Comentario_modificarComentario) ENABLED START*/

        // Write here your custom code...

        ComentarioCAD comen = new ComentarioCAD ();
        ComentarioEN com = new ComentarioEN ();

        com = GetID (id);
        com.Texto = comentario;

        comen.Modify (com);

        /*PROTECTED REGION END*/
}
}
}
