using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;
using WhateverGenNHibernate.EN.Whatever;


namespace MvcApplication1.Controllers
{
    public class UsuarioController : BasicController
    {
        //
        // GET: /Usuario/

        public ActionResult Index()
        {
            SessionInitialize();
            UsuarioCAD cad = new UsuarioCAD(session);
            var aux = cad.ReadAllDefault(0, -1).ToList();

            SessionClose();
            
            return View(aux);
        }

        //
        // GET: /Usuario/Details/5

        public ActionResult Details(int id)
        {
            Usuario usu = null;
            SessionInitialize();
            UsuarioEN usuEN = new UsuarioCAD(session).ReadOIDDefault(id);
            usu = new AssemblerUsuario().ConvertENToModelUI(usuEN);
            SessionClose();
            return View(usu);
            
        }

        //
        // GET: /Usuario/Create

        public ActionResult Create()
        {
            Usuario usu = new Usuario();
            
            return View(usu);
        }

        //
        // POST: /Usuario/Create

        [HttpPost]
        public ActionResult Create(Usuario usu, HttpPostedFileBase file)
        {
            string fileName = "", path = "";
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
                UsuarioCEN cen = new UsuarioCEN();
                fileName = "/Images/Uploads/" + fileName;
                cen.New_(usu.Nombre,usu.Edad, usu.sexo, usu.Facebook, usu.Instagram, usu.Twitter, usu.Contrasena, usu.Email, fileName);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Usuario/Edit/5

        public ActionResult Edit(int id)
        {
            Usuario usu = null;
            SessionInitialize();
            UsuarioEN usuen = new UsuarioCAD(session).ReadOIDDefault(id);
            usu = new AssemblerUsuario().ConvertENToModelUI(usuen);
            SessionClose();
            return View(usu);
        }

        //
        // POST: /Usuario/Edit/5

        [HttpPost]
        public ActionResult Edit(Usuario usu)
        {
            try
            {
                UsuarioCEN cen = new UsuarioCEN();
                cen.Modify(usu.id, usu.Nombre, usu.Edad, usu.sexo, usu.Facebook, usu.Instagram, usu.Twitter, usu.Contrasena, usu.Email, usu.Foto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Usuario/Delete/5

        public ActionResult Delete(int id)
        {
            SessionInitialize();
            UsuarioCAD usuCAD = new UsuarioCAD(session);
            UsuarioCEN cen = new UsuarioCEN(usuCAD);
            UsuarioEN usuEN = cen.GetID(id);
            Usuario usu = new AssemblerUsuario().ConvertENToModelUI(usuEN);
            SessionClose();
            

            new UsuarioCEN().Destroy(id);
            return RedirectToAction("Index");

        }

        //
        // POST: /Usuario/Delete/5

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
