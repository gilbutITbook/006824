using System;

namespace DevStandardControl
{
    public partial class FrmCheckBoxList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Empty;
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            string strMsg = "당신의 취미는 <br />";
            for (int i = 0; i < lstHobby.Items.Count; i++)
            {
                if (lstHobby.Items[i].Selected)
                {
                    strMsg += lstHobby.Items[i].Text + "<br />";
                }
            }
            lblDisplay.Text = strMsg;
        }
    }
}
