<%@ Page Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeFile="AdminHomePage.aspx.cs" Inherits="BugTrackApplication.AdminHomePage" Title="Bug Tracker Application" %>

<%@ Register Src="~/UserControls/WebUserAllUserDefects.ascx" TagPrefix="uc" TagName="ShowDefect" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="alignc"><h4>User Defect Reports</h4></div>
    <div>
        <uc:ShowDefect ID="ShowDefect1" runat="server"></uc:ShowDefect>

    </div>
</asp:Content>
