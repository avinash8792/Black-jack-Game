<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1" style="margin-top:150px; margin-left:250px">
        <tr>
            <td>    
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/playnow.jpg" OnClick="ImageButton1_Click"/>
            </td>
        </tr>
    </table>

</asp:Content>

