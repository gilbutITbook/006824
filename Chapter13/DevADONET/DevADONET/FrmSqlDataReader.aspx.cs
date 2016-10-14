using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace DevADONET
{
    public partial class FrmSqlDataReader : System.Web.UI.Page
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
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings[
                    "ConnectionString"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = @"
                Select Num, Name, Email, Title, PostDate, PostIp 
                From Memos 
                Order By Num Desc
            ";
            cmd.CommandType = CommandType.Text;

            //[1] SqlDataReader 형식의 개체로 결과값 받기
            SqlDataReader dr = cmd.ExecuteReader();

            //[2] Read() 메서드로 데이터 있는만큼 반복
            string strOutput = "<table border=\"1\">" + 
                "<tr><td>번호</td><td>이름</td><td>메모</td><td>작성일</td></tr>";
            while (dr.Read())
            {
                strOutput += $"<tr><td>{dr["Num"]}</td>" + 
                    $"<td>{dr[1]}</td>" + $"<td>{dr.GetString(3)}</td>" + 
                    $"<td>{dr.GetDateTime(4).ToShortDateString()}</td></tr>";
            }
            strOutput += "</table>";

            //[3] Close() 메서드로 연결된 리더 개체 종료
            dr.Close();

            //[!] 출력
            tblOutput.Text = strOutput;

            con.Close();
        } // end of DisplayData()

    }
}