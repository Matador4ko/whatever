
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
}
}