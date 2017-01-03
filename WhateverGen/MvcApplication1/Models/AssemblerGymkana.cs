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
            if (gymen != null)
            {
                AssemblerReporte assR = new AssemblerReporte();
                AssemblerMapa assM = new AssemblerMapa();
                AssemblerComentario assC = new AssemblerComentario();
                AssemblerPaso assP = new AssemblerPaso();
                PuntuacionCEN p = new PuntuacionCEN();
                Gymkana gymkana = new Gymkana();


                gymkana.Titulo = gymen.Titulo;
                gymkana.Descripcion = gymen.Descripcion;
                gymkana.Fecha = gymen.Fecha;
                gymkana.Precio = gymen.Precio;
                gymkana.Creador = gymen.Usuario.Nombre;
                gymkana.Puntuacion = p.VerMediaEvento(gymen.ID);

                //mapa
                gymkana.Mapa = null;
                if (gymen.Mapa != null)
                    gymkana.Mapa = assM.ConvertENToModelUI(gymen.Mapa);
                //comentarios
                gymkana.Comentarios = null;
                if (gymen.Comentario != null)
                    gymkana.Comentarios = assC.ConvertListENToModel(gymen.Comentario);

                //numero de pasos
                gymkana.Numeropasos = 0;
                if (gymen.Paso != null)
                    gymkana.Numeropasos = gymen.Paso.Count;

                //pasos
                IList<Paso> auxPasos = null;
                if (gymen.Paso != null)
                    auxPasos = assP.ConvertListENToModel(gymen.Paso);

                int numeroanterior = 0;
                foreach (var pasoactual in auxPasos)
                {
                    pasoactual.Numero = ++numeroanterior;
                    gymkana.ultimoPaso = numeroanterior;
                }

                gymkana.Pasos = auxPasos;

                //reportes
                IList<Reporte> aux1 = new List<Reporte>();
                ReporteCEN reportecen = new ReporteCEN();
                aux1 = assR.ConvertListENToModel(reportecen.FiltrarReportesPorEvento(gymen.ID));
                gymkana.Reportes = aux1;

                //atributos ocultos
                gymkana.id = gymen.ID;
                gymkana.usuario = gymen.Usuario;

                return gymkana;

            }
            else
            {
                return null;
            }


        }
        public IList<Gymkana> ConvertListENToModel(IList<GymkanaEN> ens)
        {
            if (ens != null && ens.Count > 0)
            {
                IList<Gymkana> gymlist = new List<Gymkana>();
                foreach (GymkanaEN gymen in ens)
                {
                    gymlist.Add(ConvertENToModelUI(gymen));
                }
                return gymlist;
            }
            else
            {
                return null;
            }
        }

    }
}
