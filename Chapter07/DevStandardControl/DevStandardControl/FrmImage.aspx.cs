using System;

namespace DevStandardControl
{
    public partial class FrmImage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Empty
        }

        protected void btnChange_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.Second % 2 == 0)
            {
                imgChange.ImageUrl = "~/images/ASP-NET-Banners-01.png";
            }
            else
            {
                imgChange.ImageUrl = "~/images/ASP-NET-Banners-02.png";
            }
        }
    }
}