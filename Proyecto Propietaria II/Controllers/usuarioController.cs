using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Proyecto_Propietaria_II.Models;

namespace Proyecto_Propietaria_II.Controllers
{
    public class usuarioController : Controller
    {
        private BankingEntities db = new BankingEntities();

        // GET: usuario
        public ActionResult Index()
        {
            var uSUARIO = db.USUARIO.Include(u => u.DIRECCION);
            return View(uSUARIO.ToList());
        }

        // GET: usuario/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            USUARIO uSUARIO = db.USUARIO.Find(id);
            if (uSUARIO == null)
            {
                return HttpNotFound();
            }
            return View(uSUARIO);
        }

        // GET: usuario/Create
        public ActionResult Create()
        {
            ViewBag.Cedula_usuario = new SelectList(db.DIRECCION, "Cedula", "NombreCalle_direccion");
            return View();
        }

        // POST: usuario/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Cedula_usuario,Nombre_Completo,FechaNacimiento_usuario,Usuario1,Password")] USUARIO uSUARIO)
        {
            if (ModelState.IsValid)
            {
                db.USUARIO.Add(uSUARIO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Cedula_usuario = new SelectList(db.DIRECCION, "Cedula", "NombreCalle_direccion", uSUARIO.Cedula_usuario);
            return View(uSUARIO);
        }

        // GET: usuario/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            USUARIO uSUARIO = db.USUARIO.Find(id);
            if (uSUARIO == null)
            {
                return HttpNotFound();
            }
            ViewBag.Cedula_usuario = new SelectList(db.DIRECCION, "Cedula", "NombreCalle_direccion", uSUARIO.Cedula_usuario);
            return View(uSUARIO);
        }

        // POST: usuario/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Cedula_usuario,Nombre_Completo,FechaNacimiento_usuario,Usuario1,Password")] USUARIO uSUARIO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(uSUARIO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Cedula_usuario = new SelectList(db.DIRECCION, "Cedula", "NombreCalle_direccion", uSUARIO.Cedula_usuario);
            return View(uSUARIO);
        }

        // GET: usuario/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            USUARIO uSUARIO = db.USUARIO.Find(id);
            if (uSUARIO == null)
            {
                return HttpNotFound();
            }
            return View(uSUARIO);
        }

        // POST: usuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            USUARIO uSUARIO = db.USUARIO.Find(id);
            db.USUARIO.Remove(uSUARIO);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
