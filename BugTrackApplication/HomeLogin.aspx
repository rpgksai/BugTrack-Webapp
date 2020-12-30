<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/AdminMasterPage.master" CodeBehind="HomeLogin.aspx.cs" Inherits="BugTrackApplication.HomeLogin" %>

<%@ Register Src="~/UserControls/UserPendingDefect.ascx" TagPrefix="uc" TagName="userdefects" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="alignc">
        <h4>User Pending Defects</h4>
    </div>

 
          <uc:userdefects ID="userPendingDef" runat="server"></uc:userdefects>

</asp:Content>
