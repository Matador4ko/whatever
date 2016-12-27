using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WhateverGenNHibernate.EN.Whatever;

namespace MvcApplication1.Models
{
    public class AssemblerMapa
    {
        public Mapa ConvertENToModelUI(MapaEN mapen)
        {
            if (mapen != null)
            {
                Mapa mapa = new Mapa();
                mapa.Latitud = mapen.Latitud;
                mapa.Longitud = mapen.Longitud;
                mapa.Zoom = mapen.Zoom;
                mapa.id = mapen.Id;
                mapa.evento_mapa = mapen.Evento_mapa2;
                mapa.paso = mapen.Paso_0;
            
                return mapa;
            }
            else 
            {
                return null; 
            }


        }
        public IList<Mapa> ConvertListENToModel(IList<MapaEN> ens)
        {
            IList<Mapa> evlist = new List<Mapa>();
            foreach (MapaEN mapen in ens)
            {
                evlist.Add(ConvertENToModelUI(mapen));
            }
            return evlist;
        }
    }
}