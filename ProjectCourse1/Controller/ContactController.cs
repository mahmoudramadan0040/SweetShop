using Microsoft.AspNetCore.Mvc;

namespace ProjectCourse1.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
