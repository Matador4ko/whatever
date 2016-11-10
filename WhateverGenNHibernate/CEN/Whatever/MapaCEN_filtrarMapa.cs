
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Mapa_filtrarMapa) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class MapaCEN
{
public void FiltrarMapa (double latitud, double longitud, double radio)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Mapa_filtrarMapa) ENABLED START*/

        // Write here your custom code...

    System.Collections.Generic.IList<MapaEN> listaM= this.GetAll(0,0);
    System.Collections.Generic.IList<MapaEN> listaMDentro = null;

    foreach (MapaEN map in listaM)
    {
        if (map.Evento_mapa2.ID != 0) {
            double lat = map.Latitud;
            double lon = map.Longitud;

            var difLatitud  = Convert.ToSingle(Math.Abs(latitud - lat) * (Math.PI / 180));
            var difLongitud = Convert.ToSingle(Math.Abs(longitud - lon) * (Math.PI / 180));



            var a = Math.Pow(Math.Sin(difLatitud / 2), 2) + (Math.Cos(latitud) * Math.Cos(lat) * Math.Pow(Math.Sin(difLongitud / 2), 2));
            a = Convert.ToDouble(a);
            double sqr1 = Math.Sqrt(a);
            double sqr2 = Math.Sqrt(1-a);

            double c = 2 * Math.Atan2 (sqr1, sqr2);
            if (c * 6370000 > radio)
                listaMDentro.Add(map);
        }
    }

        /*PROTECTED REGION END*/
}
}
}
