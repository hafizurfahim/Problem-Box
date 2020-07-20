using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Problem_Box.Data;
using Problem_Box.Models;


namespace Problem_Box.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProblemCatagories : Controller
    {
        private ApplicationDbContext _db;
        public ProblemCatagories(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.problemCatagories.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProblemCatagory problems)
        {
            if (ModelState.IsValid)
            {
                _db.problemCatagories.Add(problems);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }

            return View(problems);

        }

        public IActionResult Edit(int?id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var catagoryId = _db.problemCatagories.Find(id);
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProblemCatagory problems)
        {
            if (ModelState.IsValid)
            {
                _db.problemCatagories.Update (problems);
                await _db.SaveChangesAsync();

            }

            return View(problems);

        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var catagoryId = _db.problemCatagories.Find(id);
            return View();
        }

    }
}
