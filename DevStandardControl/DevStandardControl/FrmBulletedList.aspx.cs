using System;
using System.Web.UI.WebControls;

namespace DevStandardControl
{
    public partial class FrmBulletedList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lstFavorite_Click(object sender, BulletedListEventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("선택한 항목 : <br />");
            sb.Append(lstFavorite.Items[e.Index].Text);
            sb.Append("<br />");
            sb.Append(lstFavorite.Items[e.Index].Value + "<br />");

            Response.Write(sb.ToString());
        }
    }
}