
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Puntuacion_verMediaEvento) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class PuntuacionCEN
{
public double VerMediaEvento (int id_evento)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Puntuacion_verMediaEvento) ENABLED START*/

        // Write here your custom code...
        int suma = 0;
        double media;

        System.Collections.Generic.IList<PuntuacionEN> puntuaciones = new System.Collections.Generic.List<PuntuacionEN>();
        puntuaciones = FiltrarPuntuacionPorEvento (id_evento);
        foreach (PuntuacionEN element in puntuaciones) {
                suma = element.Puntuacion;
        }
        if (suma != 0) {
                media = suma / puntuaciones.Count;
                return media;
        }
        return 0.0;

        /*PROTECTED REGION END*/
}
}
}
