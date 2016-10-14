<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="FrmRequestUserHostAddress.aspx.cs" 
    Inherits="DevASPNET.FrmRequestUserHostAddress" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>IP 주소 얻기</title>
</head>
<body>
<form id="form1" runat="server">
    <div>
        IP 주소 얻기<br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label><br />
        <asp:Label ID="Label2" runat="server"></asp:Label><br />
        <asp:Label ID="Label3" runat="server"></asp:Label>
    </div>
</form>
</body>
</html>