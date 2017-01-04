﻿using MvcApplication1.Models;
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
    public class PasoController : BasicController
    {
        //
        // GET: /Paso/

        public ActionResult Index(int id)
        {
            SessionInitialize();
            PasoCAD cad = new PasoCAD(session);
            var aux = cad.FiltrarPasoPorGymkana(id);
             
            SessionClose();

            return View(aux);
        }

        //
        // GET: /Paso/Details/5

        public ActionResult Details(int id)
        {
            Paso pas = null;
            SessionInitialize();
            PasoEN pasEN = new PasoCAD(session).ReadOIDDefault(id);
            pas = new AssemblerPaso().ConvertENToModelUI(pasEN);
            SessionClose();
            return View(pas);
        }

        //
        // GET: /Paso/Create

        public ActionResult Create(int id)
        {
            SessionInitialize();

            Paso pas = new Paso();

            pas.idGymkana = id;
            pas.Numero = new GymkanaCAD().GetID(id).NumPasos + 1;
            
            SessionClose();
            return View(pas);
        }

        //
        // POST: /Paso/Create

        [HttpPost]
        public ActionResult Create(Paso pas)
        {
            try
            {
                UsuarioCAD cad = new UsuarioCAD();
                GymkanaCP cp = new GymkanaCP();
                GymkanaCAD gymcad = new GymkanaCAD();
                PasoEN en = new PasoEN();
                MapaEN mapen = new MapaEN();
                GymkanaEN gymen = gymcad.GetID(pas.id);
                mapen.Latitud=pas.Latitud;
                mapen.Longitud=pas.Longitud;
                mapen.Zoom=pas.Zoom;
                
                en.Descripcion = pas.Descripcion;

                cp.AnadirPaso(en, mapen, gymcad.GetID(pas.id));
                return RedirectToAction("Index", new { id = pas.id });
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Paso/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Paso/Edit/5

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
        // GET: /Paso/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Paso/Delete/5

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
