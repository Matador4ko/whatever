
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Puntuacion_modificarPuntuacion) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class PuntuacionCEN
{
public void ModificarPuntuacion (WhateverGenNHibernate.EN.Whatever.PuntuacionEN punto)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Puntuacion_modificarPuntuacion) ENABLED START*/

        PuntuacionCAD punt = new PuntuacionCAD ();

        punt.Modify (punto);

        /*PROTECTED REGION END*/
}
}
}
