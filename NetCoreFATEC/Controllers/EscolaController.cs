using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreFATEC.Models.Escola;

namespace NetCoreFATEC.Controllers
{
    public class EscolaController : Controller
    {
        // GET: Ensino
        public ActionResult Index()
        {
            IList<Domain.Escola> escolas = new Models.Escola.Escola().RetornaEscolas();

            return View(escolas);
        }

        // GET: Ensino/Details/5
        public ActionResult Details(int id)
        {
            IList<Domain.Escola> escolas = new Models.Escola.Escola().RetornaEscolas();

            Domain.Escola escola = escolas.Where(x => x.Id == id).FirstOrDefault();

            return View(escola);
        }

        // GET: Ensino/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ensino/Create
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

        // GET: Ensino/Edit/5
        public ActionResult Edit(int id)
        {
            IList<Domain.Escola> escolas = new Models.Escola.Escola().RetornaEscolas();

            Domain.Escola escola = escolas.Where(x => x.Id == id).FirstOrDefault();

            return View(escola);
        }

        // POST: Ensino/Edit/5
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

        // GET: Ensino/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Ensino/Delete/5
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