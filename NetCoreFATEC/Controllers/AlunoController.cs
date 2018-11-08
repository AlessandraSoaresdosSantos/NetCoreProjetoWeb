using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreFATEC.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Aluno
        public ActionResult Index()
        {
            IList<Domain.Aluno> alunos = new Models.Aluno.Aluno().RetornaAlunos();

            return View(alunos);
        }

        // GET: Aluno/Details/5
        public ActionResult Details(int id)
        {
            IList<Domain.Aluno> alunos = new Models.Aluno.Aluno().RetornaAlunos();

            Domain.Aluno aluno = alunos.Where(x => x.Id == id).FirstOrDefault();

            return View(aluno);
        }

        // GET: Aluno/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Aluno/Create
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

        // GET: Aluno/Edit/5
        public ActionResult Edit(int id)
        {
            IList<Domain.Aluno> alunos = new Models.Aluno.Aluno().RetornaAlunos();

            Domain.Aluno aluno = alunos.Where(x => x.Id == id).FirstOrDefault();

            return View(aluno);
        }

        // POST: Aluno/Edit/5
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

        // GET: Aluno/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Aluno/Delete/5
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