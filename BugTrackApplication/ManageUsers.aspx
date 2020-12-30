<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/AdminMasterPage.master" CodeBehind="ManageUsers.aspx.cs" Inherits="BugTrackApplication.ManageUsers" %>


<%@ Register Src="~/UserControls/AssignProjectUsers.ascx" TagPrefix="uc" TagName="AddUserProj" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
     <div class="alignc"><h4>Application/User Details</h4></div>
<uc:AddUserProj ID="userEditDefect" runat="server"></uc:AddUserProj>

</asp:Content>
