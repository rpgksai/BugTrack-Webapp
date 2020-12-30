<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserRegistration.ascx.cs" Inherits="BugTrackApplication.UserControls.UserRegistration" %>
<%@ Register Assembly="GMDatePicker" Namespace="GrayMatterSoft" TagPrefix="cc1" %>
<style type="text/css">
    .auto-style1 {
        width: 128px;
    }
</style>

   <table  class="center">
    <tr><td> 
 <center>
<table>
<tr><td  style="font-size: 12px; font-family: Arial; width: 128px; text-align: right;  font-weight: bold; "> Personal Details:</td></tr>

<tr>
<td style="font-size: 12px; font-family: Arial; width: 128px; text-align: right; ">First Name:
</td>
    <td style="font-size: 12px; width: 24px; font-family: Arial; text-align: right">
    </td>
<td style="text-align: left">
    <asp:TextBox ID="txtFName" Width="177px" OnKeypress="return OnlyChars(event)"  runat="server"></asp:TextBox></td>
<td style="text-align: left">
    <asp:RequiredFieldValidator ID="rfv1" runat="server" ControlToValidate="txtFName" ErrorMessage="*" ></asp:RequiredFieldValidator>     </td>  
</tr>
<tr>
<td style="font-size: 12px; font-family: Arial; width: 128px; text-align: right; ">Last Name:
</td>
    <td style="font-size: 12px; width: 24px; font-family: Arial; text-align: right">
    </td>
<td style=" text-align: left"><asp:TextBox ID="txtLName" Width="177px" OnKeypress="return OnlyChars(event)"   runat="server"></asp:TextBox></td>
<td style="text-align: left"><asp:RequiredFieldValidator ID="rfv2" runat="server" ControlToValidate="txtLName" ErrorMessage="*" ></asp:RequiredFieldValidator>     </td>  
</tr>
<tr>
<td style="font-size: 12px; font-family: Arial; width: 128px; text-align: right; " valign="middle">Gender:
</td>
    <td style="font-size: 12px; width: 24px; font-family: Arial; text-align: right"
        valign="middle">
    </td>
<td style="height: 38px;  text-align: left;"><asp:RadioButtonList Width="179px"  ID="rblGender" runat="server"  RepeatDirection="Horizontal">
    <asp:ListItem>Male</asp:ListItem>
    <asp:ListItem>Female</asp:ListItem>
</asp:RadioButtonList></td>   
<td style="height: 38px; text-align: left;"><asp:RequiredFieldValidator ID="rfv3" runat="server" ControlToValidate="rblGender" ErrorMessage="*" ></asp:RequiredFieldValidator>     </td>  
</tr>
<tr>
<td style="font-size: 12px; font-family: Arial; width: 128px; text-align: right; ">Qualification:
</td>
    <td style="font-size: 12px; width: 24px; font-family: Arial; text-align: right">
    </td>
<td style=" text-align: left"><asp:TextBox ID="txtQualification" Width="177px" runat="server"></asp:TextBox></td>
<td style="text-align: left"><asp:RequiredFieldValidator ID="rfv4" runat="server" ControlToValidate="txtQualification" ErrorMessage="*" ></asp:RequiredFieldValidator>     </td>  
</tr>
<tr>
<td style="font-size: 12px; font-family: Arial; width: 128px; text-align: right; ">DateOfJoin:
</td>
    <td style="font-size: 12px; width: 24px; font-family: Arial; text-align: right">
    </td>
<td style=" text-align: left">
    <cc1:GMDatePicker ID="GMDate" runat="server" CalendarOffsetX="-129px" Style="z-index: 235;
        left: 0px; position: absolute; top: 0px" CalendarTheme="Green" TextBoxWidth="160" InitialValueMode="Null">
    </cc1:GMDatePicker>
</td> 
<td style="text-align: left"><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="GMDate" ErrorMessage="*" ></asp:RequiredFieldValidator>     </td>  
</tr>
    
<tr>
<td style="font-size: 12px; font-family: Arial; width: 128px; text-align: right; ">Designation:
</td>
    <td style="font-size: 12px; width: 24px; font-family: Arial; text-align: right">
    </td>
<td style=" text-align: left"><asp:TextBox ID="txtDesignation" Width="177px" runat="server"></asp:TextBox></td>
<td style="text-align: left"><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtDesignation" ErrorMessage="*" ></asp:RequiredFieldValidator>     </td>  
</tr>
<tr>
<td style="font-size: 12px; font-family: Arial; width: 128px; text-align: right; ">Address:
</td>
    <td style="font-size: 12px; width: 24px; font-family: Arial; text-align: right">
    </td>
<td style=" text-align: left"><asp:TextBox ID="txtAddress" TextMode="MultiLine"   runat="server"></asp:TextBox></td>
<td style="text-align: left"><asp:RequiredFieldValidator ID="rfv5" runat="server" ControlToValidate="txtAddress" ErrorMessage="*" ></asp:RequiredFieldValidator>     </td>  
</tr>
<tr>
<td style="font-size: 12px; font-family: Arial; width: 128px; text-align: right; ">EmailId:
</td>
    <td style="font-size: 12px; width: 24px; font-family: Arial; text-align: right">
    </td>
<td style=" text-align: left"><asp:TextBox ID="txtEmail" Width="177px"    runat="server"></asp:TextBox></td>
<td style="text-align: left"><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtEmail" ErrorMessage="*" ></asp:RequiredFieldValidator> 
<asp:RegularExpressionValidator ID="rex1" runat="server" ControlToValidate="txtEmail" ErrorMessage="*" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ></asp:RegularExpressionValidator>        </td>  
</tr>
<tr>
<td style="font-size: 12px; font-family: Arial; width: 128px; text-align: right; ">ContactNo:
</td>
    <td style="font-size: 12px; width: 24px; font-family: Arial; text-align: right">
    </td>
<td style=" text-align: left"><asp:TextBox ID="txtContactNo" Width="177px" OnKeypress="return onlyNumbers(event)"   runat="server" MaxLength="10"></asp:TextBox></td>
<td style="text-align: left"><asp:RequiredFieldValidator ID="rfv07" runat="server" ControlToValidate="txtContactNo" ErrorMessage="*" ></asp:RequiredFieldValidator>     </td>  
</tr>
   <tr><td style="font-size: 12px; font-family: Arial; width: 128px; text-align: right;  font-weight: bold;">Login Details: </td></tr>
<tr>
<td style="font-size: 12px; font-family: Arial; width: 128px; text-align: right; ">UserName:
</td>
    <td style="font-size: 12px; width: 24px; font-family: Arial; text-align: right">
    </td>
<td style=" text-align: left"><asp:TextBox ID="txtUserName" MaxLength="10"  Width="177px" runat="server"></asp:TextBox></td>
<td style="text-align: left"><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtUserName" ErrorMessage="*" ></asp:RequiredFieldValidator>     </td>  
<td><asp:LinkButton ID="lbCheck" runat="server" Text ="Check Availability" ForeColor="#FF0000" CausesValidation="false"   Font-Bold="true" Font-Names="Arial" Font-Size="X-Small" OnClick="lbCheck_Click" ></asp:LinkButton> </td>
</tr>
   
<tr>
<td style="font-size: 12px; font-family: Arial; width: 128px; text-align: right; ">Password:
</td>
    <td style="font-size: 12px; width: 24px; font-family: Arial; text-align: right">
    </td>
<td style=" text-align: left"><asp:TextBox ID="txtPassword" Width="177px" TextMode="Password" MaxLength="6"    runat="server"></asp:TextBox></td>
<td style="text-align: left"><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtPassword" ErrorMessage="*" ></asp:RequiredFieldValidator>     </td>  
</tr>
     <tr><td  style="font-size: 12px; font-family: Arial; width: 128px; text-align: right;  font-weight: bold;">Employee Role:</td></tr>
<tr>
<td style="font-size: 12px; font-family: Arial; text-align: right; " class="auto-style1">Role:
</td>
    <td style="font-size: 12px; width: 24px; font-family: Arial; text-align: right">
    </td>
<td style=" text-align: left"><asp:DropDownList ID="ddlRole" Width="177px"  runat="server">
</asp:DropDownList>   </td>
<td style="text-align: left"><asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtPassword" ErrorMessage="*" ></asp:RequiredFieldValidator>     </td>  
</tr>
<tr>
<td colspan="3" style="font-size: 12px; font-family: Arial; text-align: right;">
<asp:Button ID="btnSubmit" CssClass="btn1"  runat="server" Text="Submit"  OnClick="btnSubmit_Click" />    &nbsp; &nbsp;&nbsp; &nbsp; 
<asp:Button ID="btnClear" CssClass="btn1" runat="server" Text="Cancel" CausesValidation="false"  OnClick="btnClear_Click" />
  </td>
</tr>
</table> 
<table>
<tr>
<td><asp:Label ID="lblMsg" Visible="false"  runat="server" ForeColor="#FF0000"   Font-Bold="true" Font-Names="Arial" Font-Size="X-Small" ></asp:Label>  </td>
</tr>
</table>
</center>
       
        </td></tr></table>