using System;

namespace DevASPNET
{
    public partial class FrmServerMapPath : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //현재 웹 폼의 서버측의 물리적 경로
            this.Label1.Text = Server.MapPath("."); // 같은 경로
            //현재 스크립트 파일의 루트 경로
            this.Label2.Text =
                Request.ServerVariables["SCRIPT_NAME"];
        }
    }
}