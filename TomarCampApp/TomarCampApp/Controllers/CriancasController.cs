using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TomarCampApp.Models;

namespace TomarCampApp.Controllers
{
    public class CriancasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Criancas
        public ActionResult Index()
        {
            var criancas = db.Criancas.Include(c => c.Pai);
            return View(criancas.ToList());
        }

        // GET: Criancas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Criancas criancas = db.Criancas.Find(id);
            if (criancas == null)
            {
                return HttpNotFound();
            }
            return View(criancas);
        }

        // GET: Criancas/Create/5
        public ActionResult Create(int ? id)
        {
            ViewBag.PaiFK = new SelectList(db.Pais, "ID", "Nome", id);
            return View();
        }

        // POST: Criancas/Create/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nome,Idade,Doencas,NumCC,NIF,PaiFK")] Criancas criancas)
        {
            if (ModelState.IsValid)
            {
                db.Criancas.Add(criancas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PaiFK = new SelectList(db.Pais, "ID", "Nome", criancas.PaiFK);
            return View(criancas);
        }

        // GET: Criancas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Criancas criancas = db.Criancas.Find(id);
            if (criancas == null)
            {
                return HttpNotFound();
            }
            ViewBag.PaiFK = new SelectList(db.Pais, "ID", "Nome", criancas.PaiFK);
            return View(criancas);
        }

        // POST: Criancas/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nome,Idade,Doencas,NumCC,NIF,PaiFK")] Criancas criancas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(criancas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PaiFK = new SelectList(db.Pais, "ID", "Nome", criancas.PaiFK);
            return View(criancas);
        }

        // GET: Criancas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Criancas criancas = db.Criancas.Find(id);
            if (criancas == null)
            {
                return HttpNotFound();
            }
            return View(criancas);
        }

        // POST: Criancas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Criancas criancas = db.Criancas.Find(id);
            db.Criancas.Remove(criancas);
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
