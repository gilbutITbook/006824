using DotNetNote.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DotNetNote.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Content() 반환값
        /// </summary>
        /// <returns></returns>
        public IActionResult ContentResultDemo()
        {
            return Content("ContentResult 반환값");
        }

        public IActionResult ObjectResultDemo()
        {
            DemoModel dm = new DemoModel() { Id = 1, Name = "홍길동" };
            return new ObjectResult(dm);
        }

        public IActionResult TempDataDemoStart()
        {
            TempData["Message"] = "TempDataDemoStart에서 만들어진 문자열";

            return View("TempDataDemo");
        }

        public IActionResult TempDataDemo()
        {
            return View();
        }

        public IActionResult JsonResultDemo()
        {
            return Json(new { Foo = "Bar" });
        }

        public string SendMailDemo()
        {
            return "전송 완료";
        }

        public IActionResult EnvironmentAndFramework()
        {
            return View();
        }
    }
}
