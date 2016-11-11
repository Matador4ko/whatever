
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;



/*PROTECTED REGION ID(usingWhateverGenNHibernate.CP.Whatever_Evento_modificarEvento) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CP.Whatever
{
public partial class EventoCP : BasicCP
{
public void ModificarEvento (WhateverGenNHibernate.EN.Whatever.MapaEN mapa, WhateverGenNHibernate.EN.Whatever.EventoEN evento)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CP.Whatever_Evento_modificarEvento) ENABLED START*/

        IEventoCAD eventoCAD = null;
        EventoCEN eventoCEN = null;



        try
        {
                SessionInitializeTransaction ();
                eventoCAD = new EventoCAD (session);
                eventoCEN = new  EventoCEN (eventoCAD);

                MapaCAD map = new MapaCAD ();

                eventoCAD.Modify (evento);
                map.Modify (mapa);


                SessionCommit ();
        }
        catch (Exception ex)
        {
                SessionRollBack ();
                throw ex;
        }
        finally
        {
                SessionClose ();
        }


        /*PROTECTED REGION END*/
}
}
}
