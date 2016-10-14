using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DevADONET
{
    public partial class FrmMemoSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            //[1] 커넥션
            SqlConnection con = new SqlConnection(ConfigurationManager
                .ConnectionStrings["ConnectionString"].ConnectionString);
            con.Open();
            //[2] 커멘드
            SqlCommand cmd = new SqlCommand("SearchMemo", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //[!] 파라미터 추가
            cmd.Parameters.AddWithValue("SearchField", 
                lstSearchField.SelectedValue);
            cmd.Parameters.AddWithValue("SearchQuery", 
                txtSearchQuery.Text.Replace("--", ""));
            //[3] 데이터어댑터
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //[4] 데이터셋
            DataSet ds = new DataSet();
            da.Fill(ds, "Memos");
            //[5] 출력
            ctlMemoSearchList.DataSource = ds.Tables[0].DefaultView;
            ctlMemoSearchList.DataBind();
            //[6] 마무리
            con.Close();
        }
    }
}
