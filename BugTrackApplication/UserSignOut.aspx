<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/AdminMasterPage.master" CodeBehind="UserSignOut.aspx.cs" Inherits="BugTrackApplication.UserSignOut" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center> 
<br />
<br />
<table>
<tr><td><marquee behavior="alternate"><asp:LinkButton id="lbReLogin" runat="server" Text="Relogin" Font-Size="X-Small" Font-Names="Verdana" Font-Bold="true" ForeColor="Black" PostBackUrl="~/Default.aspx"></asp:LinkButton></marquee></td></tr>
<tr><td><asp:LinkButton ID="lbLogoutComplete"  ForeColor="Black"   Font-Bold="true" Font-Names="Verdana" Font-Size="X-Small" runat="server" PostBackUrl="~/Default.aspx">Do You Want Logout Completely</asp:LinkButton></td>

</tr>

</table>
</center>
</asp:Content>
