using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevValidationControl
{
    public partial class FrmDropDownListWithRequiredFieldValidator : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DropDownList1.Items.Insert(0, new ListItem("-선택-", "-1"));

                for (int i = 0; i < 10; i++)
                {
                    //[1] Text와 Value를 DB에서 구분해서 읽어와서...
                    ListItem li =
                      new ListItem(i.ToString(), String.Format("{0}", i));
                    //[2] DropDownList 컨트롤에 등록
                    this.DropDownList1.Items.Add(li);
                }
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = DropDownList1.SelectedValue;
        }
    }
}