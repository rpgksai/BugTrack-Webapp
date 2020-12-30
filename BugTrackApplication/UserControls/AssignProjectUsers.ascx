<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AssignProjectUsers.ascx.cs" Inherits="BugTrackApplication.UserControls.AssignProjectUsers" %>
<%@ Register Assembly="GMDatePicker" Namespace="GrayMatterSoft" TagPrefix="cc1" %>
<link href="../App_Themes/Theme1/GridStyle.css" rel="stylesheet" type="text/css" />

   <div class="d">
     Login User :<asp:Label ID="LblLoginUser"  runat="server"></asp:Label>
</div>

<div class="ColorStyle">
    Application Name :
    <asp:DropDownList ID="ddlProjectName" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ProjectName">
    </asp:DropDownList>
    Employee Name :
    <asp:DropDownList ID="ddlEmployeeName" runat="server"></asp:DropDownList>
    Work StartDate :
    <cc1:GMDatePicker ID="GMWorkStartDate" runat="server" CalendarOffsetX="-129px" Style="z-index: 235; left: 0px; position: absolute; top: 0px"
        CalendarTheme="Green" TextBoxWidth="160" InitialValueMode="Null">
    </cc1:GMDatePicker>

    Work EndDate:
    <cc1:GMDatePicker ID="GMWorkEndDate" runat="server" CalendarOffsetX="-129px" Style="z-index: 235; left: 0px; position: absolute; top: 0px"
        CalendarTheme="Green" TextBoxWidth="160" InitialValueMode="Null">
    </cc1:GMDatePicker>

    <asp:Button ID="btnNew" runat="server" CssClass="btn1" Text="Add User" OnClick="btnNew_Click" />

</div>

<div>

    <%-- <asp:GridView ID="GVProjectEmployees" AutoGenerateColumns="false"  AllowPaging="True" EmptyDataText="No Data Avaliable" PageSize="10"
        DataKeyNames="EmployeeProjectId"
        fOnRowEditing="GVProjectEmployees" 
        runat="server" OnRowEditingProj="GVDefectReports_RowEditing" OnPageIndexChanging="GVDefectReports_PageIndexChanging" OnRowDeleting="GVProjectEmployees_RowDeleting">--%>
    <table class="center">
        <tr>
            <td>
                <asp:GridView ID="GVProjectEmployees" AutoGenerateColumns="false" AllowPaging="True" EmptyDataText="No Data Avaliable" PageSize="50"
                    DataKeyNames="EmployeeProjectId" HeaderStyle-CssClass="header" RowStyle-CssClass="rows" PagerStyle-CssClass="pager"
                    fOnRowEditing="GVDefectReports_RowEditing"
                    runat="server" OnRowEditingProj="GVDefectReports_RowEditing" OnPageIndexChanging="GVDefectReports_PageIndexChanging" OnRowDeleting="GVProjectEmployees_RowDeleting">

                    <Columns>
                        <asp:BoundField ItemStyle-Width="100px" ItemStyle-CssClass="ColorStyle" DataField="title" HeaderText="Application Name" />
                        <asp:BoundField ItemStyle-Width="300px" ItemStyle-CssClass="ColorStyle" DataField="FullName" HeaderText="Description" />
                        <asp:BoundField ItemStyle-Width="200px" ItemStyle-CssClass="ColorStyle" DataField="WorkStartDate" HeaderText="Work StartDate" />
                        <asp:BoundField ItemStyle-Width="200px" ItemStyle-CssClass="ColorStyle" DataField="WorkEndDate" HeaderText="WorkEndDate" />
                        <asp:CommandField ShowDeleteButton="true" />

                    </Columns>
                </asp:GridView>


                <div>
                    <asp:Label ID="lblMsg" Visible="false" runat="server" ForeColor="#FF0000" Font-Bold="true" Font-Names="Verdana" Font-Size="X-Small"></asp:Label>

                </div>
            </td>
        </tr>
    </table>

</div>
