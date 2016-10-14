<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="FrmPlaceHolder.aspx.cs" Inherits="DevStandardControl.FrmPlaceHolder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>플레이스홀더 컨트롤</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:PlaceHolder ID="ctlPlaceHolder" runat="server"></asp:PlaceHolder>
            <hr />
            <asp:Label ID="lblDisplay" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
