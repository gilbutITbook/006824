using System;

namespace Gilbut
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                txtDisplay.BorderColor = System.Drawing.Color.Red;
                txtDisplay.BorderStyle = System.Web.UI.WebControls.BorderStyle.Solid;
                txtDisplay.BorderWidth = 1;
            }
        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "안녕하세요.";
        }

        protected void btnPrint_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "반갑습니다.";
        }

        protected void btnOutput_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "또 만나요.";
        }
    }
}
