﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoletoBus.Api.Controllers
{
    public class ViajeController : Controller
    {
        // GET: ViajeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ViajeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ViajeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ViajeController/Create
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

        // GET: ViajeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ViajeController/Edit/5
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

        // GET: ViajeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ViajeController/Delete/5
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
