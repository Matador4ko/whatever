
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



System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> FiltrarEvento (int? id_evento, int ? id_usuario);


System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> FiltrarReto (int? id_reto, int ? id_usuario);



System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> FiltrarTodosEventos (int ? id_evento);


System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> FiltrarTodosRetos (int ? id_reto);


System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> FiltrarPorUsuario (int ? id_usuario);
}
}
