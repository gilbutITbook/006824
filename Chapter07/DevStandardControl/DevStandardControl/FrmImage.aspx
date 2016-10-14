<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="FrmImage.aspx.cs" Inherits="DevStandardControl.FrmImage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>이미지 컨트롤</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="imgChange" runat="server"
                ImageUrl="~/images/ASP-NET-Banners-01.png"
                AlternateText="대체텍스트" Width="100px" Height="100px" />
            <hr />
            <asp:Button Text="이미지 순환" runat="server" ID="btnChange" 
                OnClick="btnChange_Click" />
        </div>
    </form>
</body>
</html>
