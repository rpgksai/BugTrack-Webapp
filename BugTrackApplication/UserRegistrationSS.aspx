<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="UserRegistrationSS.aspx.cs" Inherits="BugTrackApplication.UserRegistrationSS" %>
<%@ Register Src="~/UserControls/UserRegisSuccess.ascx" TagPrefix="uc" TagName="RegisterSS" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
<uc:RegisterSS ID="userRegisSS" runat="server"></uc:RegisterSS>

</asp:Content>

