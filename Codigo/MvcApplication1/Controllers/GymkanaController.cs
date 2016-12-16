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
    public class GymkanaController : BasicController
    {
        //
        // GET: /Gymkana/

        public ActionResult Index()
        {
            SessionInitialize();
            GymkanaCEN gymcen = new GymkanaCEN();
            IEnumerable<GymkanaEN> list = gymcen.GetAll(0, -1).ToList();
            SessionClose();

            return View();
        }

        //
        // GET: /Gymkana/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Gymkana/Create

        public ActionResult Create()
        {
            SessionInitialize();
            GymkanaCAD gym = new GymkanaCAD();
            GymkanaEN gymen = new GymkanaEN();
            gym.New_(gymen);
            SessionClose();
            return View();
        }

        //
        // POST: /Gymkana/Create

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
        // GET: /Gymkana/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Gymkana/Edit/5

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
        // GET: /Gymkana/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
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
    }
}
