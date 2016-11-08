
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Gymkana_verPasos) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class GymkanaCEN
{
public IList<PasoEN> VerPasos (int id_gym)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Gymkana_verPasos) ENABLED START*/

        PasoCEN paso = new PasoCEN ();
        return paso.VerPasos(id_gym);
        /*PROTECTED REGION END*/
}
}
}
