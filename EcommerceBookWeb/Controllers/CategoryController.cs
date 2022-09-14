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
    }
}
