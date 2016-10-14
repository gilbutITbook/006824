<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="FrmRangeValidator.aspx.cs" 
    Inherits="DevValidationControl.FrmRangeValidator" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>범위 확인 유효성 검사 컨트롤</title>
</head>
<body>
<form id="form1" runat="server">
<div>
    <h3>범위 확인 유효성 검사 컨트롤</h3>

    나이:
    <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
    <asp:RangeValidator ID="valAge" runat="server" 
        ControlToValidate="txtAge"
        ErrorMessage="나이는 1~150 사이의 정수입니다."
        MinimumValue="1" MaximumValue="150" Type="Integer"
        Display="Static"
        SetFocusOnError="true"></asp:RangeValidator>
    <br />

    학점:
    <asp:TextBox ID="txtScore" runat="server"></asp:TextBox>
    <asp:RangeValidator ID="valScore" runat="server" 
        ControlToValidate="txtScore"
        ErrorMessage="학점은 A부터 F까지입니다."
        MinimumValue="A" MaximumValue="F" Type="String"
        ></asp:RangeValidator>
    <hr />

    <asp:LinkButton ID="btnCheck" runat="server">체크</asp:LinkButton>
</div>
</form>
</body>
</html>
