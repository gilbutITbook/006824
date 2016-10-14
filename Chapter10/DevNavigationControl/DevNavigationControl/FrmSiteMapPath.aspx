<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="FrmSiteMapPath.aspx.cs" Inherits="DevNavigationControl.FrmSiteMapPath" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>사이트맵패스 컨트롤</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:SiteMapPath ID="SiteMapPath1" runat="server"></asp:SiteMapPath>
            </div>
            <div>
                사이트맵패스 컨트롤
            </div>
        </div>
    </form>
</body>
</html>
