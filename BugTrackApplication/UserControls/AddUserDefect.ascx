<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AddUserDefect.ascx.cs" Inherits="BugTrackApplication.UserControls.AddUserDefect" %>



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
            <td style="font-size: 12px; font-family: Verdana">User AccountId:</td>
            <td align="left">
               <asp:Label ID="LblLoginId" runat="server"></asp:Label>
            </td>
            <td>
                <%--<asp:RequiredFieldValidator ID="rfv1" ErrorMessage="*" ControlToValidate="txtUserId" runat="server"></asp:RequiredFieldValidator>--%>
            </td>
            <td style="font-size: 12px; font-family: Verdana">User Name:</td>
            <td align="left">
                <asp:Label ID="LblLoginUserName" runat="server"></asp:Label>
            </td>
            <td>
               <%-- <asp:RequiredFieldValidator ID="rv2" ErrorMessage="*" ControlToValidate="txtUserName" runat="server"></asp:RequiredFieldValidator>--%>
            </td>
        </tr>
        <tr>
            <td style="font-size: 12px; font-family: Verdana">Application Name:</td>
            <td align="left">
                <%--<asp:TextBox ID="txtProjectName" runat="server"></asp:TextBox>--%>
                <asp:DropDownList ID="ddlProjectName" runat="server"></asp:DropDownList>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="Rfv3" ErrorMessage="*" ControlToValidate="ddlProjectName" runat="server"></asp:RequiredFieldValidator>
            </td>
            <td style="font-size: 12px; font-family: Verdana">Module Name:</td>
            <td align="left">
                <asp:TextBox ID="txtModuleName" Width="160px" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RFV4" ErrorMessage="*" ControlToValidate="txtModuleName" runat="server"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="font-size: 12px; font-family: Verdana">Defect Title:</td>
            <td align="left">
                <asp:TextBox ID="txtDefectName" runat="server" ></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RFV5" ErrorMessage="*" ControlToValidate="txtDefectName" runat="server"></asp:RequiredFieldValidator>
            </td>
            <td style="font-size: 12px; font-family: Verdana">Defect Category:</td>
            <td align="left">
               <%-- <asp:TextBox ID="txtDefectTypeName"  Width="160px" runat="server"></asp:TextBox>
              --%>  <asp:DropDownList ID="ddlDefectTypeName" runat="server" AutoPostBack="true">
                </asp:DropDownList>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="Rfv6" ErrorMessage="*" ControlToValidate="ddlDefectTypeName" runat="server"></asp:RequiredFieldValidator>
            </td>
        </tr>

        <tr>
            <td style="font-size: 12px; font-family: Verdana">Severity:</td>
            <td align="left">
                <asp:TextBox ID="txtPriority" runat="server" ></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ErrorMessage="*" ControlToValidate="txtPriority" runat="server"></asp:RequiredFieldValidator>
            </td>
            <td style="font-size: 12px; font-family: Verdana">Status:</td>
            <td align="left">
                <asp:RadioButtonList ID="rblStatus" RepeatDirection="Horizontal" runat="server">
                    <asp:ListItem Selected="True">Pending</asp:ListItem>
                    <asp:ListItem Enabled="false">Completed</asp:ListItem>
                </asp:RadioButtonList></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ErrorMessage="*" ControlToValidate="rblStatus" runat="server"></asp:RequiredFieldValidator>
            </td>
        </tr>

        <tr>
            <td style="font-size: 12px; font-family: Verdana">Assigned To:</td>
            <td align="left">
                <asp:DropDownList ID="ddlAssignedTo" runat="server" AutoPostBack="true">
                </asp:DropDownList>
                 <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ErrorMessage="*" ControlToValidate="ddlAssignedTo" runat="server"></asp:RequiredFieldValidator>
            </td>
            <td style="font-size: 12px; font-family: Verdana">Assigned Date:</td>
            <td align="left">
                <asp:TextBox ID="TxtAssignedDate" ReadOnly="true" runat="server"></asp:TextBox>
               
            </td>

            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ErrorMessage="*" ControlToValidate="TxtAssignedDate" runat="server"></asp:RequiredFieldValidator>
            </td>
        </tr>

        <tr>
            <td>Description:</td>
            <td align="left" colspan="7">
                <asp:TextBox ID="txtDescription" Height="150" Width="527px" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfv7" ErrorMessage="*" ControlToValidate="txtDescription" runat="server"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnVerify" runat="server" CssClass="btn1" Text="Verify" OnClientClick="return confirm('R U Verified Defect !!!!')" OnClick="AddDefect_Click" />
            </td>
            <td>
                <asp:Button ID="btnCancel" runat="server" CssClass="btn1" Text="Cancel" OnClick="CancelMe"  />

            </td>


        </tr>
    </table>
</div>
<div>
    <asp:Label ID="lblMsg" Visible="false" runat="server" ForeColor="#FF0000" Font-Bold="true" Font-Names="Verdana" Font-Size="X-Small"></asp:Label>
    <asp:HiddenField ID="HdnLoginUser" runat="server" />
    <asp:HiddenField ID="HdnDefectID" runat="server" />
    <asp:HiddenField ID="HdnProjectId" runat="server" />
    <asp:HiddenField ID="HdnDefectTypeId" runat="server" />
    <asp:HiddenField ID="HdnEmployeeId" runat="server" />
</div>
</center>
</td>
  </tr></table>
