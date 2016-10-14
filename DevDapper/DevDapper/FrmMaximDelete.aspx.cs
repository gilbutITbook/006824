using System;
using System.Web.UI;
using DevDapper.Repositories;

namespace DevDapper
{
    public partial class FrmMaximDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Request.QueryString["Id"]))
            {
                if (!Page.IsPostBack)
                {
                    lblId.Text = Request["Id"]; 
                }
            }
            else
            {
                Response.Write("잘못된 요청입니다.");
                Response.End();
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["Id"]);

            MaximServiceRepository repo = new MaximServiceRepository();
            repo.RemoveMaxim(id);

            // 리스트 페이지로 이동
            Response.RedirectPermanent("FrmMaximList.aspx"); 
        }
    }
}