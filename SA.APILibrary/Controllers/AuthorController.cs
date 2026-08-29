using Microsoft.AspNetCore.Mvc;

namespace SA.APILibrary.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
