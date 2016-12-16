
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;



/*PROTECTED REGION ID(usingWhateverGenNHibernate.CP.Whatever_Gymkana_crearGymkana) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CP.Whatever
{
public partial class GymkanaCP : BasicCP
{
public void CrearGymkana (WhateverGenNHibernate.EN.Whatever.GymkanaEN gym, double lat, double lon, int zoom)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CP.Whatever_Gymkana_crearGymkana) ENABLED START*/

        IGymkanaCAD gymkanaCAD = null;
        GymkanaCEN gymkanaCEN = null;



        try
        {
                SessionInitializeTransaction ();
                gymkanaCAD = new GymkanaCAD (session);
                gymkanaCEN = new  GymkanaCEN (gymkanaCAD);


                MapaCAD mapa = new MapaCAD (session);
                MapaEN map = new MapaEN ();

                map.Latitud = lat;
                map.Longitud = lon;
                map.Zoom = zoom;
                map.Evento_mapa2 = gym;

                gymkanaCAD.New_ (gym);
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
