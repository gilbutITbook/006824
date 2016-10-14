using System;

namespace DevStandardControl
{
    public partial class FrmButton : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                txtNum.Text = "0"; // 처음 로드할 때에만 0으로 초기화
            }
        }
        protected void btnUp_Click(object sender, EventArgs e)
        {
            txtNum.Text =
              Convert.ToString(Convert.ToInt32(txtNum.Text) + 1);
        }
        protected void btnDown_Click(object sender, EventArgs e)
        {
            txtNum.Text =
              Convert.ToString(int.Parse(txtNum.Text) - 1);
        }
    }
}