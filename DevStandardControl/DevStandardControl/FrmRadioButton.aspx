<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="FrmRadioButton.aspx.cs" Inherits="DevStandardControl.FrmRadioButton" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>라디오버튼 컨트롤</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:RadioButton ID="rdoMan" runat="server" 
                GroupName="Gender" />
            <asp:RadioButton ID="optWomen" runat="server" 
                GroupName="Gender" />
            <asp:Button ID="btnOK" runat="server" Text="확인" 
                OnClick="btnOK_Click" />
            <hr />
            <asp:Label ID="lblDisplay" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
