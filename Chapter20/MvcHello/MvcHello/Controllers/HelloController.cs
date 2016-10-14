using System.Web.Mvc;

namespace MvcHello.Controllers
{
    // 컨트롤러: 클래스
    public class HelloController : Controller
    {
        // 액션메서드: 메서드
        // GET: Hello
        public string Index()
        {
            return "<em>안녕하세요. MVC 프로젝트!!!!</em>";
        }
    }
}

