<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EditUserDefects.ascx.cs" Inherits="BugTrackApplication.UserControls.EditUserDefects" %>

      <table  class="center">

    <tr><td> 
         <div class="d">
     Login User :<asp:Label ID="LblLoginUser" runat="server"></asp:Label>
</div>
</td></tr></table>


 <table  class="center">
    <tr><td> 

<center>
<div class="a">
    <table>
        <tr>
            <td style="font-size: 12px; font-family: Arial">User AccountId:</td>
            <td align="left">
                <asp:TextBox ID="txtUserId" ReadOnly="true" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfv1" ErrorMessage="*" ControlToValidate="txtUserId" runat="server"></asp:RequiredFieldValidator>
            </td>
            <td style="font-size: 12px; font-family: Arial">User Name:</td>
            <td align="left">
                <asp:TextBox ID="txtUserName" ReadOnly="true" Width="160px" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rv2" ErrorMessage="*" ControlToValidate="txtUserName" runat="server"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="font-size: 12px; font-family: Arial">Project Name:</td>
            <td align="left">
                <asp:TextBox ID="txtProjectName" ReadOnly="true" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="Rfv3" ErrorMessage="*" ControlToValidate="txtProjectName" runat="server"></asp:RequiredFieldValidator>
            </td>
            <td style="font-size: 12px; font-family: Arial">Module Name:</td>
            <td align="left">
                <asp:TextBox ID="txtModuleName" ReadOnly="true" Width="160px" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RFV4" ErrorMessage="*" ControlToValidate="txtModuleName" runat="server"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="font-size: 12px; font-family: Arial">Defect Name:</td>
            <td align="left">
                <asp:TextBox ID="txtDefectName" runat="server" ReadOnly="true"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RFV5" ErrorMessage="*" ControlToValidate="txtDefectName" runat="server"></asp:RequiredFieldValidator>
            </td>
            <td style="font-size: 12px; font-family: Arial">Defect Type:</td>
            <td align="left">
                <%--<asp:TextBox ID="txtDefectTypeName" ReadOnly="true" Width="160px" runat="server"></asp:TextBox>--%>
                <asp:DropDownList ID="ddlDefectTypeName" runat="server"></asp:DropDownList>

            </td>
            <td>
                <asp:RequiredFieldValidator ID="Rfv6" ErrorMessage="*" ControlToValidate="ddlDefectTypeName" runat="server"></asp:RequiredFieldValidator>
            </td>
        </tr>

        <tr>
            <td style="font-size: 12px; font-family: Arial">Priority:</td>
            <td align="left">
                <asp:TextBox ID="txtPriority" runat="server" ReadOnly="true"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ErrorMessage="*" ControlToValidate="txtPriority" runat="server"></asp:RequiredFieldValidator>
            </td>
            <td style="font-size: 12px; font-family: Arial">Status:</td>
            <td align="left">
                <asp:RadioButtonList ID="rblStatus" RepeatDirection="Horizontal" runat="server">
                    <asp:ListItem Selected="True">Pending</asp:ListItem>
                    <asp:ListItem>Completed</asp:ListItem>
                </asp:RadioButtonList></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ErrorMessage="*" ControlToValidate="rblStatus" runat="server"></asp:RequiredFieldValidator>
            </td>
        </tr>

        <tr>
            <td style="font-size: 12px; font-family: Arial">Assigned To:</td>
            <td align="left">
                <asp:DropDownList ID="ddlAssignedTo" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlAssignedTo_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:TextBox ID="TxtAssignedTo" runat="server" ReadOnly="true"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ErrorMessage="*" ControlToValidate="ddlAssignedTo" runat="server"></asp:RequiredFieldValidator>
            </td>
            <td style="font-size: 12px; font-family: Arial">Assigned Date:</td>
            <td align="left">
                <asp:TextBox ID="TxtAssignedDate" ReadOnly="true" runat="server"></asp:TextBox></td>

            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ErrorMessage="*" ControlToValidate="TxtAssignedDate" runat="server"></asp:RequiredFieldValidator>
            </td>
        </tr>

        <tr>
            <td>Description:</td>
            <td align="left" colspan="4">
                <asp:TextBox  ID="txtDescription" Height="200" Width="427px" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfv7" ErrorMessage="*" ControlToValidate="txtDescription" runat="server"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnVerify" runat="server" CssClass="btn1" Text="Verify" OnClientClick="return confirm('R U Verified Defect !!!!')" OnClick="EditDefect_Click" />
            </td>
            <td>
                <asp:Button ID="btnCancel" runat="server" CssClass="btn1" Text="Cancel" OnClick="CancelMe"  />

            </td>


        </tr>
    </table>
</div>
<div>
    <asp:Label ID="lblMsg" Visible="false" runat="server" ForeColor="#FF0000" Font-Bold="true" Font-Names="Arial" Font-Size="X-Small"></asp:Label>
    <asp:HiddenField ID="HdnLoginUser" runat="server" />
    <asp:HiddenField ID="HdnDefectID" runat="server" />
    <asp:HiddenField ID="HdnProjectId" runat="server" />
    <asp:HiddenField ID="HdnDefectTypeId" runat="server" />
    <asp:HiddenField ID="HdnEmployeeId" runat="server" />
</div>
    </center>
                    </td>
                </tr>
            </table>
            