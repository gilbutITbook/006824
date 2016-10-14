<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="FrmLiteral.aspx.cs" Inherits="DevStandardControl.FrmLiteral" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>리터럴 컨트롤</title>
</head>
<body>
<form id="form1" runat="server">
<div>
    현재날짜 :
    <asp:Literal ID="ctlDate" runat="server"></asp:Literal><br />
    현재시간 :
    <asp:Label ID="lblTime" runat="server"></asp:Label><br />
</div>
</form>
</body>
</html>