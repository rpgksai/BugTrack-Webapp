<%@ Page Language="C#"  MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeBehind="NewAppDefect.aspx.cs" Inherits="BugTrackApplication.NewAppDefect" %>

<%@ Register Src="~/UserControls/NewApplicationDefect.ascx" TagPrefix="uc" TagName="AddUserAppDefect" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="alignc">
        <h4>Add Defect/Application</h4>
    </div>

<uc:AddUserAppDefect ID="userEditDefect" runat="server"></uc:AddUserAppDefect>

</asp:Content>
