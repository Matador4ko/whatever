
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;



/*PROTECTED REGION ID(usingWhateverGenNHibernate.CP.Whatever_Usuario_BorrarUsuario) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CP.Whatever
{
public partial class UsuarioCP : BasicCP
{
public void BorrarUsuario (int p_oid)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CP.Whatever_Usuario_BorrarUsuario) ENABLED START*/

        IUsuarioCAD usuarioCAD = null;
        UsuarioCEN usuarioCEN = null;



        try
        {
                SessionInitializeTransaction ();
                usuarioCAD = new UsuarioCAD (session);
                usuarioCEN = new  UsuarioCEN (usuarioCAD);


                UsuarioCAD usu = new UsuarioCAD (session);
                EventoCAD eve = new EventoCAD (session);
                EventoCP evec = new EventoCP ();
                RetoCAD ret = new RetoCAD (session);
                RetoCP retc = new RetoCP ();
                PuntuacionCAD pun = new PuntuacionCAD (session);
                ReporteCAD rep = new ReporteCAD (session);
                ComentarioCAD com = new ComentarioCAD (session);

                System.Collections.Generic.IList<EventoEN> eventos;
                System.Collections.Generic.IList<RetoEN> retos;
                System.Collections.Generic.IList<PuntuacionEN> puntuaciones;
                System.Collections.Generic.IList<ReporteEN> reportes;
                System.Collections.Generic.IList<ComentarioEN> comentarios;

                usu.Destroy (p_oid);

                eventos = eve.FiltrarPorUsuario (p_oid);
                foreach (EventoEN element in eventos) {
                        evec.BorrarEvento (element.ID);
                }

                retos = ret.FiltrarPorUsuario (p_oid);
                foreach (RetoEN element in retos) {
                        retc.BorrarReto (element.ID);
                }

                puntuaciones = pun.FiltrarPorUsuario (p_oid);
                foreach (PuntuacionEN element in puntuaciones) {
                        pun.Destroy (element.Id);
                }

                reportes = rep.FiltrarPorUsuario (p_oid);
                foreach (ReporteEN element in reportes) {
                        rep.Destroy (element.ID);
                }

                comentarios = com.FiltrarPorUsuario (p_oid);
                foreach (ComentarioEN element in comentarios) {
                        rep.Destroy (element.ID);
                }

                SessionCommit ();
        }
        catch (Exception ex)
        {
                SessionRollBack ();
                throw ex;
        }
        finally
        {
                SessionClose ();
        }


        /*PROTECTED REGION END*/
}
}
}
