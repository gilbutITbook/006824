using DotNetNote.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace DotNetNote.Controllers
{
    /// <summary>
    /// 명언(Maxim) 제공 서비스: /api/maximservice/
    /// 기본 뼈대 만드는 것은 Web API 스캐폴딩으로 구현 후 각각의 코드를 구현
    /// </summary>
    [Route("api/[controller]")]
    public class MaximServiceController : Controller
    {
        private MaximServiceRepository repo;

        public MaximServiceController(MaximServiceRepository maximService)
        {
            repo = maximService;
        }

        // GET: api/MaximService
        [HttpGet("")]
        public IEnumerable<Maxim> Get()
        {
            return repo.GetMaxims().AsEnumerable();
        }

        // GET: api/MaximService/5
        [HttpGet("{id}", Name = "GetMaxim")]
        public Maxim GetById(int id)
        {
            // 데이터 조회
            Maxim maxim = repo.GetMaximById(id);
            if (maxim == null)
            {
                Response.StatusCode = (int)HttpStatusCode.NotFound;
                return null;
            }
            return maxim;
        }

        // POST: api/MaximService
        [HttpPost]
        public JsonResult Post([FromBody]Maxim maxim)
        {
            if (ModelState.IsValid)
            {
                // 데이터 입력
                repo.AddMaxim(maxim);

                Response.StatusCode = (int)HttpStatusCode.Created;
                return Json(maxim);
            }
            else
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json(new { Message = "실패", ModelState = ModelState });
            }
        }

        // PUT: api/MaximService/5
        [HttpPut("{id}")]
        public JsonResult Put(int id, [FromBody]Maxim maxim)
        {
            if (!ModelState.IsValid)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json(new { Message = "실패", ModelState = ModelState });
            }
            if (id != maxim.Id)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json(new { Message = "실패", ModelState = ModelState });
            }

            try
            {
                // 데이터 수정
                repo.UpdateMaxim(maxim);
            }
            catch (Exception ex)
            {
                Response.StatusCode = (int)HttpStatusCode.NotFound;
                return Json(
                    new {Message = $"실패: {ex}", ModelState = ModelState });
            }
            Response.StatusCode = (int)HttpStatusCode.OK;
            return Json(maxim);

        }

        // DELETE: api/MaximService/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            Maxim maxim = repo.GetMaximById(id);
            if (maxim == null)
            {
                Response.StatusCode = (int)HttpStatusCode.NotFound;
                return Json(new { Message = "실패", ModelState = ModelState });
            }

            try
            {
                // 데이터 삭제
                repo.RemoveMaxim(id);
            }
            catch (Exception ex)
            {
                Response.StatusCode = (int)HttpStatusCode.NotFound;
                return Json(
                    new { Message = $"실패: {ex}", ModelState = ModelState });
            }
            Response.StatusCode = (int)HttpStatusCode.OK;
            return Json(maxim);
        }
    }
}
