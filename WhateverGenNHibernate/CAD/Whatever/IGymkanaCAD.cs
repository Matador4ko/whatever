
using System;
using WhateverGenNHibernate.EN.Whatever;

namespace WhateverGenNHibernate.CAD.Whatever
{
public partial interface IGymkanaCAD
{
GymkanaEN ReadOIDDefault (int ID
                          );

void ModifyDefault (GymkanaEN gymkana);




int New_ (GymkanaEN gymkana);


System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.GymkanaEN> ReadFilter ();


void Modify (GymkanaEN gymkana);


void Destroy (int ID
              );
}
}
