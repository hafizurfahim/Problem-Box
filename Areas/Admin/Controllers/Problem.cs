using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Problem_Box.Data;

namespace Problem_Box.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class Problem : Controller
    {
        public ApplicationDbContext _db;
        public Problem(ApplicationDbContext db){
            _db = db;
            
}
        public IActionResult Index()
        {
            return View(_db.problems.Include(c=>c.problemCatagory).ToList());
        }
    }
}
