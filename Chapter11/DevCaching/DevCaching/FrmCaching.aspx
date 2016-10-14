<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="FrmCaching.aspx.cs" Inherits="DevCaching.FrmCaching" %>
<%@ Register Src="~/FrmCachingWebUserControl.ascx"
    TagPrefix="uc1" TagName="FrmCachingWebUserControl" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>캐싱(Caching)</title>
</head>
<body>
<form id="form1" runat="server">
<div>
    현재 시간(웹 폼):
    <asp:Label ID="lblTimeWebForms" runat="server" Text="Label"></asp:Label>
    <hr />
    <uc1:FrmCachingWebUserControl runat="server" ID="FrmCachingWebUserControl" />
</div>
</form>
</body>
</html>
