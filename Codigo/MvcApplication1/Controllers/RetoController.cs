﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class RetoController : BasicController
    {
        //
        // GET: /Reto/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Reto/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Reto/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Reto/Create

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
        // GET: /Reto/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Reto/Edit/5

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
        // GET: /Reto/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Reto/Delete/5

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
