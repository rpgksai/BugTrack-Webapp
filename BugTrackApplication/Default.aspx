<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BugTrackApplication._Default" %>
<%@ Register Src="~/UserControls/LoginUserControl.ascx" TagPrefix="uc" TagName="Login" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<div class="alignc"><h4>User Authentication</h4></div>
    
<div class="alignc">

        <uc:Login id="userLogin" runat="server"></uc:Login>
       
</div>

</asp:Content>
