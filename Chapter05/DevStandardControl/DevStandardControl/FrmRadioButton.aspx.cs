using System;

namespace DevStandardControl
{
    public partial class FrmRadioButton : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rdoMan.Text = "남자";
            optWomen.Text = "여자";
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            string strMsg = "당신은 ";
            if (this.rdoMan.Checked)
            {
                strMsg += "남자입니다.<br />";
            }
            else
            {
                strMsg += "여자입니다.<br />";
            }
            lblDisplay.Text = strMsg; 
        }
    }
}