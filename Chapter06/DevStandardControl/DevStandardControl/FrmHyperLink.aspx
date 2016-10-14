<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="FrmHyperLink.aspx.cs" Inherits="DevStandardControl.FrmHyperLink" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>하이퍼링크 컨트롤</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="lnkDotNetKorea" runat="server"
                NavigateUrl="http://www.dotnetkorea.com/">
                닷넷코리아(<u>D</u>)
            </asp:HyperLink>
        </div>
    </form>
</body>
</html>