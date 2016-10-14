using MemoEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MemoEngine.Controllers
{
    /// <summary>
    /// 명언(Maxim) 제공 서비스: /api/maximservice/
    /// 기본 뼈대 만드는 것은 Web API 스캐폴딩으로 구현 후 각각의 코드를 구현
    /// </summary>
    public class MaximServiceController : ApiController
    {
        MaximServiceRepository repo = new MaximServiceRepository();

        // GET: api/MaximService
        public IEnumerable<Maxim> Get()
        {
            return repo.GetMaxims().AsEnumerable();
        }

        // GET: api/MaximService/5
        public Maxim Get(int id)
        {
            // 데이터 조회
            Maxim maxim = repo.GetMaximById(id);
            if (maxim == null)
            {
                throw new HttpResponseException(
                    Request.CreateResponse(HttpStatusCode.NotFound));
            }
            return maxim;
        }

        // POST: api/MaximService
        public HttpResponseMessage Post([FromBody]Maxim maxim)
        {
            if (ModelState.IsValid)
            {
                // 데이터 입력
                repo.AddMaxim(maxim);

                HttpResponseMessage response =
                    Request.CreateResponse(HttpStatusCode.Created, maxim);
                response.Headers.Location =
                    new Uri(Url.Link("DefaultApi", new { id = maxim.Id }));
                return response;
            }
            else
            {
                return Request.CreateErrorResponse(
                    HttpStatusCode.BadRequest, ModelState);
            }
        }

        // PUT: api/MaximService/5
        public HttpResponseMessage Put(int id, [FromBody]Maxim maxim)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(
                    HttpStatusCode.BadRequest, ModelState);
            }
            if (id != maxim.Id)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            // 데이터 수정
            repo.UpdateMaxim(maxim);

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // DELETE: api/MaximService/5
        public HttpResponseMessage Delete(int id)
        {
            Maxim maxim = repo.GetMaximById(id);
            if (maxim == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            // 데이터 삭제
            repo.RemoveMaxim(id);

            return Request.CreateResponse(HttpStatusCode.OK, maxim);
        }
    }
}
