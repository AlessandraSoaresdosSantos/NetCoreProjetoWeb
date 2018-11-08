using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreFATEC.Controllers
{
    public class ProfessorController : Controller
    {
        // GET: Professor
        public ActionResult Index()
        {
            IList<Domain.Professor> professores = new Models.Professor.Professor().RetornaProfessores();

            return View(professores);
        }

        // GET: Professor/Details/5
        public ActionResult Details(int id)
        {
            IList<Domain.Professor> professores = new Models.Professor.Professor().RetornaProfessores();

            Domain.Professor professor = professores.Where(x => x.Id == id).FirstOrDefault();

            return View(professor);
        }

        // GET: Professor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Professor/Create
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

        // GET: Professor/Edit/5
        public ActionResult Edit(int id)
        {
            IList<Domain.Professor> professores = new Models.Professor.Professor().RetornaProfessores();

            Domain.Professor professor = professores.Where(x => x.Id == id).FirstOrDefault();

            return View(professor);
        }

        // POST: Professor/Edit/5
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

        // GET: Professor/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Professor/Delete/5
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