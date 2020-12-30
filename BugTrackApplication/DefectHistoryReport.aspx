<%@ Page Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeBehind="DefectHistoryReport.aspx.cs" Inherits="BugTrackApplication.DefectHistoryReport" %>
<%@ Register Src="~/UserControls/BugHistoryReport.ascx" TagPrefix="uc" TagName="BugReport" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="alignc">
        <h4>User Bug History Reports</h4>
    </div>


    <uc:BugReport ID="userBugHistory" runat="server"></uc:BugReport>

</asp:Content>
