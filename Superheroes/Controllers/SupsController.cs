﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Superheroes.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Superheroes.Controllers
{
    public class SupsController : Controller
    {
        private ApplicationDbContext _context;
        // GET: SupsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SupsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SupsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SupsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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
