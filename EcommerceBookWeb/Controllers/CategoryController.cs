using EcommerceBookWeb.Data;
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
            //convert the categories to a list and assign to objCategoryList
            var objCategoryList = _db.Categories.ToList();
            return View();
        }
    }
}
