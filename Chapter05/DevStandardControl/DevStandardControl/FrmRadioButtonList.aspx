<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmRadioButtonList.aspx.cs" 
    Inherits="DevStandardControl.FrmRadioButtonList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>라디오버튼리스트 컨트롤</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:RadioButtonList ID="lstWedding" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem Selected="True">미혼</asp:ListItem>
            <asp:ListItem>기혼</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Button ID="btnOK" runat="server" Text="확인" OnClick="btnOK_Click" />
    </div>
    </form>
</body>
</html>
