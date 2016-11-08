
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Admin_borrarRetos) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class AdminCEN
{
public void BorrarRetos (int p_oid)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Admin_borrarRetos) ENABLED START*/

        // Write here your custom code...

        RetoCEN reto = new RetoCEN ();
        MapaCEN mapa = new MapaCEN ();

        System.Collections.Generic.IList<MapaEN> aux;
        aux = mapa.GetAll (0, 0);
        int id_mapa = -1;

        foreach (MapaEN element in aux) {
                if (element.Reto_mapa.ID == p_oid) {
                        id_mapa = element.Id;
                }
        }

        mapa.Destroy (id_mapa);
        reto.Destroy (p_oid);
        /*PROTECTED REGION END*/
}
}
}
