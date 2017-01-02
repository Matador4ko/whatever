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
    public class EventoController : BasicController
    {
        //
        // GET: /Evento/

        public ActionResult Index()
        {
            SessionInitialize();
            EventoCAD cad = new EventoCAD(session);
            UsuarioCAD usucad = new UsuarioCAD(session);
            UsuarioEN usuen = usucad.FiltrarUsuarioPorNombre(User.Identity.Name);
            var aux = cad.FiltrarEventoPorUsuario(usuen.ID);

            SessionClose();

            return View(aux);
        }

        //
        // GET: /Evento/Details/5

        public ActionResult Details(int id)
        {
            Evento ev = null;
            SessionInitialize();
            EventoEN evEN = new EventoCAD(session).ReadOIDDefault(id);
            ev = new AssemblerEvento().ConvertENToModelUI(evEN);
            SessionClose();
            return View(ev);
        }

        //
        // GET: /Evento/Create

        public ActionResult Create()
        {
            Evento ev = new Evento();
            ev.Creador = User.Identity.Name;
            return View(ev);
        }

        //
        // POST: /Evento/Create

        [HttpPost]
        public ActionResult Create(Evento ev)
        {            
            try
            {
                EventoCEN cen = new EventoCEN();
                UsuarioCAD cad = new UsuarioCAD(session);
           
                cen.New_(ev.Titulo, ev.Descripcion, ev.Fecha, ev.Precio, cad.FiltrarUsuarioPorNombre(User.Identity.Name).ID);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Evento/Edit/5

        public ActionResult Edit(int id)
        {
            Evento ev = null;
            SessionInitialize();
            EventoEN even = new EventoCAD(session).ReadOIDDefault(id);
            ev = new AssemblerEvento().ConvertENToModelUI(even);
            SessionClose();
            return View(ev);

        }

        //
        // POST: /Evento/Edit/5

        [HttpPost]
        public ActionResult Edit(Evento ev)
        {
            try
            {
                EventoCEN cen = new EventoCEN();
                cen.Modify(ev.id,ev.Titulo,ev.Descripcion,ev.Fecha,ev.Precio);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Evento/Delete/5

        public ActionResult Delete(int id)
        {
            SessionInitialize();
            EventoCAD evCAD = new EventoCAD(session);
            EventoCEN cen = new EventoCEN(evCAD);
            EventoEN evEN = cen.GetID(id);
            Evento ev = new AssemblerEvento().ConvertENToModelUI(evEN);
            SessionClose();


            new EventoCEN().Destroy(id);
            return RedirectToAction("Index");
        }

        //
        // POST: /Evento/Delete/5

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
    }
}
