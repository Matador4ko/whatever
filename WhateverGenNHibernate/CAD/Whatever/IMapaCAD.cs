
using System;
using WhateverGenNHibernate.EN.Whatever;

namespace WhateverGenNHibernate.CAD.Whatever
{
public partial interface IMapaCAD
{
MapaEN ReadOIDDefault (int id
                       );

void ModifyDefault (MapaEN mapa);




int New_ (MapaEN mapa);

System.Collections.Generic.IList<MapaEN> GetAll (int first, int size);


MapaEN GetID (int id
              );


void Modify (MapaEN mapa);


void Destroy (int id
              );


System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.MapaEN> ReadFilter ();
}
}
