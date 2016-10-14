using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DotNetNote.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class WebApiTestWithAuthorizeController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] {
                "[Authorize] 특성을 적용하면,"
                , "인증되지 않았을 때 로그인 페이지로 이동합니다." };
        }
    }
}
