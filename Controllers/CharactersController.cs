using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using assignment2.Data;
using assignment2.Models;
using assignment2.ViewModels;
using PagedList;

namespace assignment2.Controllers
{
    public class CharactersController : Controller
    {
        private assignment2Context db = new assignment2Context();

        // GET: Characters
        public ActionResult Index(string destiny, string search, string sortBy,int? page)
        {
            CharacterIndexViewModel viewModel = new CharacterIndexViewModel();
            var characters = db.Characters.Include(c => c.Destiny);
           
            if (!String.IsNullOrEmpty(search))
            {
                characters = characters.Where(p =>
                p.Name.Contains(search) ||
                p.Description.Contains(search) ||
                p.Attribute.Contains(search)||
                p.Faction.Contains(search)||
                p.Destiny.Name.Contains(search)
                );
                
                viewModel.Search = search;
                //ViewBag.Search = search;
            }
            viewModel.CatsWithCount = from matchingCharacters in characters
                                      where
                                      matchingCharacters.DestinyID != null
                                      group matchingCharacters by
                                      matchingCharacters.Destiny.Name into
                                      catGroup
                                      select new DestinyWithCount()
                                      {
                                          DestinyName = catGroup.Key,
                                          DestinyCount = catGroup.Count()
                                      };
           
            if (!String.IsNullOrEmpty(destiny))
            {
                characters = characters.Where(p => p.Destiny.Name == destiny);
                viewModel.Destiny=destiny;

            }
            //sort the results
            switch (sortBy)
            {
                case "Age_lowest":
                    characters = characters.OrderBy(p => p.Age);
                    break;
                case "Age_highest":
                    characters = characters.OrderByDescending(p => p.Age);
                    break;
                default:
                    characters = characters.OrderBy(p => p.Name); 

                    //characters = characters.OrderBy(p => p.Name);
                    break;
            }
            viewModel.Sorts = new Dictionary<string, string>
             {
                 {"Age low to high", "Age_lowest" },
                 {"Age high to low", "Age_highest" }
             };

            //viewModel.Characters = characters;
            viewModel.SortBy = sortBy;
            const int PageItems = 3;
            int currentPage = (page ?? 1);
            viewModel.Characters = characters.ToPagedList(currentPage, PageItems);

            //ViewBag.Destiny = new SelectList(destinies);
            return View(viewModel);
        }

        // GET: Characters/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Character character = db.Characters.Find(id);
            if (character == null)
            {
                return HttpNotFound();
            }
            return View(character);
        }

        // GET: Characters/Create
        public ActionResult Create()
        {
            ViewBag.DestinyID = new SelectList(db.Destinies, "ID", "Name", "Faction", "Attribute", "ImagePath");
            return View();
        }

        // POST: Characters/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性；有关
        // 更多详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Age,Description,Faction,Attribute,ImagePath,DestinyID")] Character character)
        {
            if (ModelState.IsValid)
            {
                db.Characters.Add(character);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DestinyID = new SelectList(db.Destinies, "ID", "Name", character.DestinyID);
            return View(character);
        }

        // GET: Characters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Character character = db.Characters.Find(id);
            if (character == null)
            {
                return HttpNotFound();
            }
            ViewBag.DestinyID = new SelectList(db.Destinies, "ID", "Name", character.DestinyID);
            return View(character);
        }

        // POST: Characters/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性；有关
        // 更多详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Age,Description,Faction,Attribute,ImagePath,DestinyID")] Character character)
        {
            if (ModelState.IsValid)
            {
                db.Entry(character).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DestinyID = new SelectList(db.Destinies, "ID", "Name", character.DestinyID);
            return View(character);
        }

        // GET: Characters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Character character = db.Characters.Find(id);
            if (character == null)
            {
                return HttpNotFound();
            }
            return View(character);
        }

        // POST: Characters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Character character = db.Characters.Find(id);
            db.Characters.Remove(character);
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
