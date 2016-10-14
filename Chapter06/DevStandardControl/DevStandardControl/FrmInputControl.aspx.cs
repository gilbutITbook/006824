using System;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevStandardControl
{
    public partial class FrmInputControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Page.IsPostBack : 처음로드하면 false, 포스트백(다시게시)되면 true
            if (!Page.IsPostBack) // 처음로드할 때에만...
            {
                BindFavorite();
            }
        }
        private void BindFavorite()
        {
            // 동적으로 ListItem을 채우는 3가지 방법
            // 관심사 채우기(공통)
            lstFavorite.Items.Add("C#");
            this.lstFavorite.Items.Add("ASP.NET");

            ListItem li = new ListItem();
            li.Text = "JavaScript";
            li.Value = "TypeScript";
            this.lstFavorite.Items.Add(li);

            ListItem listItem = new ListItem("닷넷", ".NET");
            this.lstFavorite.Items.Add(listItem);
        }
        protected void btnOK_Click(object sender, EventArgs e)
        {
            //[0] 문자열 변수 선언 : StringBuilder 클래스 사용
            StringBuilder sb = new StringBuilder();

            //[1] 체크박스의 내용 가져오기 : 단일값
            if (this.chkAgree.Checked)
            {
                sb.Append("[1] " + this.chkAgree.Text + "<br />");
            }

            //[2] 체크박스리스트의 내용 가져오기 : 다중값
            if (this.lstHobby.Items[0].Selected) // 0번째 항목이 선택되었다면...
            {
                sb.Append("[2] " + this.lstHobby.Items[0].Value + "<br />");
            }
            if (this.lstHobby.Items[1].Selected)
            {
                sb.AppendFormat("[2] {0}<br/>", this.lstHobby.Items[1].Value);
            }
            if (this.lstHobby.Items[2].Selected)
            {
                sb.AppendFormat("[2] {0}<br/>", this.lstHobby.Items[2].Value);
            }

            //[3] 라디오버튼 값 받아오기 : 단일값
            if (this.rdoMan.Checked)
            {
                sb.AppendFormat("[3] {0} 선택<br />", rdoMan.Text);
            }
            else
            {
                sb.AppendFormat("[3] {0} 선택<br />", rdoWomen.Text);
            }

            //[4] 라디오버튼리스트 값 받아오기 : 단일값
            sb.AppendFormat("[4] {0}<br />", lstWedding.SelectedItem.Text);

            //[5] 드롭다운리스트 값 받아오기 : 단일값
            sb.AppendFormat("[5] {0}<br />",
            lstJob.Items[lstJob.SelectedIndex].Value);

            //[6] 리스트박스 : 다중값
            for (int i = 0; i < lstFavorite.Items.Count; i++)
            {
                if (lstFavorite.Items[i].Selected)
                {
                    sb.AppendFormat("[6] {0}<br />", lstFavorite.Items[i].Value);
                }
            }
            //--OR--
            foreach (ListItem li in lstFavorite.Items)
            {
                if (li.Selected)
                {
                    sb.AppendFormat("[6] {0}<br />", li.Text);
                }
            }

            //[!] 출력
            this.lblDisplay.Text = sb.ToString();
        }
    }
}