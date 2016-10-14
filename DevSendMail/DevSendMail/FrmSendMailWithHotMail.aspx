<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="FrmSendMailWithHotMail.aspx.cs"
    Inherits="DevSendMail.FrmSendMailWithHotMail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>핫메일을 사용한 메일 전송</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            핫메일 아이디 :
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                <br />
                핫메일 암호 :
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                <br />
                <asp:Button ID="btnSendMail" runat="server" Text="핫메일을 사용한 메일 전송(@live.com)"
                    OnClick="btnSendMail_Click" />
        </div>
    </form>
</body>
</html>
