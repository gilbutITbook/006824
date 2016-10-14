<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="FrmLinkButton.aspx.cs" Inherits="DevStandardControl.FrmLinkButton" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>링크 버튼 컨트롤</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="lnkDotNetKorea" runat="server"
                OnClick="lnkDotNetKorea_Click">닷넷코리아로 이동
            </asp:LinkButton>
        </div>
    </form>
</body>
</html>