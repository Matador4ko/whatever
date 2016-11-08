
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Admin_borrarEvento) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class AdminCEN
{
public void BorrarEvento (int id_eve)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Admin_borrarEvento) ENABLED START*/

        // Write here your custom code...

    EventoCEN evento = new EventoCEN();
    evento.Destroy(id_eve);



        /*PROTECTED REGION END*/
}
}
}
