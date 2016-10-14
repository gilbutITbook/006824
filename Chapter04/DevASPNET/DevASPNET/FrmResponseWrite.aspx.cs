using System;

namespace DevASPNET
{
    public partial class FrmResponseWrite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("안녕하세요.<br />");
        }
        protected void btnClick_Click(object sender, EventArgs e)
        {
            Response.Write(
                "<span style='color:blue;'>반갑습니다.</span><br />");
        }
        protected void btnJavaScript_Click(object sender, EventArgs e)
        {
            string strJs = @"
            <script language='JavaScript'>
            window.alert('안녕');
            </script>    
            ";
            Response.Write(strJs);
        }
    }
}