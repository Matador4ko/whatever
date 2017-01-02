
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

                MapaCP mapa = new MapaCP (session);

                int id_gym = gymkanaCAD.New_ (gym);
                mapa.CrearMapaParaEvento (id_gym, lat, lon, zoom);

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
