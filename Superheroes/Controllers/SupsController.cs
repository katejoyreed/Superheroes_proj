using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Superheroes.Data;
using Superheroes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Superheroes.Controllers
{
    public class SupsController : Controller
    {
        private ApplicationDbContext _context;
        public SupsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SupsController
        public ActionResult Index()
        {
            var allSups = _context.Sups;
            return View(allSups);
        }

        // GET: SupsController/Details/5
        public ActionResult Details(int ID)
        {
            Sup sup = _context.Sups.Find(ID);
            return View(sup);
        }

        // GET: SupsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SupsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Sup sups)
        {
            _context.Sups.Add(sups);
            _context.SaveChanges();

                return RedirectToAction("Index");
            
            
        }

        // GET: SupsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SupsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Sup sup)
        {
            var editSup = _context.Sups.Where(x => x.ID == sup.ID).FirstOrDefault();
            _context.Sups.Remove(editSup);
            _context.Sups.Add(sup);
            _context.SaveChanges();
                return RedirectToAction("Index");
            
            
        }

        // GET: SupsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SupsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Sup sup)
        {
            var supToDelete = _context.Sups.Where(x => x.ID == sup.ID).FirstOrDefault();
            _context.Sups.Remove(supToDelete);
            _context.SaveChanges();
            
                return RedirectToAction("Index");
            
        }
    }
}
