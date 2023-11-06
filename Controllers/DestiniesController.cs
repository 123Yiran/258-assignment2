using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using assignment2.Data;
using assignment2.Models;

namespace assignment2.Controllers
{
    public class DestiniesController : Controller
    {
        private assignment2Context db = new assignment2Context();

        // GET: Destinies
        public ActionResult Index()

        {

            return View(db.Destinies.OrderBy(c => c.Name).ToList());

            //return View(db.Destinies.ToList());
        }
        
        // GET: Destinies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Destiny destiny = db.Destinies.Find(id);
            

            return View(destiny);
        }

        // GET: Destinies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Destinies/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性；有关
        // 更多详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Description,ImagePath")] Destiny destiny)
        {
            if (ModelState.IsValid)
            {
                db.Destinies.Add(destiny);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(destiny);
        }

        // GET: Destinies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Destiny destiny = db.Destinies.Find(id);
            if (destiny == null)
            {
                return HttpNotFound();
            }
            return View(destiny);
        }

        // POST: Destinies/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性；有关
        // 更多详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Description,ImagePath")] Destiny destiny)
        {
            if (ModelState.IsValid)
            {
                db.Entry(destiny).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(destiny);
        }

        // GET: Destinies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Destiny destiny = db.Destinies.Find(id);
            if (destiny == null)
            {
                return HttpNotFound();
            }
            return View(destiny);
        }

        // POST: Destinies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Destiny destiny = db.Destinies.Find(id);
            foreach (var p in destiny.Characters)
            {
                p.DestinyID = null;
            }
            db.Destinies.Remove(destiny);
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
