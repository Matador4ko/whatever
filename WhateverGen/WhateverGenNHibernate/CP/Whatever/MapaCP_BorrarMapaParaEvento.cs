
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;



/*PROTECTED REGION ID(usingWhateverGenNHibernate.CP.Whatever_Mapa_borrarMapaParaEvento) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CP.Whatever
{
public partial class MapaCP : BasicCP
{
public void BorrarMapaParaEvento (int id_evento)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CP.Whatever_Mapa_borrarMapaParaEvento) ENABLED START*/

        IMapaCAD mapaCAD = null;
        MapaCEN mapaCEN = null;



        try
        {
                SessionInitializeTransaction ();
                mapaCAD = new MapaCAD (session);
                mapaCEN = new  MapaCEN (mapaCAD);



                // Write here your custom transaction ...
                MapaEN mapen = new MapaEN ();
                mapen = mapaCEN.FiltrarMapaPorEvento (id_evento);
                mapaCAD.UnrelationerMapaEvento (mapen.Id, id_evento);
                mapaCAD.Destroy (mapen.Id);

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
