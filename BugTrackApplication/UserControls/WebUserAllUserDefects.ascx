<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserAllUserDefects.ascx.cs" Inherits="BugTrackApplication.UserControls.WebUserAllUserDefects" %>

<link href="../App_Themes/Theme1/GridStyle.css" rel="stylesheet" type="text/css" />

<div class="d">
    Login User :<asp:Label ID="LblLoginUser" runat="server"></asp:Label>
</div>
<table class="center">
    <tr>
        <td>
            <asp:GridView ID="GVDefectReports" AutoGenerateColumns="false" AllowPaging="True" EmptyDataText="No Data Avaliable" PageSize="10"
                DataKeyNames="DefectId" HeaderStyle-CssClass="header" RowStyle-CssClass="rows" PagerStyle-CssClass="pager"
                fOnRowEditing="GVDefectReports_RowEditing"
                runat="server" >
                <Columns>
                    <asp:BoundField DataField="DefectId" HeaderText="Defect Id" Visible="false" />
                    <asp:BoundField DataField="title" HeaderText="Application Name"  ItemStyle-Width="200px" ItemStyle-CssClass="ColorStyle" />
                    <asp:BoundField DataField="Description" HeaderText="Description" ItemStyle-Width="350px" ItemStyle-CssClass="ColorStyle" />
                    <asp:BoundField DataField="DefectTypeName" HeaderText="Defect Title" ItemStyle-Width="100px" ItemStyle-CssClass="ColorStyle" />
                    <asp:BoundField DataField="FirstName" HeaderText="Assigned To" ItemStyle-Width="100px" ItemStyle-CssClass="ColorStyle" />
                    <asp:BoundField DataField="SendingDate" HeaderText="Assigned Date " ItemStyle-Width="100px" ItemStyle-CssClass="ColorStyle" />
                    <asp:BoundField DataField="status" HeaderText="Status" ItemStyle-Width="100px" ItemStyle-CssClass="ColorStyle" />
                  
                </Columns>

            </asp:GridView>



        </td>
    </tr>
  <%--  <tr>
        <td>
            <asp:GridView ID="gvDetails" DataKeyNames="DefectId" runat="server"
                AutoGenerateColumns="false" CssClass="Gridview" HeaderStyle-BackColor="#61A6F8"
                ShowFooter="true" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="White"
                OnRowCancelingEdit="gvDetails_RowCancelingEdit" HeaderStyle-CssClass="header" RowStyle-CssClass="rows" PagerStyle-CssClass="pager"
                OnRowDeleting="gvDetails_RowDeleting" OnRowEditing="gvDetails_RowEditing"
                OnRowUpdating="gvDetails_RowUpdating"
                OnRowCommand="gvDetails_RowCommand">
                <Columns>
                    <asp:TemplateField>
                        <EditItemTemplate>
                            <asp:ImageButton ID="imgbtnUpdate" CommandName="Update" runat="server" ImageUrl="~/Images/Update.jpg" ToolTip="Update" Height="20px" Width="20px" />
                            <asp:ImageButton ID="imgbtnCancel" runat="server" CommandName="Cancel" ImageUrl="~/Images/Cancel.jpg" ToolTip="Cancel" Height="20px" Width="20px" />
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:ImageButton ID="imgbtnEdit" CommandName="Edit" runat="server" ImageUrl="~/Images/Edit.jpg" ToolTip="Edit" Height="20px" Width="20px" />
                            <asp:ImageButton ID="imgbtnDelete" CommandName="Delete" Text="Edit" runat="server" ImageUrl="~/Images/delete.jpg" ToolTip="Delete" Height="20px" Width="20px" />
                        </ItemTemplate>
                        <FooterTemplate>
                            <asp:ImageButton ID="imgbtnAdd" runat="server" ImageUrl="~/Images/AddNewitem.jpg" CommandName="AddNew" Width="30px" Height="30px" ToolTip="Add new User" ValidationGroup="validaiton" />
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="UserName">
                        <EditItemTemplate>
                            <asp:Label ID="lbleditusr" runat="server" Text='<%#Eval("Username") %>' />
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblitemUsr" runat="server" Text='<%#Eval("UserName") %>' />
                        </ItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtftrusrname" runat="server" />
                            <asp:RequiredFieldValidator ID="rfvusername" runat="server" ControlToValidate="txtftrusrname" Text="*" ValidationGroup="validaiton" />
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="City">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtcity" runat="server" Text='<%#Eval("City") %>' />
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblcity" runat="server" Text='<%#Eval("City") %>' />
                        </ItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtftrcity" runat="server" />
                            <asp:RequiredFieldValidator ID="rfvcity" runat="server" ControlToValidate="txtftrcity" Text="*" ValidationGroup="validaiton" />
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Designation">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtDesg" runat="server" Text='<%#Eval("Designation") %>' />
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblDesg" runat="server" Text='<%#Eval("Designation") %>' />
                        </ItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtftrDesignation" runat="server" />
                            <asp:RequiredFieldValidator ID="rfvdesignation" runat="server" ControlToValidate="txtftrDesignation" Text="*" ValidationGroup="validaiton" />
                        </FooterTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </td>
    </tr>--%>
</table>
<center>
<table class="a" ><tr>
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
</center>
<div>
    <asp:Label ID="lblMsg" Visible="false" runat="server" ForeColor="#FF0000" Font-Bold="true" Font-Names="Verdana" Font-Size="X-Small"></asp:Label>

</div>



