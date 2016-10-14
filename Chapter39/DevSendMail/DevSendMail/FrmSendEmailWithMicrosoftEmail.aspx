<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="FrmSendEmailWithMicrosoftEmail.aspx.cs" 
    Inherits="DevSendMail.FrmSendEmailWithMicrosoftEmail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>ASP.NET에서 마이크로소프트 이메일 계정으로 메일 보내기</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnSendEmail" runat="server" 
                Text="MS계정으로메일보내기테스트" 
                OnClick="btnSendEmail_Click" />
        </div>
    </form>
</body>
</html>
