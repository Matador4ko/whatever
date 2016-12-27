using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using WhateverGenNHibernate.EN.Whatever;

namespace MvcApplication1.Models
{
    public class AssemblerPaso
    {
        public Paso ConvertENToModelUI(PasoEN pasen)
        {
            AssemblerMapa ass = new AssemblerMapa();
            Paso paso = new Paso();
            paso.Numero = -1;
            paso.Descripcion = pasen.Descripcion;

            //atributos ocultos
            paso.Mapa = ass.ConvertENToModelUI(pasen.Paso);
            paso.gymkana_paso = pasen.Gymkana_paso2;
            paso.id = pasen.ID;

            return paso;

        }
        public IList<Paso> ConvertListENToModel(IList<PasoEN> ens)
        {
            IList<Paso> paslist = new List<Paso>();
            foreach (PasoEN pasen in ens)
            {
                paslist.Add(ConvertENToModelUI(pasen));
            }
            return paslist;
        }

    }
}
