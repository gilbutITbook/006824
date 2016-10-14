using System.Collections.Generic;
using System.Web.Http;

namespace DevWebAPI.Controllers
{
    public class DefaultController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "안녕하세요.", "반갑습니다." };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "입력한 값: " + id.ToString();
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}