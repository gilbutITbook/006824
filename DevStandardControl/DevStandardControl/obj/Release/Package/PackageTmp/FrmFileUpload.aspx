<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="FrmFileUpload.aspx.cs" Inherits="DevStandardControl.FrmFileUpload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>파일업로드 컨트롤</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="ctlFileUpload" runat="server" />
            <br />
            <asp:LinkButton ID="btnUpload" runat="server"
                OnClick="btnUpload_Click">파일업로드</asp:LinkButton>
            <br />
            <asp:Label ID="lblResult" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
