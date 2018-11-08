using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreFATEC.Controllers
{
    public class TurmaController : Controller
    {
        // GET: Turma
        public ActionResult Index()
        {
            IList<Domain.Turma> turmas = new Models.Turma.Turma().RetornaTurmas();

            return View(turmas);
        }

        // GET: Turma/Details/5
        public ActionResult Details(int id)
        {
            IList<Domain.Turma> turmas = new Models.Turma.Turma().RetornaTurmas();

            Domain.Turma turma = turmas.Where(x => x.Id == id).FirstOrDefault();

            return View(turma);
        }

        // GET: Turma/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Turma/Create
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

        // GET: Turma/Edit/5
        public ActionResult Edit(int id)
        {
            IList<Domain.Turma> turmas = new Models.Turma.Turma().RetornaTurmas();

            Domain.Turma turma = turmas.Where(x => x.Id == id).FirstOrDefault();

            return View(turma);
        }

        // POST: Turma/Edit/5
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

        // GET: Turma/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Turma/Delete/5
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