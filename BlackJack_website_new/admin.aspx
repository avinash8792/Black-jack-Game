<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="admin.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 358px;
        }
        .auto-style3 {
            width: 358px;
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <table class="auto-style1" style="margin-top:100px;margin-left:150px">
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label3" runat="server" Text="" Font-Bold="true" Font-Size="Larger" ></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="minLabel" runat="server" Text="Set Minimum Bet" Visible="false"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Visible="false"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="maxLabel" runat="server" Text="Set Maximum Bet" Visible="false"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Visible="false"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Set" OnClick="Button1_Click"  Visible="false"/>
            </td>
        </tr>
    </table>


</asp:Content>

