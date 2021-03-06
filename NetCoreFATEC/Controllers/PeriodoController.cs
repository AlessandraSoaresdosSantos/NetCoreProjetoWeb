﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreFATEC.Controllers
{
    public class PeriodoController : Controller
    {
        // GET: Periodo
        public ActionResult Index()
        {
            IList<Domain.Periodo> periodos = new Models.Periodo.Periodo().RetornaPeriodos();

            return View(periodos);
        }

        // GET: Periodo/Details/5
        public ActionResult Details(int id)
        {
            IList<Domain.Periodo> periodos = new Models.Periodo.Periodo().RetornaPeriodos();

            Domain.Periodo periodo = periodos.Where(x => x.Id == id).FirstOrDefault();

            return View(periodo);
        }

        // GET: Periodo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Periodo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Periodo/Edit/5
        public ActionResult Edit(int id)
        {
            IList<Domain.Periodo> periodos = new Models.Periodo.Periodo().RetornaPeriodos();

            Domain.Periodo periodo = periodos.Where(x => x.Id == id).FirstOrDefault();

            return View(periodo);
        }

        // POST: Periodo/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Periodo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Periodo/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}