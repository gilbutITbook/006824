using System;

namespace MemoEngine.DotNetNote.Controls
{
    public partial class BoardSearchFormSingleControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string strQuery = 
                String.Format(
                    "/DotNetNote/BoardList.aspx?SearchField={0}&SearchQuery={1}", 
                        SearchField.SelectedItem.Value, SearchQuery.Text);
            Response.Redirect(strQuery);
        }
    }
}