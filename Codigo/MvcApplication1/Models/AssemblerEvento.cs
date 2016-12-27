using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CEN.Whatever;


namespace MvcApplication1.Models
{
    public class AssemblerEvento
    {
        public Evento ConvertENToModelUI(EventoEN even)
        {
            AssemblerMapa assM = new AssemblerMapa();
            AssemblerComentario assC = new AssemblerComentario();
            PuntuacionCEN p = new PuntuacionCEN();
            Evento evento = new Evento();
            evento.Titulo = even.Titulo;
            evento.Descripcion = even.Descripcion;
            evento.Fecha = even.Fecha;
            evento.Precio = even.Precio;
            evento.Creador = even.Usuario_evento.Nombre;
            evento.Puntuacion = p.VerMedia(even.ID, -1);

            //mapa
            evento.Mapa = null;
            if (even.Evento_mapa != null)
                evento.Mapa = assM.ConvertENToModelUI(even.Evento_mapa[0]);
            //comentarios
            evento.Comentarios = null;
            if(even.Comentario_evento!=null)
                evento.Comentarios = assC.ConvertListENToModel(even.Comentario_evento);
            
            //atributos ocultos
            evento.id = even.ID;
            evento.usuario_evento = even.Usuario_evento;
            evento.reporte_evento = even.Reporte_evento2;

            return evento;

        }
        public IList<Evento> ConvertListENToModel(IList<EventoEN> ens)
        {
            IList<Evento> evlist = new List<Evento>();
            foreach (EventoEN even in ens)
            {
                evlist.Add(ConvertENToModelUI(even));
            }
            return evlist;
        }

    }
}