
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;



/*PROTECTED REGION ID(usingWhateverGenNHibernate.CP.Whatever_Gymkana_modificarGymkana) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CP.Whatever
{
public partial class GymkanaCP : BasicCP
{
public void ModificarGymkana (WhateverGenNHibernate.EN.Whatever.GymkanaEN gym, WhateverGenNHibernate.EN.Whatever.MapaEN mapa)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CP.Whatever_Gymkana_modificarGymkana) ENABLED START*/

        IGymkanaCAD gymkanaCAD = null;
        GymkanaCEN gymkanaCEN = null;



        try
        {
                SessionInitializeTransaction ();
                gymkanaCAD = new GymkanaCAD (session);
                gymkanaCEN = new  GymkanaCEN (gymkanaCAD);


                MapaCAD map = new MapaCAD ();

                MapaEN mapen = gym.Evento_mapa[0];
                mapen.Latitud = mapa.Latitud;
                mapen.Longitud = mapa.Longitud;
                mapen.Zoom = mapa.Zoom;

                gymkanaCAD.Modify (gym);
                map.Modify (mapen);


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
