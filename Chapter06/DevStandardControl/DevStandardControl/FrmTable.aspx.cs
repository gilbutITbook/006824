using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevStandardControl
{
    public partial class FrmTable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //[!]  동적으로 1행 1열 테이블 만들기
            //[1] 행(Row)을 하나 추가
            TableRow tr = new TableRow();
            //[2] 열(Column)을 하나 추가
            TableCell td = new TableCell();
            //[3] 내용(Text)을 하나 추가 : 다른 컨트롤에 문자열 추가
            LiteralControl lc = new LiteralControl();
            lc.Text = "안녕";
            // 열에 내용 추가
            td.Controls.Add(lc);
            // 행에 열 추가
            tr.Cells.Add(td);
            // 테이블 컨트롤에 행 추가
            this.ctlMyTable.BorderWidth = 1;
            this.ctlMyTable.Rows.Add(tr);
        }
    }
}