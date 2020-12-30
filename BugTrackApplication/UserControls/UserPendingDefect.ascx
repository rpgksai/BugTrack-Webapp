<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserPendingDefect.ascx.cs" Inherits="BugTrackApplication.UserControls.UserPendingDefect" %>

<link href="../App_Themes/Theme1/GridStyle.css" rel="stylesheet" type="text/css" />

<div class="d">
    Login User :<asp:Label ID="LblLoginUser" runat="server"></asp:Label>
</div>
<table class="center">
    <tr>
        <td>
            <asp:GridView ID="GVDefectPendingReports" AutoGenerateColumns="false" AllowPaging="True" EmptyDataText="No Data Avaliable" PageSize="10"
                DataKeyNames="DefectId" HeaderStyle-CssClass="header" RowStyle-CssClass="rows" PagerStyle-CssClass="pager"
                fOnRowEditing="GVDefectReports_RowEditing"
                runat="server" OnRowEditing="GVDefectReports_RowEditing" OnPageIndexChanging="GVDefectReports_PageIndexChanging">
                <Columns>
                    <asp:BoundField DataField="DefectId" HeaderText="Defect Id" Visible="false" />
                    <asp:BoundField DataField="title" HeaderText="Application Name"  ItemStyle-Width="200px" ItemStyle-CssClass="ColorStyle" />
                    <asp:BoundField DataField="Description" HeaderText="Description" ItemStyle-Width="350px" ItemStyle-CssClass="ColorStyle" />
                    <asp:BoundField DataField="DefectTypeName" HeaderText="Defect Title" ItemStyle-Width="100px" ItemStyle-CssClass="ColorStyle" />
                    <asp:BoundField DataField="FirstName" HeaderText="Assigned To" ItemStyle-Width="100px" ItemStyle-CssClass="ColorStyle" />
                    <asp:BoundField DataField="SendingDate" HeaderText="Assigned Date " ItemStyle-Width="100px" ItemStyle-CssClass="ColorStyle" />
                    <asp:BoundField DataField="status" HeaderText="Status" ItemStyle-Width="100px" ItemStyle-CssClass="ColorStyle" />
                    <asp:CommandField ShowEditButton="True" />
                    <asp:CommandField ShowDeleteButton="true" />

                </Columns>

            </asp:GridView>



        </td>
    </tr>
 
</table>

<div>
    <asp:Label ID="lblMsg" Visible="false" runat="server" ForeColor="#FF0000" Font-Bold="true" Font-Names="Verdana" Font-Size="X-Small"></asp:Label>

</div>
