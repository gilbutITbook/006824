<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="FrmImageButton.aspx.cs" Inherits="DevStandardControl.FrmImageButton" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>이미지 버튼 컨트롤</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ImageButton ID="imgWrite" runat="server"
                AlternateText="글쓰기"
                OnClick="imgWrite_Click" ToolTip="글쓰기" />
            <asp:ImageButton ID="imgList" runat="server"
                AlternateText="리스트"
                OnClick="imgList_Click" ToolTip="리스트" />
        </div>
    </form>
</body>
</html>