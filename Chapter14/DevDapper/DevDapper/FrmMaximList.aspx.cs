using System;
using System.Web.UI;
using DevDapper.Repositories;

namespace DevDapper
{
    public partial class FrmMaximList : System.Web.UI.Page
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
            MaximServiceRepository repo = new MaximServiceRepository();

            this.lstMaxims.DataSource = repo.GetMaxims();
            this.lstMaxims.DataBind(); 
        }
    }
}