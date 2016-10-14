using DotNetNote.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotNetNote.Controllers
{
    public class DependencyInjectionDemoController : Controller
    {
        private ICopyrightService _service;
        private ICopyrightService _service2;

        public DependencyInjectionDemoController(
            ICopyrightService service, ICopyrightService service2)
        {
            _service = service;
            _service2 = service2;
        }

        public IActionResult Index()
        {
            ViewBag.Copyright =
                _service.GetCopyrightString() + ", " +
                _service2.GetCopyrightString(); 

            return View();
        }

        public IActionResult About()
        {
            ViewBag.Copyright = _service.GetCopyrightString();

            return View();
        }

        public IActionResult AtInjectDemo()
        {
            return View();
        }

    }
}
