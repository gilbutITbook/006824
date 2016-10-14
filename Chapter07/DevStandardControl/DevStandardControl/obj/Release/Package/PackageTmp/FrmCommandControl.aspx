<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="FrmCommandControl.aspx.cs" Inherits="DevStandardControl.FrmCommandControl" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>명령 컨트롤</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            버튼 컨트롤:
            <asp:Button ID="btnButton" runat="server" Text="버튼"
                OnClick="btnCommand_Click" /><br />
            <br />
            링크버튼 컨트롤:
            <asp:LinkButton ID="btnLink" runat="server"
                OnClick="btnCommand_Click">링크버튼</asp:LinkButton><br />
            <br />
            이미지버튼 컨트롤:
            <asp:ImageButton ID="btnImage" runat="server"
                ImageUrl="./images/btn_home.gif" ToolTip="홈으로..."
                AlternateText="홈으로..." OnClick="btnImage_Click" /><br />
            <br />
            <asp:Label ID="lblDisplay" runat="server"></asp:Label><br />
        </div>
    </form>
</body>
</html>
