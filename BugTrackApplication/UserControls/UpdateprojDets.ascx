<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UpdateprojDets.ascx.cs" Inherits="BugTrackApplication.UserControls.UpdateprojDets" %>
<%@ Register Assembly="GMDatePicker" Namespace="GrayMatterSoft" TagPrefix="cc1" %>
<center>
<table>
<tr>
<td colspan="6">
    <strong>New Application FORM</strong></td>
</tr>

<tr>
<td colspan="5" style="font-size: 14px; font-family: Verdana">
    <strong>APplication DETAILS</strong></td>
</tr>
    </table>
<table>
     <tr><td><br /></td></tr>
<tr>
<td style="font-size: 12px; font-family: Verdana; width: 128px; text-align: right; font-weight: bold;">Application Name:
</td>
    <td style="font-size: 12px; width: 24px; font-family: Verdana; text-align: right">
    </td>
<td style="text-align: left">
    <asp:TextBox ID="txtProjectName" Width="177px" OnKeypress="return OnlyChars(event)"  runat="server"></asp:TextBox></td>
<td style="text-align: left">
    <asp:RequiredFieldValidator ID="rfv1" runat="server" ControlToValidate="txtProjectName" ErrorMessage="*" ></asp:RequiredFieldValidator>     </td>  
</tr>
    <tr><td><br /></td></tr>
<tr>
<td style="font-size: 12px; font-family: Verdana; width: 128px; text-align: right; font-weight: bold;">Description:
</td>
    <td style="font-size: 12px; width: 24px; font-family: Verdana; text-align: right">
    </td>
<td style=" text-align: left"><asp:TextBox ID="txtDescription" TextMode="MultiLine"   runat="server"></asp:TextBox></td>
<td style="text-align: left"><asp:RequiredFieldValidator ID="rfv5" runat="server" ControlToValidate="txtDescription" ErrorMessage="*" ></asp:RequiredFieldValidator>     </td>  
</tr>

     <tr><td><br /></td></tr>
<tr>
<td style="font-size: 12px; font-family: Verdana; width: 128px; text-align: right; font-weight: bold;">No of Modules :
</td>
    <td style="font-size: 12px; width: 24px; font-family: Verdana; text-align: right">
    </td>
<td style=" text-align: left"><asp:TextBox ID="txtNoOfModules" Width="177px" OnKeypress="return OnlyChars(event)"   runat="server"></asp:TextBox></td>
<td style="text-align: left"><asp:RequiredFieldValidator ID="rfv2" runat="server" ControlToValidate="txtNoOfModules" ErrorMessage="*" ></asp:RequiredFieldValidator>     </td>  
</tr>
     <tr><td><br /></td></tr>
<tr>
<td style="font-size: 12px; font-family: Verdana; width: 128px; text-align: right; font-weight: bold;">Client:
</td>
    <td style="font-size: 12px; width: 24px; font-family: Verdana; text-align: right">
    </td>
<td style=" text-align: left"><asp:TextBox ID="txtClient" Width="177px" runat="server"></asp:TextBox></td>
<td style="text-align: left"><asp:RequiredFieldValidator ID="rfv4" runat="server" ControlToValidate="txtClient" ErrorMessage="*" ></asp:RequiredFieldValidator>     </td>  
</tr>
     <tr><td><br /></td></tr>
    <tr>
<td style="font-size: 12px; font-family: Verdana; width: 128px; text-align: right; font-weight: bold;">Status:
</td>
    <td style="font-size: 12px; width: 24px; font-family: Verdana; text-align: right">
    </td>
<td style=" text-align: left"><asp:TextBox ID="txtStatus" Width="177px" runat="server"></asp:TextBox></td>
<td style="text-align: left">    </td>  
</tr>
     <tr><td><br /></td></tr>
<tr>
<td style="font-size: 12px; font-family: Verdana; width: 128px; text-align: right; font-weight: bold;">Application Start Date:
</td>
    <td style="font-size: 12px; width: 24px; font-family: Verdana; text-align: right">
        
    </td>
<td style=" text-align: left">
<asp:TextBox ID="txtStDate" runat="server"></asp:TextBox>
    <%--<cc1:GMDatePicker ID="GMStDate" runat="server" CalendarOffsetX="-129px" Style="z-index: 235;
        left: 0px; position: absolute; top: 0px" CalendarTheme="Green" TextBoxWidth="160" InitialValueMode="Null">
    </cc1:GMDatePicker>--%>
</td> 
<td style="text-align: left"></td>  
</tr> <tr><td><br /></td></tr>
<tr>
<td style="font-size: 12px; font-family: Verdana; width: 128px; text-align: right; font-weight: bold;">Application End Date:
</td>
    <td style="font-size: 12px; width: 24px; font-family: Verdana; text-align: right">

    </td>
<td style=" text-align: left">
    <asp:TextBox ID="TxtEdDate" runat="server"></asp:TextBox>
 <%--   <cc1:GMDatePicker ID="GM_EdDate" runat="server" CalendarOffsetX="-129px" Style="z-index: 235;
        left: 0px; position: absolute; top: 0px" CalendarTheme="Green" TextBoxWidth="160" InitialValueMode="Null">
    </cc1:GMDatePicker>--%>
</td> 
<td style="text-align: left"></td>  
</tr>
     <tr><td><br /></td></tr>
<tr>
<td style="font-size: 12px; font-family: Verdana; width: 128px; text-align: right; font-weight: bold;">Platform:
</td>
    <td style="font-size: 12px; width: 24px; font-family: Verdana; text-align: right">
    </td>
<td style=" text-align: left"><asp:TextBox ID="txtPlatform" Width="177px" runat="server"></asp:TextBox></td>
<td style="text-align: left"><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPlatform" ErrorMessage="*" ></asp:RequiredFieldValidator>     </td>  
</tr>
     
     <tr><td><br /></td></tr>
    <tr>
<td colspan="3" style="font-size: 12px; font-family: Verdana; text-align: right;">
<asp:Button ID="btnSubmit" CssClass="btn1"  runat="server" Text="Submit"  OnClick="btnSubmit_Click" />    &nbsp; &nbsp;&nbsp; &nbsp; 
<asp:Button ID="btnClear" CssClass="btn1" runat="server" Text="Cancel" CausesValidation="false"  OnClick="btnClear_Click" />
  </td>
</tr>
</table> 
<table>
<tr>
<td><asp:Label ID="lblMsg" Visible="false"  runat="server" ForeColor="#FF0000"   Font-Bold="true" Font-Names="Verdana" Font-Size="X-Small" ></asp:Label>  </td>
</tr>
</table>
</center>
