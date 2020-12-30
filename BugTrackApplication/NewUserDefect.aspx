<%@ Page Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeFile="NewUserDefect.aspx.cs" Inherits="BugTrackApplication.NewUserDefect" Title="Add New Defect" %>

<%@ Register Src="~/UserControls/AddUserDefect.ascx" TagPrefix="uc" TagName="AddUserDefect" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
      <div class="alignc">
        <h4>Add Defect/Users</h4>
    </div>

<uc:AddUserDefect ID="userEditDefect" runat="server"></uc:AddUserDefect>

</asp:Content>
