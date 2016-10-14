using System.Collections.Generic;
using System.Web.Http;

namespace DevWebAPI.Controllers
{
    public class HelloWorldController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "안녕하세요.", "반갑습니다." };
        }
    }
}

