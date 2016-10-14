<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="FrmCheckBoxListValidation.aspx.cs" 
    Inherits="DevValidationControl.FrmCheckBoxListValidation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>체크박스에 값이 하나라도 체크되어있는지 확인</title>
    <script type="text/javascript">
        // 체크박스에 값이 하나라도 체크되어있는지 확인
        function CheckValue(sender, args) {
            var chkControlId = 'chkFavorites';
            var options =
                document.getElementById(chkControlId).getElementsByTagName('input');
            var ischecked = false;
            args.IsValid = false;
            for (i = 0; i < options.length; i++) {
                var opt = options[i];
                if (opt.type == "checkbox") {
                    if (opt.checked) {
                        ischecked = true;
                        args.IsValid = true;
                    }
                }
            }
        }
    </script>
</head>
<body>
<form id="form1" runat="server">
<div>
<asp:CheckBoxList ID="chkFavorites" runat="server" ValidationGroup="MyForm">
    <asp:ListItem Value="0">ASP.NET</asp:ListItem>
    <asp:ListItem Value="1">Bootstrap</asp:ListItem>
    <asp:ListItem Value="2">C#</asp:ListItem>
    <asp:ListItem Value="3">Dapper</asp:ListItem>
</asp:CheckBoxList>
<asp:CustomValidator ID="ValidateCheckBoxList1" runat="server" 
    ErrorMessage="반드시 하나 이상을 체크하세요."
    ClientValidationFunction="CheckValue" ValidationGroup="MyForm" Display="None" />
<asp:ValidationSummary runat="server" DisplayMode="List" ShowSummary="false" 
    ShowMessageBox="true" ValidationGroup="MyForm" />
<asp:Button Text="전송" runat="server" ValidationGroup="MyForm" />
</div>
</form>
</body>
</html>
