<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginUserControl.ascx.cs" Inherits="BugTrackApplication.UserControls.LoginUserControl" %>
<style type="text/css">
    .auto-style1 {
        width: 889px;
    }
</style>
<div >
     <table  class="center">
    <tr><td> 

    <table>
        <tr>
            <td >Username:
            </td>
            <td>
                <asp:TextBox ID="txtLoginName" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLoginName" ErrorMessage="Please Enter Your Username"
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <br />
            </td>
        </tr>
        <tr>
            <td >Password:</td>
            <td>
                <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtPassword" ErrorMessage="Please Enter Your word"
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style2"></td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td>
                <br />
            </td>
        </tr>

    </table>
    <table   class="center">

        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnLogin" runat="server" CssClass="btn1" Text="Log In" OnClick="Button1_Click" />
            </td>

            <td>

                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
     

        </td></tr></table>
</div>
 


