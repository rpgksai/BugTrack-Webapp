<%@ Page Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeFile="UserEditDefect.aspx.cs" Inherits="BugTrackApplication.UserEditDefect" Title="Bug Tracker Application" %>
<%@ Register Src="~/UserControls/EditUserDefects.ascx" TagPrefix="uc" TagName="EdtUserDefect" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
     <div class="alignc">
        <h4>Edit User Defects</h4>
    </div>
<uc:EdtUserDefect ID="userEditDefect" runat="server"></uc:EdtUserDefect>

</asp:Content>
                                                 