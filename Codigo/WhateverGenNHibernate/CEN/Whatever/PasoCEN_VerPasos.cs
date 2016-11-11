
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Paso_verPasos) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class PasoCEN
{
public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PasoEN> VerPasos (int p_oid)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Paso_verPasos) ENABLED START*/

        // Write here your custom code...


        PasoCEN paso = new PasoCEN ();
        GymkanaCEN gym = new GymkanaCEN ();

        System.Collections.Generic.IList<PasoEN> pasos;
        System.Collections.Generic.IList<PasoEN> salida = null;

        pasos = FiltrarPasos (p_oid);

        foreach (PasoEN element in pasos) {
                salida.Add (element);
        }
        return salida;
        /*PROTECTED REGION END*/
}
}
}
