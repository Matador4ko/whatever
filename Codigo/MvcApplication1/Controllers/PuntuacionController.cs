﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;
using WhateverGenNHibernate.EN.Whatever;
using MvcApplication1.Models;
using System.IO;

namespace MvcApplication1.Controllers
{
    public class PuntuacionController : BasicController
    {
        //
        // GET: /Puntuacion/

        public ActionResult Index()
        {   

            return View();
        }

        //
        // GET: /Puntuacion/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Puntuacion/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Puntuacion/Create

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
        // GET: /Puntuacion/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Puntuacion/Edit/5

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
        // GET: /Puntuacion/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Puntuacion/Delete/5

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
