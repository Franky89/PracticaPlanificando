using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Gestionfuentes.Models;

namespace Gestionfuentes.Controllers
{
    public class FuenteController : Controller
    {
        private FuentesContext db = new FuentesContext();

        // GET: Fuente
        public ActionResult Index()
        {
            return View(db.Fuentes.ToList());
        }

        // GET: Fuente/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fuente fuente = db.Fuentes.Find(id);
            if (fuente == null)
            {
                return HttpNotFound();
            }
            return View(fuente);
        }

        // GET: Fuente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Fuente/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FuenteID,Nombre,temperatura,valoracion")] Fuente fuente)
        {
            if (ModelState.IsValid)
            {
                db.Fuentes.Add(fuente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fuente);
        }

        // GET: Fuente/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fuente fuente = db.Fuentes.Find(id);
            if (fuente == null)
            {
                return HttpNotFound();
            }
            return View(fuente);
        }

        // POST: Fuente/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FuenteID,Nombre,temperatura,valoracion")] Fuente fuente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fuente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fuente);
        }

        // GET: Fuente/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fuente fuente = db.Fuentes.Find(id);
            if (fuente == null)
            {
                return HttpNotFound();
            }
            return View(fuente);
        }

        // POST: Fuente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Fuente fuente = db.Fuentes.Find(id);
            db.Fuentes.Remove(fuente);
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
