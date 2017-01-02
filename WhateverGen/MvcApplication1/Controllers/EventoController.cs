using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;
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
            System.Collections.Generic.IList<EventoEN> eventos = new System.Collections.Generic.List<EventoEN>();
            var aux = cad.ReadAllDefault(0, -1).ToList();
            foreach (EventoEN element in aux)
            {
                if (element.Usuario.Nombre.Equals (User.Identity.Name))
                {
                    eventos.Add(element);
                }
            }
            SessionClose();

            return View(eventos);
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

                cen.New_(ev.Titulo,ev.Descripcion,ev.Fecha,ev.Precio,ev.usuario.ID);
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


            new UsuarioCEN().Destroy(id);
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
