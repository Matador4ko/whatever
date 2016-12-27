using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WhateverGenNHibernate.EN.Whatever;

namespace MvcApplication1.Models
{
    public class AssemblerReporte
    {
        public Reporte ConvertENToModelUI(ReporteEN en)
        {
            if (en!=null)
            {
                Reporte rep = new Reporte();
                rep.id = en.ID;
                rep.Motivo = en.Motivo;
                rep.Usuario = en.Usuario_reporte.Nombre;
                rep.admin_reporte = en.Admin_reporte;
                rep.reporte_evento = en.Reporte;
                rep.reporte_reto2 = en.Reporte_reto2;
                rep.usuario_reporte = en.Usuario_reporte;

                return rep; 
            }
            else
            {
                return null;
            }
        }
        public IList<Reporte> ConvertListENToModel(IList<ReporteEN> ens)
        {
            IList<Reporte> rets = new List<Reporte>();
            foreach (ReporteEN en in ens)
            {
                rets.Add(ConvertENToModelUI(en));
            }
            return rets;
        }
        /*
        private int iD;
        private string motivo;
        private WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario_reporte;
        private System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.AdminEN> admin_reporte;
        private WhateverGenNHibernate.EN.Whatever.RetoEN reporte_reto2;
        private WhateverGenNHibernate.EN.Whatever.EventoEN reporte;
        */
    }
}