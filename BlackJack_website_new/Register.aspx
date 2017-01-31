<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 265px;
            text-align: center;
        }
        .auto-style4 {
            width: 205px;
        }
        .auto-style5 {
            width: 265px;
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 
    <table class="auto-style1" style="margin-top:100px">
        <tr>
            <td class="auto-style5">User Name</td>
            <td class="auto-style4">
                <asp:TextBox ID="TextBox1" runat="server" Width="198px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">Password</td>
            <td class="auto-style4">
                <asp:TextBox ID="TextBox2" runat="server" Width="198px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">Retype Password</td>
            <td class="auto-style4">
                <asp:TextBox ID="TextBox3" runat="server" Width="198px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style4">&nbsp;<asp:Button ID="Button1" runat="server" style="text-align: right" Text="Sign Up" OnClick="Button1_Click1" BackColor="green" Height="40px" Width="80px" BorderColor="green" />
            </td>
            
        </tr>
         <tr>
            <td class="auto-style3">&nbsp;<asp:Label ID="Label1" runat="server" Text=""></asp:Label></td>
          
            
        </tr>
    
    </table>

    
    

</asp:Content>

