using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WhateverGenNHibernate.EN.Whatever;

namespace MvcApplication1.Models
{
    public class AssemblerArticulo
    {
        public Usuario ConvertENToModelUI(UsuarioEN en)
        {
            Usuario usu = new Usuario();
            usu.id = en.ID;
            usu.Nombre = en.Nombre;
            usu.Contrasena = en.Contrasena;
            usu.Edad = en.Edad;
            usu.email = en.Email;

            return usu;


        }
        public IList<Usuario> ConvertListENToModel(IList<UsuarioEN> ens)
        {
            IList<Usuario> usu = new List<Usuario>();
            foreach (UsuarioEN en in ens)
            {
                usu.Add(ConvertENToModelUI(en));
            }
            return usu;
        }

    }
}
