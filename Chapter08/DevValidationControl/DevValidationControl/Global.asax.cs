using System;

namespace DevValidationControl
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            //[!] ASP.NET 4.5 이상에서 유효성 검사 컨트롤 사용하기
            //[1] PM> Install-Package jQuery
            //[2] PM> Install-Package AspNet.ScriptManager.jQuery
            //[3] Global.asax - Application_Start()
            System.Web.UI.ValidationSettings.UnobtrusiveValidationMode = 
                System.Web.UI.UnobtrusiveValidationMode.WebForms;
        }
    }
}
