
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Puntuacion_verMedia) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class PuntuacionCEN
{
public void VerMedia (int p_oid)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Puntuacion_verMedia) ENABLED START*/

    int puntuaciones;
    int media=0;
    PuntuacionCEN puntuacions=new PuntuacionCEN ();
  var lista =  puntuacions.GetListaPuntuaciones();

    for(int i=0;i<lista.Count ;i++){
        puntuaciones = _IPuntuacionCAD.
        media = media + puntuaciones;
    }
        
        /*PROTECTED REGION END*/
}
}
}
