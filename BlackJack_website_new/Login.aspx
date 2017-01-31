<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 80%;
            border:solid;
            border-radius:2px;
            border-width:medium;
            
        }

        .auto-style2 {
            text-align: right;
            width: 325px;
            font-size :x-large;
            font-weight:bold;
            font-style :normal;
            height: 29px;
        }

        .auto-style3 {
            width: 325px;
        }
        .auto-style4 {
            text-align: right;
            width: 325px;
            font-size : x-large;
            font-weight: bold;
            font-style : normal;
            height: 57px;
        }
        .auto-style5 {
            height: 57px;
            width: 342px;
        }
        .auto-style6 {
            text-align: right;
            width: 325px;
            font-size : x-large;
            font-weight: bold;
            font-style : normal;
            height: 53px;
        }
        .auto-style7 {
            height: 53px;
            width: 342px;
        }
        .auto-style8 {
            width: 325px;
            height: 80px;
        }
        .auto-style9 {
            width: 342px;
            height: 80px;
        }
        .auto-style10 {
            width: 342px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <asp:LoginName ID="LoginName1" runat="server" />

    <table class="auto-style1" style="margin-top: 100px;margin-left:70px" border="0">
        <tr>
            <td class="auto-style4">User Name</td>
            <td class="auto-style5">&nbsp;<asp:TextBox ID="TextBox1" runat="server" Style="border:solid; border-radius:4px;border-color:white"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style6" >Password</td>
            <td class="auto-style7">&nbsp;<asp:TextBox ID="TextBox2" runat="server" Style="border:solid; border-radius:4px;border-color:white" TextMode="Password"></asp:TextBox></td>
        </tr>
       
        <tr style="margin-top:50px">
            <td class="auto-style8"></td>
            <td class="auto-style9">
                <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click1" BackColor="green" Height="40px" Width="80px" BorderColor="green" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style10" >
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Register.aspx" Font-Bold="true" ForeColor="WhiteSmoke" Font-Italic="true" Font-Size="Larger" Font-Underline="true">New User??</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;<asp:Label ID="Label1" runat="server" Text=""></asp:Label></td>

        </tr>
    </table>
</asp:Content>


