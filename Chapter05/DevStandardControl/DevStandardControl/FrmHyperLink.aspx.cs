using System;

namespace DevStandardControl
{
    public partial class FrmHyperLink : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.lnkDotNetKorea.AccessKey = "D";
        }
    }
}