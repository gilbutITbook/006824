<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="FrmButton.aspx.cs" Inherits="DevStandardControl.FrmButton" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>버튼 컨트롤</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtNum" runat="server" />
            <asp:Button ID="btnUp" runat="server"
                OnClick="btnUp_Click" Text=" 증가 " />
            <asp:Button ID="btnDown" runat="server"
                OnClick="btnDown_Click" Text=" 감소 " />
        </div>
    </form>
</body>
</html>