using System;
using System.Web.UI;

namespace DevValidationControl
{
    public partial class FrmRequiredFieldValidator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //SetFocus() 메서드: 아이디 텍스트박스에 포커스
                Page.SetFocus(txtUserId);
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            // IsValid 속성 : 유효성 검사가 통과되면 true을 반환
            if (Page.IsValid)
            {
                Page.ClientScript.RegisterClientScriptBlock(
                    this.GetType(), 
                    "alertMessage", 
                    "<script>alert('통과');</script>");
            }
        }
    }
}
