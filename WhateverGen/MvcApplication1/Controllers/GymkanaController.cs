using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;
using WhateverGenNHibernate.CP.Whatever;
using WhateverGenNHibernate.EN.Whatever;

namespace MvcApplication1.Controllers
{
    public class GymkanaController : BasicController
    {
        //
        // GET: /Gymkana/

        public ActionResult Index()
        {
            
            SessionInitialize();
            GymkanaCAD cad = new GymkanaCAD(session);
            var aux = cad.ReadAllDefault(0, -1).ToList();

            SessionClose();

            return View(aux);
        }

        //
        // GET: /Gymkana/Details/5

        public ActionResult Details(int id)
        {
            Gymkana gym = null;
            SessionInitialize();
            GymkanaEN gymen = new GymkanaCAD(session).ReadOIDDefault(id);
            gym = new AssemblerGymkana().ConvertENToModelUI(gymen);
            SessionClose();
            return View(gym);
        }

        //
        // GET: /Gymkana/Create

        public ActionResult Create()
        {
            Gymkana gym = new Gymkana();
            gym.Creador = User.Identity.Name;
            return View(gym);
        }

        //
        // POST: /Gymkana/Create

        [HttpPost]
        public ActionResult Create(Gymkana gym)
        {
            try
            {
                GymkanaCP cp = new GymkanaCP();
                GymkanaEN en = new GymkanaEN();
                UsuarioCAD cad = new UsuarioCAD();

                cad.FiltrarUsuarioPorNombre(User.Identity.Name);

                en.Titulo = gym.Titulo;
                en.Descripcion = gym.Descripcion;
                en.Fecha = gym.Fecha;
                en.Usuario = gym.usuario;
                en.Precio = gym.Precio;

                en.NumPasos = 1;

                cp.CrearGymkana(en, gym.Mapa.Latitud, gym.Mapa.Longitud, gym.Mapa.Zoom);
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Gymkana/Edit/5

        public ActionResult Edit(int id)
        {
            Gymkana gym = null;
            SessionInitialize();
            GymkanaEN gymen = new GymkanaCAD(session).ReadOIDDefault(id);
            gym = new AssemblerGymkana().ConvertENToModelUI(gymen);
            SessionClose();
            return View(gym);

        }

        //
        // POST: /Gymkana/Edit/5

        [HttpPost]
        public ActionResult Edit(Gymkana gym)
        {
            try
            {
                GymkanaCEN cen = new GymkanaCEN();
                cen.Modify(gym.id, gym.Titulo, gym.Descripcion, gym.Fecha, gym.Precio, gym.Numeropasos);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Gymkana/Delete/5

        public ActionResult Delete(int id)
        {
            SessionInitialize();
            GymkanaCAD cad = new GymkanaCAD(session);
            GymkanaCEN cen = new GymkanaCEN(cad);
            GymkanaEN en = cen.GetID(id);
            Gymkana gym = new AssemblerGymkana().ConvertENToModelUI(en);
            SessionClose();


            new GymkanaCEN().Destroy(id);
            return RedirectToAction("Index");
        }

        //
        // POST: /Gymkana/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Gymkana/List

        public ActionResult List()
        {
            SessionInitialize();
            GymkanaCAD cad = new GymkanaCAD(session);
            UsuarioCAD usucad = new UsuarioCAD(session);
            UsuarioEN usuen = usucad.FiltrarUsuarioPorNombre(User.Identity.Name);
            var aux = cad.FiltrarGymkanaPorUsuario(usuen.ID);

            SessionClose();

            return View(aux);
        }
    }
}
