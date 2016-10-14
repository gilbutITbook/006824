using System.Web.Http;

namespace MemoEngine
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 구성 및 서비스

            // [!] Web API에서 JSON 값을 반환시 
            //    파스칼 케이스가 아닌 카멜 케이스로 표현하기 위한 방법
            // [a] 표현 방법 1
            // var formatter = 
            //    GlobalConfiguration.Configuration.Formatters.JsonFormatter;
            // formatter.SerializerSettings.ContractResolver = new Newtonsoft
            //    .Json.Serialization.CamelCasePropertyNamesContractResolver();
            // [b] 표현 방법 2 
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver =
                new Newtonsoft.Json.Serialization.
                    CamelCasePropertyNamesContractResolver();

            // Web API 경로
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
