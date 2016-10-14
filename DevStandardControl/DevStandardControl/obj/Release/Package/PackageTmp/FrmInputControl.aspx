<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="FrmInputControl.aspx.cs" Inherits="DevStandardControl.FrmInputControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>데이터 입력 관련 컨트롤</title>
</head>
<body>
<form id="form1" runat="server">
<div>
    <table style="width: 500px">
        <tr>
            <td style="width: 200px">체크박스(이용약관):</td>
            <td style="width: 100px">
                <asp:CheckBox ID="chkAgree" runat="server" Text="동의합니다."
                    Checked="true" Width="122px" />
            </td>
        </tr>
        <tr>
            <td style="width: 200px">체크박스리스트(취미):</td>
            <td style="width: 100px">
                <asp:CheckBoxList ID="lstHobby" runat="server"
                    RepeatColumns="2" RepeatDirection="Horizontal"
                    RepeatLayout="Flow" Width="202px">
                    <asp:ListItem Selected="True" Value="S">축구</asp:ListItem>
                    <asp:ListItem Value="V">배구</asp:ListItem>
                    <asp:ListItem Selected="True" Value="B">농구</asp:ListItem>
                </asp:CheckBoxList>
            </td>
        </tr>
        <tr>
            <td style="width: 200px">라디오버튼(성별):</td>
            <td style="width: 100px">
                <asp:RadioButton ID="rdoMan" runat="server"
                    Text="남자" GroupName="Gender" Checked="true" />
                <asp:RadioButton ID="rdoWomen" runat="server"
                    Text="여자" GroupName="Gender" />
            </td>
        </tr>
        <tr>
            <td style="width: 200px">라디오버튼리스트(결혼):</td>
            <td style="width: 100px">
                <asp:RadioButtonList ID="lstWedding" runat="server"
                    RepeatDirection="horizontal"
                    RepeatLayout="Flow" Width="110px">
                    <asp:ListItem Selected="True">미혼</asp:ListItem>
                    <asp:ListItem>기혼</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td style="width: 200px; height: 24px">드롭다운리스트(단일선택)</td>
            <td style="width: 100px; height: 24px">
                <asp:DropDownList ID="lstJob" runat="server">
                    <asp:ListItem>회사원</asp:ListItem>
                    <asp:ListItem Selected="True">공무원</asp:ListItem>
                    <asp:ListItem>백수</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 200px">리스트박스(다중선택)</td>
            <td style="width: 100px">
                <asp:ListBox ID="lstFavorite" runat="server"
                    SelectionMode="Multiple"></asp:ListBox>
            </td>
        </tr>
    </table>
    <br />
    <asp:Button ID="btnOK" runat="server" Text="확인"
        OnClick="btnOK_Click" /><br />
    <br />
    <asp:Label ID="lblDisplay" runat="server" />
</div>
</form>
</body>
</html>
