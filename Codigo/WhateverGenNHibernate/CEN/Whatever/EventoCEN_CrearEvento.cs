
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Evento_crearEvento) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class EventoCEN
{
public void CrearEvento (WhateverGenNHibernate.EN.Whatever.EventoEN evento)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Evento_crearEvento) ENABLED START*/

        // Write here your custom code...

    EventoCAD eve = new EventoCAD();

    eve.New_(evento);

        /*PROTECTED REGION END*/
}
}
}
