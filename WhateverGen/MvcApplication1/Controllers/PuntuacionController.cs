using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CP.Whatever;
using WhateverGenNHibernate.EN.Whatever;

namespace MvcApplication1.Controllers
{
    public class PuntuacionController : BasicController
    {
        //
        // GET: /Puntuacion/

        public ActionResult PuntuacionEvento(int id)
        {
            SessionInitialize();
            PuntuacionCAD cad = new PuntuacionCAD(session);
            var aux = cad.FiltrarPuntuacionPorEvento(id);

            SessionClose();

            return View(aux);
        }

        public ActionResult PuntuacionGymkana(int id)
        {
            SessionInitialize();
            PuntuacionCAD cad = new PuntuacionCAD(session);
            var aux = cad.FiltrarPuntuacionPorGymkana(id);

            SessionClose();

            return View(aux);
        }

        public ActionResult PuntuacionReto(int id)
        {
            SessionInitialize();
            PuntuacionCAD cad = new PuntuacionCAD(session);
            var aux = cad.FiltrarPuntuacionPorReto(id);

            SessionClose();

            return View(aux);
        }
        //
        // GET: /Puntuacion/Details/5

        public ActionResult Details(int id)
        {
            Puntuacion punt = null;
            SessionInitialize();
            PuntuacionEN puntEN = new PuntuacionCAD(session).ReadOIDDefault(id);
            punt = new AssemblerPuntuacion().ConvertENToModelUI(puntEN);
            SessionClose();
            return View(punt);
        }

        //
        // GET: /Puntuacion/CreateGymkana

        public ActionResult CreateGymkana(int id)
        {
            SessionInitialize();

            Puntuacion punt = new Puntuacion();

            punt.idGymkana = id;

            SessionClose();
            return View(punt);
        }

        //
        // GET: /Puntuacion/CreateEvento

        public ActionResult CreateEvento(int id)
        {
            SessionInitialize();

            Puntuacion punt = new Puntuacion();

            punt.idEvento = id;

            SessionClose();
            return View(punt);
        }

        //
        // GET: /Puntuacion/CreateReto

        public ActionResult CreateReto(int id)
        {
            SessionInitialize();

            Puntuacion punt = new Puntuacion();

            punt.idReto = id;

            SessionClose();
            return View(punt);
        }

        //
        // POST: /Puntuacion/CreateEvento

        [HttpPost]
        public ActionResult CreateEvento(Puntuacion punt)
        {
            try
            {
                UsuarioCAD usucad = new UsuarioCAD();
                UsuarioEN usuen = usucad.FiltrarUsuarioPorNombre(User.Identity.Name);
                PuntuacionCP puntcp = new PuntuacionCP();
                EventoCAD evcad = new EventoCAD();
                EventoEN even = evcad.GetID(punt.id);

                puntcp.CrearPuntuacionParaEvento(even.ID, punt.Puntos, usuen.ID);

                return RedirectToAction("PuntuacionEvento", new { id = punt.id });

            }
            catch
            {
                return View();
            }
        }

        //
        // POST: /Puntuacion/CreateGymkana

        [HttpPost]
        public ActionResult CreateGymkana(Puntuacion punt)
        {
            try
            {
                UsuarioCAD usucad = new UsuarioCAD();
                UsuarioEN usuen = usucad.FiltrarUsuarioPorNombre(User.Identity.Name);
                PuntuacionCP puntcp = new PuntuacionCP();
                GymkanaCAD gymcad = new GymkanaCAD();
                GymkanaEN gymen = gymcad.GetID(punt.id);

                puntcp.CrearPuntuacionParaGymkana(gymen.ID, punt.Puntos, usuen.ID);

                return RedirectToAction("PuntuacionGymkana", new { id = punt.id });

            }
            catch
            {
                return View();
            }
        }

        //
        // POST: /Puntuacion/CreateReto

        [HttpPost]
        public ActionResult CreateReto(Puntuacion punt)
        {
            try
            {
                UsuarioCAD usucad = new UsuarioCAD();
                UsuarioEN usuen = usucad.FiltrarUsuarioPorNombre(User.Identity.Name);
                PuntuacionCP puntcp = new PuntuacionCP();
                RetoCAD retcad = new RetoCAD();
                RetoEN reten = retcad.GetID(punt.id);

                puntcp.CrearPuntuacionParaReto(reten.ID, punt.Puntos, usuen.ID);

                return RedirectToAction("PuntuacionReto", new { id = punt.id });

            }
            catch
            {
                return View();
            }
        }

        // GET: /Puntuacion/Delete/5

        public ActionResult Delete(int id)
        {
            Puntuacion punt = null;
            SessionInitialize();
            PuntuacionEN punten = new PuntuacionCAD(session).ReadOIDDefault(id);
            punt = new AssemblerPuntuacion().ConvertENToModelUI(punten);
            SessionClose();
            return View(punt);
        }

        //
        // POST: /Puntuacion/Delete/5

        [HttpPost]
        public ActionResult Delete(Puntuacion punt)
        {
            try
            {
                PuntuacionCP cp = new PuntuacionCP();
                PuntuacionEN punten = new PuntuacionCAD().GetID(punt.id);

                if (punten.Evento != null)
                {
                    cp.BorrarPuntuacionEvento(punt.idEvento);
                    return RedirectToAction("IndexEvento", new { id = punten.Evento.ID });
                }
                else if (punten.Gymkana != null)
                {
                    cp.BorrarPuntuacionGymkana(punt.idGymkana);
                    return RedirectToAction("IndexGymkana", new { id = punten.Gymkana.ID });
                }
                else if (punten.Reto != null)
                {
                    cp.BorrarPuntuacionReto(punt.idReto);
                    return RedirectToAction("IndexReto", new { id = punten.Reto.ID });
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
