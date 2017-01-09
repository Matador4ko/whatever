using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CEN.Whatever;

namespace MvcApplication1.Models
{
    public class AssemblerAdmin
    {
        public Admin ConvertENToModelUI(AdminEN en)
        {
            if (en != null)
            {
                AssemblerReto assR = new AssemblerReto();
                AssemblerReporte assRep = new AssemblerReporte();
                AssemblerEvento assE = new AssemblerEvento();
                AssemblerComentario assC = new AssemblerComentario();
                AssemblerPuntuacion assPu = new AssemblerPuntuacion();
                AssemblerPaso assP = new AssemblerPaso();

                PuntuacionCEN p = new PuntuacionCEN();
                Admin adm = new Admin();
                adm.id = en.ID;
                adm.Nombre = en.Nombre;
                adm.Edad = en.Edad;
                adm.Contrasena = en.Contrasena;
                adm.Email = en.Email;
                adm.Foto = en.Foto;
                adm.Facebook = en.Facebook;
                adm.Twitter = en.Twitter;
                adm.Instagram = en.Instagram;

                adm.reto = en.Reto;
                adm.evento = en.Evento;
                adm.reporte = en.Reporte;
                adm.puntuacion = en.Puntuacion;


                adm.Retos = null;
                if (en.Reto != null)
                    adm.Retos = assR.ConvertListENToModel(en.Reto);

                adm.Eventos = null;
                if (en.Evento != null)
                    adm.Eventos = assE.ConvertListENToModel(en.Evento);

                adm.Puntuaciones = null;
                if (en.Puntuacion != null)
                    adm.Puntuaciones = assPu.ConvertListENToModel(en.Puntuacion);

                adm.Reportes = null;
                if (en.Reporte != null)
                    adm.Reportes = assRep.ConvertListENToModel(en.Reporte);

                adm.Comentarios = null;
                if (en.Comentario != null)
                    adm.Comentarios = assC.ConvertListENToModel(en.Comentario);

                return adm;
            }
            else
            {
                return null;
            }
        }
        public IList<Admin> ConvertListENToModel(IList<AdminEN> ens)
        {
            if (ens != null && ens.Count > 0)
            {

                IList<Admin> adm = new List<Admin>();
                foreach (AdminEN en in ens)
                {
                    adm.Add(ConvertENToModelUI(en));
                }
                return adm;
            }
            else
            {
                return null;
            }
        }
    }
}