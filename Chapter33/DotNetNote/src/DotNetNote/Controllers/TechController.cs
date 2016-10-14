using Microsoft.AspNetCore.Mvc;

namespace DotNetNote.Controllers
{
    public class TechController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
