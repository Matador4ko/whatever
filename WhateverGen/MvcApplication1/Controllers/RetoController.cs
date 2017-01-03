﻿using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;
using WhateverGenNHibernate.CP.Whatever;
using WhateverGenNHibernate.EN.Whatever;


namespace MvcApplication1.Controllers
{
    public class RetoController : BasicController
    {
        //
        // GET: /Reto/

        public ActionResult Index()
        {
            SessionInitialize();
            RetoCAD cad = new RetoCAD(session);
            var aux = cad.GetAll(0, 0);
            

            return View(aux);

        }

        //
        // GET: /Reto/Details/5

        public ActionResult Details(int id)
        {
            Reto ret = null;
            SessionInitialize();
            RetoEN retEN = new RetoCAD(session).ReadOIDDefault(id);
            ret = new AssemblerReto().ConvertENToModelUI(retEN);
            SessionClose();
            return View(ret);
        }

        //
        // GET: /Reto/Create

        public ActionResult Create()
        {
            Reto ret = new Reto();
            ret.Creador = User.Identity.Name;
            return View(ret);
        }

        //
        // POST: /Reto/Create

        [HttpPost]
        public ActionResult Create(Reto ret, HttpPostedFileBase file)
        {

            string fileName = "", path = "";
            // Verify that the user selected a file
            if (file != null && file.ContentLength > 0)
            {
                // extract only the fielname
                fileName = Path.GetFileName(file.FileName);
                // store the file inside ~/App_Data/uploads folder
                path = Path.Combine(Server.MapPath("~/Images/Uploads"), fileName);
                //string pathDef = path.Replace(@"\\", @"\");
                file.SaveAs(path);
            }
        

            try
            {
                RetoCEN cen = new RetoCEN();
                UsuarioCAD cad = new UsuarioCAD(session);
                RetoEN reten = new RetoEN();
                reten.Descripcion = ret.Descripcion;
                fileName = "/Images/Uploads/" + fileName;
                reten.Imagen = fileName;
                reten.Precio = ret.Precio;
                reten.Tipo = ret.Tipo;
                reten.Titulo = ret.Titulo;
                reten.Usuario = cad.FiltrarUsuarioPorNombre(User.Identity.Name);
                cen.New_(reten.Titulo, reten.Descripcion, reten.Tipo, reten.Precio, reten.Imagen, reten.Usuario.ID);
                //cen.CrearReto(reten);

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
            Reto ret = null;
            SessionInitialize();
            RetoEN reten = new RetoCAD(session).ReadOIDDefault(id);
            ret = new AssemblerReto().ConvertENToModelUI(reten);
            SessionClose();
            return View(ret);
        }

        //
        // POST: /Reto/Edit/5

        [HttpPost]
        public ActionResult Edit(Reto ret, HttpPostedFileBase file)
        {
            string fileName = "", path = "";
            // Verify that the user selected a file
            if (file != null && file.ContentLength > 0)
            {
                // extract only the fielname
                fileName = Path.GetFileName(file.FileName);
                // store the file inside ~/App_Data/uploads folder
                path = Path.Combine(Server.MapPath("~/Images/Uploads"), fileName);
                //string pathDef = path.Replace(@"\\", @"\");
                file.SaveAs(path);
            }
            
            try
            {
                RetoCEN cen = new RetoCEN();
                RetoEN reten = new RetoEN();
                reten.ID = ret.id;
                reten.Descripcion = ret.Descripcion;
                reten.Imagen = ret.Imagen;
                fileName = "/Images/Uploads/" + fileName;
                if (ret.Imagen != fileName && fileName != "/Images/Uploads/")
                {
                    reten.Imagen = fileName;
                }
                else
                {
                reten.Imagen = ret.Imagen;
                }
                reten.Precio = ret.Precio;
                reten.Tipo = ret.Tipo;
                reten.Titulo = ret.Titulo;
                reten.Usuario = ret.usuario;
                
                
                cen.ModificarReto(reten);
;               return RedirectToAction("Index");
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
            Reto ret = null;
            SessionInitialize();
            RetoEN reten = new RetoCAD(session).ReadOIDDefault(id);
            ret = new AssemblerReto().ConvertENToModelUI(reten);
            SessionClose();
            return View(ret);
        }

        //
        // POST: /Reto/Delete/5

        [HttpPost]
        public ActionResult Delete(Reto ret)
        {
            try
            {
                SessionInitialize();
                RetoCP cp = new RetoCP(session);
                cp.BorrarReto(ret.id);
                SessionClose();



                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Reto/List

        public ActionResult List()
        {
            SessionInitialize();
            RetoCAD cad = new RetoCAD(session);
            UsuarioCAD usucad = new UsuarioCAD(session);
            UsuarioEN usuen = usucad.FiltrarUsuarioPorNombre(User.Identity.Name);
            var aux = cad.FiltrarRetoPorUsuario(usuen.ID);


            return View(aux);

        }
    }
}