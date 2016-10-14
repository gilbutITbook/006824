using System;
using System.Configuration;
using System.Web.Configuration;

namespace DevConfiguration
{
    public partial class FrmConfiguration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblSITE_NAME.Text = 
                WebConfigurationManager.AppSettings["SITE_NAME"].ToString();
            lblCOMPANY_NAME.Text = 
                ConfigurationManager.AppSettings["COMPANY_NAME"].ToString();

            lblASPNETBOOKTEST_ConnectionString.Text =
               WebConfigurationManager.ConnectionStrings[
                   "ASPNETBOOKTEST_ConnectionString"].ConnectionString;
        }
    }
}
