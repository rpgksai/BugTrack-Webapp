<%@ Page Language="C#" MasterPageFile="~/AdminMasterPage.master"  AutoEventWireup="true" CodeBehind="NewProject.aspx.cs" Inherits="BugTrackApplication.NewProject" %>


<%@ Register Assembly="GMDatePicker" Namespace="GrayMatterSoft" TagPrefix="cc1" %>
<%@ Register Src="~/UserControls/AssignNewProject.ascx" TagPrefix="uc" TagName="newProj" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="alignc"><h4>Add New Application </h4></div>
<uc:newProj ID="NewProjs" runat="server"></uc:newProj>

</asp:Content>