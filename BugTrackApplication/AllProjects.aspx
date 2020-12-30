<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/AdminMasterPage.master" CodeBehind="AllProjects.aspx.cs" Inherits="BugTrackApplication.AllProjects" %>
<%@ Register Src="~/UserControls/AllProjectDetails.ascx" TagPrefix="uc" TagName="AddUserApp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="alignc"><h4>Application Report</h4></div>
    <uc:AddUserApp ID="userEditDefect" runat="server"></uc:AddUserApp>
    
</asp:Content>