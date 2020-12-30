<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AllProjectDetails.ascx.cs" Inherits="BugTrackApplication.UserControls.AllProjectDetails" %>

<link href="../App_Themes/Theme1/GridStyle.css" rel="stylesheet" type="text/css" />

<%--<div class="alignc">
    <h1>All Application Details</h1>
    Login User :<asp:Label ID="LblLoginUser" runat="server"></asp:Label>
</div>--%>
<div class="c">
    <%--        <asp:Button ID="btnNew" runat="server"  CssClass="btn1" Text="Assign Bug/User" OnClick="btnNew_Click" />
        <asp:Button ID="btnNewApp" runat="server"  CssClass="btn1" Text="Assign Bug/Application" OnClick="btnAppNew_Click" />--%>
</div>
<div class="a">


    <table class="center">
        <tr>
            <td>
                <asp:GridView ID="GVApplicationReports" AutoGenerateColumns="false" AllowPaging="True" EmptyDataText="No Data Avaliable" PageSize="10"
                    DataKeyNames="ProjectId" HeaderStyle-CssClass="header" RowStyle-CssClass="rows" PagerStyle-CssClass="pager"
                    fOnRowEditing="GVDefectReports_RowEditing"
                    runat="server" OnRowEditing="GVDefectReports_RowEditing" OnPageIndexChanging="GVDefectReports_PageIndexChanging">
                    <Columns>
                        <asp:BoundField  DataField="ProjectId" HeaderText="Application Id" Visible="false" />
                        <asp:BoundField ItemStyle-Width="100px" ItemStyle-CssClass="ColorStyle" DataField="title" HeaderText="Application Name" />
                        <asp:BoundField ItemStyle-Width="100px" ItemStyle-CssClass="ColorStyle" DataField="Description" HeaderText="Description" />
                        <asp:BoundField ItemStyle-Width="100px" ItemStyle-CssClass="ColorStyle" DataField="NoOfModules" HeaderText="No. Of Modules" />
                        <asp:BoundField ItemStyle-Width="100px" ItemStyle-CssClass="ColorStyle" DataField="Platform" HeaderText="Platform" />
                        <asp:BoundField ItemStyle-Width="100px" ItemStyle-CssClass="ColorStyle" DataField="Client" HeaderText="Client" />
                        <asp:BoundField ItemStyle-Width="100px" ItemStyle-CssClass="ColorStyle" DataField="ProjectStatus" HeaderText="Status" />
                        <asp:BoundField ItemStyle-Width="100px" ItemStyle-CssClass="ColorStyle" DataField="projectStartDate" HeaderText="Start Date" />
                        <asp:BoundField ItemStyle-Width="100px" ItemStyle-CssClass="ColorStyle" DataField="projectEndDate" HeaderText="End Date" />
                        <asp:CommandField ShowEditButton="True" />
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
