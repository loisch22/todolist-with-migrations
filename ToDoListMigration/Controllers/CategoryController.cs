using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ToDoListWithMigrations.Models;

namespace ToDoListWithMigrations.Controllers
{
    public class CategoryController : Controller
    {
        private ToDoDbContext db = new ToDoDbContext();

        public IActionResult Index()
        {
            return View(db.Categories.Include(category => category.Items).ToList());
        }

        public IActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.Categories, "CategoryId", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
