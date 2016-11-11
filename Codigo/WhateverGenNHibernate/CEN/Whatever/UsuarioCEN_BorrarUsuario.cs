
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Usuario_BorrarUsuario) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class UsuarioCEN
{
public void BorrarUsuario (int p_oid)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Usuario_BorrarUsuario) ENABLED START*/

        // Write here your custom code...

        UsuarioCAD usu = new UsuarioCAD ();
        EventoCAD eve = new EventoCAD();
        EventoCEN evec = new EventoCEN();
        RetoCAD ret = new RetoCAD();
        RetoCEN retc = new RetoCEN();

        System.Collections.Generic.IList<EventoEN> eventos;
        System.Collections.Generic.IList<RetoEN> retos;

        usu.Destroy (p_oid);

        eventos=eve.FiltrarPorUsuario(p_oid);
        foreach(EventoEN element in eventos){
            evec.BorrarEvento(element.ID);
        }

        retos = ret.FiltrarPorUsuario(p_oid);
        foreach(RetoEN element in retos){
            retc.BorrarReto(element.ID);
        }
        
        




        /*PROTECTED REGION END*/
}
}
}
