<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BugHistoryReport.ascx.cs" Inherits="BugTrackApplication.UserControls.BugHistoryReport" %>
<link href="../App_Themes/Theme1/GridStyle.css" rel="stylesheet" type="text/css" />

<div class="d">
    Login User :<asp:Label ID="LblLoginUser" runat="server"></asp:Label>
</div>



<div class="ColorStyle">
    Application Name :
    <asp:DropDownList ID="ddlProjectName" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ProjectName">
    </asp:DropDownList>
    </div>
<table class="center">
    <tr>
        <td>
            <asp:GridView ID="GVDefectHistoryReports" AutoGenerateColumns="false" AllowPaging="True" EmptyDataText="No Data Avaliable" PageSize="10"
                DataKeyNames="DefectId" HeaderStyle-CssClass="header" RowStyle-CssClass="rows" PagerStyle-CssClass="pager"
                fOnRowEditing="GVDefectReports_RowEditing"
                runat="server"  OnPageIndexChanging="GVDefectReports_PageIndexChanging">
                <Columns>
                    <asp:BoundField DataField="DefectHistoryId" HeaderText="Defect Id" Visible="false" />
                    <asp:BoundField DataField="DefectName" HeaderText="Application Name"  ItemStyle-Width="200px" ItemStyle-CssClass="ColorStyle" />
                    <asp:BoundField DataField="ModuleName" HeaderText="Module Name" ItemStyle-Width="100px" ItemStyle-CssClass="ColorStyle" />
                    
                    <asp:BoundField DataField="FirstName" HeaderText="Assigned To" ItemStyle-Width="100px" ItemStyle-CssClass="ColorStyle" />
                    <asp:BoundField DataField="SendingDate" HeaderText="Updated Date " ItemStyle-Width="100px" ItemStyle-CssClass="ColorStyle" />
                    <asp:BoundField DataField="UpdatedDate" HeaderText="Status" ItemStyle-Width="100px" ItemStyle-CssClass="ColorStyle" />
                     

                </Columns>

            </asp:GridView>



        </td>
    </tr>
 
</table>
<center>
<table><tr>
<td  >
<asp:Button ID="btnExcelFormat" Visible ="true"  runat ="server" Text ="Export To Excel"  ForeColor="#FF0000"   Font-Bold="true" Font-Names="Verdana" Font-Size="X-Small" OnClick="btnExcelFormat_Click" />
</td>
<td>
<asp:Button ID="btnPrint" Visible ="true"  runat ="server" Text =" Print " OnClientClick="window.print()" ForeColor="#FF0000"   Font-Bold="true" Font-Names="Verdana" Font-Size="X-Small"  />
</td>
<td align="right">
<asp:Button ID="btnPdfFormat" Visible ="true"  runat ="server" Text ="Export To Pdf  "  ForeColor="#FF0000"   Font-Bold="true" Font-Names="Verdana" Font-Size="X-Small" OnClick="btnPdfFormat_Click" />
</td>
</tr></table>
<div>
    <asp:Label ID="lblMsg" Visible="false" runat="server" ForeColor="#FF0000" Font-Bold="true" Font-Names="Verdana" Font-Size="X-Small"></asp:Label>

</div>

</center>
