<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="FrmUserControl.aspx.cs" 
    Inherits="DevUserControl.FrmUserControl" %>

<%@ Register Src="~/NavigatorUserControl.ascx"
    TagPrefix="uc1" TagName="NavigatorUserControl" %>
<%@ Register Src="~/CategoryUserControl.ascx"
    TagPrefix="uc1" TagName="CategoryUserControl" %>
<%@ Register Src="~/CatalogUserControl.ascx"
    TagPrefix="uc1" TagName="CatalogUserControl" %>
<%@ Register Src="~/CopyrightUserControl.ascx"
    TagPrefix="uc1" TagName="CopyrightUserControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>웹 사이트 뼈대 만들기</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <style>
        div {
            border: 1px solid red;
            padding: 10px;
        }
    </style>
</head>
<body>
<form id="form1" runat="server">
<div class="container">
    <div class="row">
        <div class="col-md-12">
            <uc1:NavigatorUserControl runat="server" ID="NavigatorUserControl" />
        </div>
    </div>
    <div class="row" style="height: 200px;">
        <div class="col-md-3">
            <uc1:CategoryUserControl runat="server" ID="CategoryUserControl" />
        </div>
        <div class="col-md-9">
            <uc1:CatalogUserControl runat="server" ID="CatalogUserControl" />
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <uc1:CopyrightUserControl runat="server" ID="CopyrightUserControl" />
        </div>
    </div>
</div>
</form>
</body>
</html>
