using System;
using System.Web;

namespace DevCaching
{
    public partial class FrmCachingResponseCache : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 코드 기반으로 캐싱 기능 적용하기

            // 현재 날짜 출력
            Response.Write(DateTime.Now.ToString());

            // 캐싱 설정
            Response.Cache.SetCacheability(HttpCacheability.Public);

            // 캐싱 유효기간 설정
            Response.Cache.SetExpires(DateTime.Now.AddSeconds(60));

            // 매개 변수 방식 지정
            Response.Cache.VaryByParams["*"] = true; 
        }
    }
}