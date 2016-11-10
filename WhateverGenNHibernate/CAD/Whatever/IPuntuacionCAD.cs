
using System;
using WhateverGenNHibernate.EN.Whatever;

namespace WhateverGenNHibernate.CAD.Whatever
{
public partial interface IPuntuacionCAD
{
PuntuacionEN ReadOIDDefault (int id
                             );

void ModifyDefault (PuntuacionEN puntuacion);





int New_ (PuntuacionEN puntuacion);

System.Collections.Generic.IList<PuntuacionEN> GetPuntuaciones (int first, int size);


PuntuacionEN GetID (int id
                    );


System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> ReadFilter ();
}
}
