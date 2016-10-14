<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="FrmCompareValidator.aspx.cs" 
    Inherits="DevValidationControl.FrmCompareValidator" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>비교 확인 유효성 검사 컨트롤</title>
</head>
<body>
<form id="form1" runat="server">
<div>
    <h3>비교 확인 유효성 검사 컨트롤</h3>
    암호:
    <asp:TextBox ID="txtPassword" runat="server" 
        TextMode="Password"></asp:TextBox><br />            
    암호 확인: 
    <asp:TextBox ID="txtPasswordConfirm" runat="server" 
        TextMode="Password"></asp:TextBox>            
    <asp:CompareValidator ID="varPasswordConfirm" runat="server" 
        ControlToValidate="txtPasswordConfirm" 
        ControlToCompare="txtPassword"
        SetFocusOnError="true"
        ErrorMessage="암호를 다시 확인해 주세요."></asp:CompareValidator>
    <hr />
    <asp:Button ID="btnConfirm" runat="server" Text="확인" />
</div>
</form>
</body>
</html>
