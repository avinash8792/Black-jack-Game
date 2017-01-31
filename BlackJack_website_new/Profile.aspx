<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Profile.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="text-align:right;font-size:larger;font-weight:bold;margin-top:30px">
    <asp:Label ID="Label4" runat="server"  ForeColor="White" Text=""  ></asp:Label>
        </div>
    <table class="auto-style1" style="margin-top:40px;margin-left:150px">
     
        <tr>
            <td>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="changepassword.aspx"  Font-Bold="true" ForeColor="WhiteSmoke" Font-Italic="true" Font-Size="Larger" Font-Underline="true">Change Password </asp:HyperLink>
    
            </td>
        </tr>
        <tr>
            <td>
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Addfunds.aspx" Font-Bold="true" ForeColor="WhiteSmoke" Font-Italic="true" Font-Size="Larger" Font-Underline="true">Add Funds</asp:HyperLink>
    
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
            </td>
        </tr>
       
    </table>
    
</asp:Content>

