<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="FrmConfiguration.aspx.cs" 
    Inherits="DevConfiguration.FrmConfiguration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>
        <%= System.Web.Configuration.
                   WebConfigurationManager.AppSettings["SITE_NAME"].ToString() %>
    </title>
</head>
<body>
<form id="form1" runat="server">
<div>
    <asp:Label ID="lblSITE_NAME" runat="server"></asp:Label>
    <hr />
    <asp:Label ID="lblCOMPANY_NAME" runat="server"></asp:Label>
    <hr />
    <asp:Label ID="lblASPNETBOOKTEST_ConnectionString" runat="server"></asp:Label>
</div>
</form>
</body>
</html>
