<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="FrmImageMap.aspx.cs" Inherits="DevStandardControl.FrmImageMap" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>이미지맵 컨트롤</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <img src="images/img_imagemap.jpg" alt="이미지맵 테스트용 이미지" />
            <hr />
            <asp:ImageMap ID="mapImage" runat="server"
                ImageUrl="~/images/img_imagemap.jpg">
                <asp:RectangleHotSpot NavigateUrl="FrmButton.aspx"
                    Top="0" Left="0" Bottom="20" Right="120" />
                <asp:RectangleHotSpot NavigateUrl="FrmLabel.aspx"
                    Top="20" Left="0" Bottom="40" Right="120" />
            </asp:ImageMap>
        </div>
    </form>
</body>
</html>
