<%@ Page Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeFile="UserRegistration.aspx.cs" Inherits="UserRegistration" Title="User Registration Page" %>

<%@ Register Assembly="GMDatePicker" Namespace="GrayMatterSoft" TagPrefix="cc1" %>
<%@ Register Src="~/UserControls/UserRegistration.ascx" TagPrefix="uc" TagName="Register" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="alignc">
        <h4 class="ColorHeaderStyle">User Registration Page</h4>
    </div>


    <uc:Register ID="userRegistration" runat="server"></uc:Register>

</asp:Content>
