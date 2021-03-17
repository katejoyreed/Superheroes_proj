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
        public ActionResult Details()
        {
            var supsDetails = _context.Sups.ToList();
            foreach  (Sup sup in supsDetails)
            {
                Console.WriteLine(sup.Name, sup.AlterEgo, sup.PrimaryAbility, sup.SecondaryAbility, sup.Catchphrase);
            }
            return View(supsDetails);
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
            try
            {

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SupsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SupsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SupsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SupsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
