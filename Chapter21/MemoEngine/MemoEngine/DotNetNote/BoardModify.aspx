<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" 
    AutoEventWireup="true" CodeBehind="BoardModify.aspx.cs" 
    ValidateRequest="false"
    Inherits="MemoEngine.DotNetNote.BoardModify" %>

<%@ Register Src="~/DotNetNote/Controls/BoardEditorFormControl.ascx" 
    TagPrefix="uc1" TagName="BoardEditorFormControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <uc1:BoardEditorFormControl runat="server" ID="ctlBoardEditorFormControl" />

</asp:Content>
