<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="FrmWizard.aspx.cs" Inherits="DevStandardControl.FrmWizard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>위저드 컨트롤</title>
</head>
<body>
<form id="form1" runat="server">
<div>
    <asp:Wizard ID="Wizard1" runat="server" 
        Width="600px" Height="200px" BorderWidth="1px"
        OnFinishButtonClick="Wizard1_FinishButtonClick">
        <WizardSteps>
            <asp:WizardStep ID="WizardStep1" runat="server" Title="0. 처음"
                StepType="Start">
                마법사를 시작합니다. <br />
                0: <asp:TextBox ID="txtStart" runat="server"></asp:TextBox>
            </asp:WizardStep>
            <asp:WizardStep ID="WizardStep2" runat="server" Title="1. 단계 1"
                StepType="Step">
                첫번째 단계입니다. <br />
                1: <asp:TextBox ID="txtStep1" runat="server"></asp:TextBox>
            </asp:WizardStep>
            <asp:WizardStep ID="WizardStep3" runat="server" Title="2. 단계 2"
                StepType="Step">
                두번째 단계입니다. <br />
                2: <asp:TextBox ID="txtStep2" runat="server"></asp:TextBox>
            </asp:WizardStep>
            <asp:WizardStep ID="WizardStep4" runat="server" Title="3. 마지막"
                StepType="Finish">
                마지막 단계입니다. <br />
                3: <asp:TextBox ID="txtFinish" runat="server"></asp:TextBox>
            </asp:WizardStep>
            <asp:WizardStep ID="WizardStep5" runat="server" Title="4. 완료"
                StepType="Complete">
                완료되었습니다. <hr />
                <asp:Label ID="lblComplete" runat="server"></asp:Label>
            </asp:WizardStep>
        </WizardSteps>
    </asp:Wizard>
</div>
</form>
</body>
</html>
