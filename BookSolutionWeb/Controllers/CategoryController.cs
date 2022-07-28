using Microsoft.AspNetCore.Mvc;

namespace BookSolutionWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
