<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="FrmLabel.aspx.cs" Inherits="DevStandardControl.FrmLabel" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>레이블 컨트롤</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            현재시간 :
		<asp:Label ID="lblDateTime" runat="server"
            BackColor="#FFFFC0" BorderColor="Red"
            BorderStyle="Solid" BorderWidth="1px"
            ForeColor="Blue" />
        </div>
    </form>
</body>
</html>