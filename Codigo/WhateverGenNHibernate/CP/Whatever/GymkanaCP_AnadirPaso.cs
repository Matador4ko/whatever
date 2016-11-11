
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;



/*PROTECTED REGION ID(usingWhateverGenNHibernate.CP.Whatever_Gymkana_anadirPaso) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CP.Whatever
{
public partial class GymkanaCP : BasicCP
{
public void AnadirPaso (WhateverGenNHibernate.EN.Whatever.PasoEN paso)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CP.Whatever_Gymkana_anadirPaso) ENABLED START*/

        IGymkanaCAD gymkanaCAD = null;
        GymkanaCEN gymkanaCEN = null;



        try
        {
                SessionInitializeTransaction ();
                gymkanaCAD = new GymkanaCAD (session);
                gymkanaCEN = new  GymkanaCEN (gymkanaCAD);


                PasoCEN paso = new PasoCEN ();
                MapaCEN mapa = new MapaCEN ();
                int aux = -1;
                int aux2 = -1;

                paso.New_ (descripcion, id_gym);

                System.Collections.Generic.IList<MapaEN> mapas;
                mapas = mapa.GetAll (0, 0);

                aux2 = mapas [mapas.Count - 1].Id;
                mapa.New_ (id_gym, aux + 1, latitud, longitud, zoom);

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
