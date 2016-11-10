
using System;
using WhateverGenNHibernate.EN.Whatever;

namespace WhateverGenNHibernate.CAD.Whatever
{
public partial interface IReporteCAD
{
ReporteEN ReadOIDDefault (int ID
                          );

void ModifyDefault (ReporteEN reporte);




int New_ (ReporteEN reporte);

void Destroy (int ID
              );


System.Collections.Generic.IList<ReporteEN> GetAll (int first, int size);


ReporteEN GetID (int ID
                 );



System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> ReadFilter ();
}
}
