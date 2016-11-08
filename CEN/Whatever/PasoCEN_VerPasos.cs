
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
public IList<PasoEN> VerPasos (int id_gym)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Paso_verPasos) ENABLED START*/

        // Write here your custom code...


    PasoCEN paso = new PasoCEN();
    System.Collections.Generic.IList<PasoEN> list = null;
    System.Collections.Generic.IList<PasoEN> aux = null;


    list = paso.GetAll(0, 0);
    foreach (PasoEN element in list)
    {
        if (element.Gymkana_paso2.ID == id_gym)
        {
            aux.Add(element);
        }
    }
    return aux;
        /*PROTECTED REGION END*/
}
}
}
