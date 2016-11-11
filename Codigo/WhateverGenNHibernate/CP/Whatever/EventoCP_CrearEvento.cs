
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;



/*PROTECTED REGION ID(usingWhateverGenNHibernate.CP.Whatever_Evento_crearEvento) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CP.Whatever
{
public partial class EventoCP : BasicCP
{
public void CrearEvento (WhateverGenNHibernate.EN.Whatever.EventoEN evento, double lat, double long_, int zoom)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CP.Whatever_Evento_crearEvento) ENABLED START*/

        IEventoCAD eventoCAD = null;
        EventoCEN eventoCEN = null;



        try
        {
                SessionInitializeTransaction ();
                eventoCAD = new EventoCAD (session);
                eventoCEN = new  EventoCEN (eventoCAD);



                MapaCAD mapa = new MapaCAD ();
                MapaEN map = new MapaEN ();

                eventoCAD.New_ (evento);
                map.Latitud = lat;
                map.Longitud = long_;
                map.Zoom = zoom;
                map.Evento_mapa2 = evento;


                mapa.New_ (map);

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
