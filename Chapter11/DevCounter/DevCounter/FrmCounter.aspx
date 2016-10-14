<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="FrmCounter.aspx.cs" Inherits="DevCounter.FrmCounter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>카운터 표시</title>
</head>
<body>
<form id="form1" runat="server">
    <div>
        현재: <asp:Label ID="lblNow" runat="server"></asp:Label><br />
    </div>
</form>
</body>
</html>
