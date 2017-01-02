
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


WhateverGenNHibernate.EN.Whatever.ReporteEN FiltrarReportePorEventoYUsuario (int? id_evento, int ? id_usuario);


WhateverGenNHibernate.EN.Whatever.ReporteEN FiltrarReportePorRetoYUsuario (int? id_reto, int ? id_usuario);


System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> FiltrarReportesPorEvento (int ? id_evento);


System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> FiltrarReportesPorReto (int ? id_reto);


System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> FiltrarReportesPorUsuario (int ? id_usuario);




void RelationerReporteReto (int id_reporte, int id_reto);

void RelationerReporteEvento (int id_reporte, int id_evento);



void UnrelationerReporteReto (int id_reporte, int id_reto);

void UnrelationerReporteEvento (int id_reporte, int id_evento);
}
}
