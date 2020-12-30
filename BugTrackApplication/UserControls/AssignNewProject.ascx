<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AssignNewProject.ascx.cs" Inherits="BugTrackApplication.UserControls.AssignNewProject" %>
<%@ Register Assembly="GMDatePicker" Namespace="GrayMatterSoft" TagPrefix="cc1" %>
 <table  class="center">
    <tr><td> 
<center>
    <table>
     <tr>
<td style="font-size: 12px; font-family: Arial; width: 228px; text-align: right; ">Application Name:
</td>
    <td style="font-size: 12px; width: 24px; font-family: Arial; text-align: right">
    </td>
<td style="text-align: left">
    <asp:TextBox ID="txtProjectName" Width="177px" OnKeypress="return OnlyChars(event)"  runat="server"></asp:TextBox></td>
<td style="text-align: left">
    <asp:RequiredFieldValidator ID="rfv1" runat="server" ControlToValidate="txtProjectName" ErrorMessage="*" ></asp:RequiredFieldValidator>     </td>  
</tr>
    
<tr>
<td style="font-size: 12px; font-family: Arial; width: 228px; text-align: right; ">Description:
</td>
    <td style="font-size: 12px; width: 24px; font-family: Arial; text-align: right">
    </td>
<td style=" text-align: left"><asp:TextBox ID="txtDescription" TextMode="MultiLine"   runat="server"></asp:TextBox></td>
<td style="text-align: left"><asp:RequiredFieldValidator ID="rfv5" runat="server" ControlToValidate="txtDescription" ErrorMessage="*" ></asp:RequiredFieldValidator>     </td>  
</tr>

     
<tr>
<td style="font-size: 12px; font-family: Arial; width: 228px; text-align: right; ">No of Modules :
</td>
    <td style="font-size: 12px; width: 24px; font-family: Arial; text-align: right">
    </td>
<td style=" text-align: left"><asp:TextBox ID="txtNoOfModules" Width="177px" OnKeypress="return OnlyChars(event)"   runat="server"></asp:TextBox></td>
<td style="text-align: left"><asp:RequiredFieldValidator ID="rfv2" runat="server" ControlToValidate="txtNoOfModules" ErrorMessage="*" ></asp:RequiredFieldValidator>     </td>  
</tr>
     
<tr>
<td style="font-size: 12px; font-family: Arial; width: 228px; text-align: right; ">Client:
</td>
    <td style="font-size: 12px; width: 24px; font-family: Arial; text-align: right">
    </td>
<td style=" text-align: left"><asp:TextBox ID="txtClient" Width="177px" runat="server"></asp:TextBox></td>
<td style="text-align: left"><asp:RequiredFieldValidator ID="rfv4" runat="server" ControlToValidate="txtClient" ErrorMessage="*" ></asp:RequiredFieldValidator>     </td>  
</tr>
     
    <tr>
<td style="font-size: 12px; font-family: Arial; width: 228px; text-align: right; ">Status:
</td>
    <td style="font-size: 12px; width: 24px; font-family: Arial; text-align: right">
    </td>
<td style=" text-align: left"><asp:TextBox ID="txtStatus" Width="177px" runat="server"></asp:TextBox></td>
<td style="text-align: left">    </td>  
</tr>
     
<tr>
<td style="font-size: 12px; font-family: Arial; width: 228px; text-align: right; ">Application Start Date:
</td>
    <td style="font-size: 12px; width: 24px; font-family: Arial; text-align: right">
        
    </td>
<td style=" text-align: left">
    <cc1:GMDatePicker ID="GMStDate" runat="server" CalendarOffsetX="-129px" Style="z-index: 235;
        left: 0px; position: absolute; top: 0px" CalendarTheme="Green" TextBoxWidth="160" InitialValueMode="Null">
    </cc1:GMDatePicker>
</td> 
<td style="text-align: left"><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="GMStDate" ErrorMessage="*" ></asp:RequiredFieldValidator>     </td>  
</tr> 
<tr>
<td style="font-size: 12px; font-family: Arial; width: 228px; text-align: right; ">Application End Date:
</td>
    <td style="font-size: 12px; width: 24px; font-family: Arial; text-align: right">

    </td>
<td style=" text-align: left">
    <cc1:GMDatePicker ID="GM_EdDate" runat="server" CalendarOffsetX="-129px" Style="z-index: 235;
        left: 0px; position: absolute; top: 0px" CalendarTheme="Green" TextBoxWidth="160" InitialValueMode="Null">
    </cc1:GMDatePicker>
</td> 
<td style="text-align: left"><asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="GM_EdDate" ErrorMessage="*" ></asp:RequiredFieldValidator>     </td>  
</tr>
     
<tr>
<td style="font-size: 12px; font-family: Arial; width: 228px; text-align: right; ">Platform:
</td>
    <td style="font-size: 12px; width: 24px; font-family: Arial; text-align: right">
    </td>
<td style=" text-align: left"><asp:TextBox ID="txtPlatform" Width="177px" runat="server"></asp:TextBox></td>
<td style="text-align: left"><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPlatform" ErrorMessage="*" ></asp:RequiredFieldValidator>     </td>  
</tr>
     
     
    <tr>
<td colspan="3" style="font-size: 12px; font-family: Arial; text-align: right;">
<asp:Button ID="btnSubmit" CssClass="btn1"  runat="server" Text="Submit"  OnClick="btnSubmit_Click" />    &nbsp; &nbsp;&nbsp; &nbsp; 
<asp:Button ID="btnClear" CssClass="btn1" runat="server" Text="Clear" CausesValidation="false"  OnClick="btnClear_Click" />
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