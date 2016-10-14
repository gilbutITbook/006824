using System;
using System.Web.UI;

namespace DevStandardControl
{
    public partial class FrmHiddenField : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // 히든필드는 눈에 보이지 않게 어떤 값을 임시로 저장할 때 사용
                this.ctlHidden.Value =
                  DateTime.Now.ToShortTimeString();
            }
        }
        protected void btnOK_Click(object sender, EventArgs e)
        {
            // 히든필드에 저장된 문자열 출력
            Response.Write(ctlHidden.Value);
        }
    }
}