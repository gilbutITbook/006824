using System;
using System.Web.UI;
using DevDapper.Models;
using DevDapper.Repositories;

namespace DevDapper
{
    public partial class FrmMaximView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DisplayData();
            }
        }

        private void DisplayData()
        {
            int id = Convert.ToInt32(Request.QueryString["Id"]);

            MaximServiceRepository repo = new MaximServiceRepository();
            Maxim maxim = repo.GetMaximById(id);

            this.lblId.Text = id.ToString();
            this.lblName.Text = maxim.Name;
            this.lblContent.Text = maxim.Content;

            this.btnModify.NavigateUrl = "FrmMaximModify.aspx?Id=" + id;
            this.btnDelete.NavigateUrl = "FrmMaximDelete.aspx?Id=" + id;
        }
    }
}