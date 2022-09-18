using EcommerceBookWeb.Data;
using EcommerceBookWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        //connects the controller to database
        //member variable
        //AppDbContext is a data type
        private readonly AppDbContext _db;

        public CategoryController(AppDbContext db)
        {
            //use _db to retrieve categories
            _db = db;
        }

        public IActionResult Index()
        {
           IEnumerable<Category> objCategoryList = _db.Categories;
            return View(objCategoryList);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {
            //custom validation
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The display order cannot match the Name.");
            }
            //create validation
            if (ModelState.IsValid)
            {
                //create record inside database
                _db.Categories.Add(obj);
                _db.SaveChanges(); // saves and goes to database
                return RedirectToAction("Index");
            }
            return View(obj);

        }


    }
}
