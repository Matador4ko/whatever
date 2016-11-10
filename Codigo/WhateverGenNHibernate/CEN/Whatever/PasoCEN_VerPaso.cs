
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Paso_verPaso) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class PasoCEN
{
public WhateverGenNHibernate.EN.Whatever.PasoEN VerPaso (int p_oid)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Paso_verPaso) ENABLED START*/

        // Write here your custom code...


        PasoCEN paso = new PasoCEN ();
        PasoEN salida = new PasoEN ();

        salida = paso.GetID (p_oid);
        return salida;
        /*PROTECTED REGION END*/
}
}
}
