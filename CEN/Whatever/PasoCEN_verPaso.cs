
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
public PasoEN VerPaso (int id_paso)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Paso_verPaso) ENABLED START*/


    PasoCEN paso = new PasoCEN();
    System.Collections.Generic.IList<PasoEN> list = null;
    PasoEN aux = new PasoEN();

    list = paso.GetAll(0, 0);
    foreach (PasoEN element in list)
    {
        if (element.ID == id_paso)
        {
            aux = element;
        }
    }
    return aux;

        /*PROTECTED REGION END*/
}
}
}
