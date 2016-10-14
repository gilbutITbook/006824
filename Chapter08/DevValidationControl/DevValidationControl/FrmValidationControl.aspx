<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="FrmValidationControl.aspx.cs" Inherits="DevValidationControl.FrmValidationControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>유효성 검사 컨트롤</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>ASP.NET 4.5 이상에서 유효성 검사 컨트롤 사용하기</h1>
            <ol>
                <li>PM> Install-Package jQuery</li>
                <li>PM> Install-Package AspNet.ScriptManager.jQuery</li>
                <li>Global.asax - Application_Start(): <br /> 
                    System.Web.UI.ValidationSettings.UnobtrusiveValidationMode = 
                        System.Web.UI.UnobtrusiveValidationMode.WebForms;</li>
            </ol>
        </div>
    </form>
</body>
</html>
