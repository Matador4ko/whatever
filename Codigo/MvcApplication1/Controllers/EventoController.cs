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
            var aux = cad.ReadAllDefault(0, -1).ToList();
           
            SessionClose();

            return View(aux);
        }

        //
        // GET: /Evento/Details/5

        public ActionResult Details(int id)
        {   
            SessionInitialize();
            EventoCEN evcen = new EventoCEN();
            EventoEN even = new EventoEN();
            EventoEN even2 = new EventoEN();

            even = new EventoCAD(session).ReadOIDDefault(id);
            even2 = evcen.VerEvento(even.ID);
            SessionClose();
            return View(even2);
        }

        //
        // GET: /Evento/Create

        public ActionResult Create()
        {
            SessionInitialize();
            EventoCAD eve = new EventoCAD(session);
            EventoEN even = new EventoEN();
            eve.New_(even);
            SessionClose();
            return View();
        }

        //
        // POST: /Evento/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

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
            return View();
        }

        //
        // POST: /Evento/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

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
            return View();
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
