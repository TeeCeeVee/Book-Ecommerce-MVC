using Microsoft.AspNetCore.Mvc;

namespace EcommerceBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
