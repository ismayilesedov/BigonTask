
using BigonTask.areas.Admin.Models;
using BigonTask.Models.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace BigonTask.areas.Admin.Controllers
{
    [Area("Admin")]
    public class ColorsController : Controller
    {
        private readonly DataContext db;

        public ColorsController(DataContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
           var colors= db.Colors.ToList();
            return View(colors);
        }
        public IActionResult Details(int Id)
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Color model)
        {
            return View();
        }
    
        public IActionResult Edit(int Id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Edit(Color model)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Delete(int Id)
        {
            return View();
        }
      
     }
}
