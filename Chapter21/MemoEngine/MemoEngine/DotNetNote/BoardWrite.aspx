<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" 
    AutoEventWireup="true" CodeBehind="BoardWrite.aspx.cs" 
    ValidateRequest="false"
    Inherits="MemoEngine.DotNetNote.BoardWrite" %>

<%@ Register Src="~/DotNetNote/Controls/BoardEditorFormControl.ascx" 
    TagPrefix="uc1" TagName="BoardEditorFormControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <uc1:BoardEditorFormControl runat="server" id="ctlBoardEditorFormControl" />

</asp:Content>
