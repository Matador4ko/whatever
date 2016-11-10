
using System;
using WhateverGenNHibernate.EN.Whatever;

namespace WhateverGenNHibernate.CAD.Whatever
{
public partial interface IEventoCAD
{
EventoEN ReadOIDDefault (int ID
                         );

void ModifyDefault (EventoEN evento);




int New_ (EventoEN evento);

void Modify (EventoEN evento);


void Destroy (int ID
              );


System.Collections.Generic.IList<EventoEN> GetAll (int first, int size);


EventoEN GetID (int ID
                );


System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.EventoEN> ReadFilter ();
}
}
