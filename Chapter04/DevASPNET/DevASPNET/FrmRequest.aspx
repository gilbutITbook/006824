<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="FrmRequest.aspx.cs" Inherits="DevASPNET.FrmRequest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Request 개체</title>
</head>
<body>
<form id="form1" runat="server">
    <div>
        아이디 : 
            <asp:TextBox ID="UserID" runat="server"></asp:TextBox><br />
        암호 : 
            <asp:TextBox ID="Password" runat="server"></asp:TextBox><br />
        이름 :
            <asp:TextBox ID="Name" runat="server"></asp:TextBox><br />
        나이 :
            <asp:TextBox ID="Age" runat="server"></asp:TextBox><br />
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="전송" 
            OnClick="btnSubmit_Click" />
    </div>
</form>
</body>
</html>