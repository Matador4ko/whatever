using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CP.Whatever;
using MvcApplication1.Models;
using System.IO;


namespace MvcApplication1.Controllers
{
    public class ReporteController : BasicController
    {
        //
        // GET: /Reporte/

        public ActionResult Index()
        {
            ReporteCEN cen = new ReporteCEN();
            IEnumerable<ReporteEN> list = null;
            SessionInitialize();
            list = cen.GetAll(0, 0).ToList();
            SessionClose();
            return View(list);
        }

        //
        // GET: /Reporte/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Reporte/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Reporte/Create

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
        // GET: /Reporte/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Reporte/Edit/5

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
        // GET: /Reporte/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Reporte/Delete/5

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
