﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoletoBus.Api.Controllers
{
    public class ReservaDetalleController : Controller
    {
        // GET: ReservaDetalleController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ReservaDetalleController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReservaDetalleController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReservaDetalleController/Create
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

        // GET: ReservaDetalleController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReservaDetalleController/Edit/5
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

        // GET: ReservaDetalleController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReservaDetalleController/Delete/5
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