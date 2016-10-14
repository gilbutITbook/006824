<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="FrmSmtpClient.aspx.cs" Inherits="DevSendMail.FrmSmtpClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnSendMail" runat="server" 
                OnClick="btnSendMail_Click" Text="내 메일로 간단하게 메일 보내기" />
        </div>
    </form>
</body>
</html>
