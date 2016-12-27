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
    public class AssemblerGymkana
    {
        public Gymkana ConvertENToModelUI(GymkanaEN gymen)
        {
            AssemblerMapa assM = new AssemblerMapa();
            AssemblerComentario assC = new AssemblerComentario();
            AssemblerPaso assP = new AssemblerPaso();
            PuntuacionCEN p = new PuntuacionCEN();
            Gymkana gymkana = new Gymkana();
            gymkana.Titulo = gymen.Titulo;
            gymkana.Descripcion = gymen.Descripcion;
            gymkana.Fecha = gymen.Fecha;
            gymkana.Precio = gymen.Precio;
            gymkana.Creador = gymen.Usuario_evento.Nombre;
            gymkana.Puntuacion = p.VerMedia(gymen.ID, -1);

            //mapa
            gymkana.Mapa = null;
            if (gymen.Evento_mapa != null)
                gymkana.Mapa = assM.ConvertENToModelUI(gymen.Evento_mapa[0]);
            //comentarios
            gymkana.Comentarios = null;
            if (gymen.Comentario_evento != null)
                gymkana.Comentarios = assC.ConvertListENToModel(gymen.Comentario_evento);
            
            //numero de pasos
            gymkana.Numeropasos = 0;
            if (gymen.Gymkana_paso != null)
                gymkana.Numeropasos = gymen.Gymkana_paso.Count;

            //pasos
            IList<Paso> auxPasos = null;
            if (gymen.Gymkana_paso != null)
                auxPasos = assP.ConvertListENToModel(gymen.Gymkana_paso);

            int numeroanterior = 0;
            foreach(var pasoactual in auxPasos){
                pasoactual.Numero = ++numeroanterior;
            }

            gymkana.Pasos= auxPasos;

            //atributos ocultos
            gymkana.id = gymen.ID;
            gymkana.usuario_evento = gymen.Usuario_evento;
            gymkana.reporte_evento = gymen.Reporte_evento2;

            return gymkana;


        }
        public IList<Gymkana> ConvertListENToModel(IList<GymkanaEN> ens)
        {
            IList<Gymkana> gymlist = new List<Gymkana>();
            foreach (GymkanaEN gymen in ens)
            {
                gymlist.Add(ConvertENToModelUI(gymen));
            }
            return gymlist;
        }

    }
}
