
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
public float VerMedia (int id_gym, int id_reto)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Puntuacion_verMedia) ENABLED START*/

        // Write here your custom code...

        float media = 0;
        int cont = 0;

        if (id_gym == -1) {
                PuntuacionCEN puntuacion = new PuntuacionCEN ();
                RetoCEN reto = new RetoCEN ();
                System.Collections.Generic.IList<PuntuacionEN> puntuaciones;
                System.Collections.Generic.IList<RetoEN> retos;
                puntuaciones = puntuacion.GetPuntuaciones (0, 0);
                retos = reto.GetAll (0, 0);
                foreach (PuntuacionEN element in puntuaciones) {
                        if (element.Reto_puntuacion.ID == id_reto) {
                                media = media + element.Puntuacion;
                                cont++;
                        }
                }
                return media = media / cont;
        }
        else if (id_reto == -1) {
                PuntuacionCEN puntuacion = new PuntuacionCEN ();
                EventoCEN evento = new EventoCEN ();
                System.Collections.Generic.IList<PuntuacionEN> puntuaciones;
                System.Collections.Generic.IList<EventoEN> eventos;
                puntuaciones = puntuacion.GetPuntuaciones (0, 0);
                eventos = evento.GetAll (0, 0);
                foreach (PuntuacionEN element in puntuaciones) {
                        if (element.Evento_puntuacion.ID == id_gym) {
                                media = media + element.Puntuacion;
                                cont++;
                        }
                }
                return media = media / cont;
        }
        return -1;
        /*PROTECTED REGION END*/
}
}
}
