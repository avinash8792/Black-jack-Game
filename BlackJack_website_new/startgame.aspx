<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="startgame.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 102%;
            margin-top: 60px;
            height: 1086px;
        }

        .auto-style2 {
            font-size: large;
            font-weight: bold;
            font-style: normal;
        }

        .auto-style3 {
            width: 178px;
            height: 194px;
        }

        .auto-style4 {
            height: 194px;
        }

        .auto-style13 {
            width: 170px;
        }

        .auto-style14 {
            height: 194px;
            width: 170px;
        }

        .auto-style16 {
            width: 183px;
        }

        .auto-style17 {
            width: 183px;
            height: 194px;
        }

        .auto-style18 {
            width: 178px;
            height: 160px;
        }

        .auto-style19 {
            width: 183px;
            height: 160px;
        }

        .auto-style20 {
            height: 160px;
            width: 170px;
        }

        .auto-style21 {
            height: 160px;
        }

        .auto-style22 {
            width: 178px;
            font-size: large;
            font-weight: bold;
            font-style: normal;
            height: 52px;
        }

        .auto-style23 {
            width: 183px;
            height: 52px;
        }

        .auto-style24 {
            width: 170px;
            height: 52px;
        }

        .auto-style25 {
            height: 52px;
        }

        .auto-style26 {
            width: 178px;
            font-size: large;
            font-weight: bold;
            font-style: normal;
            height: 76px;
        }

        .auto-style27 {
            width: 183px;
            height: 76px;
        }

        .auto-style28 {
            width: 170px;
            height: 76px;
        }

        .auto-style29 {
            height: 76px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="text-align: right; font-size: larger; font-weight: bold; margin-top: 30px">
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label><br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Login.aspx">Logout</asp:HyperLink>  
    </div>

  
    <table class="auto-style1">
        <%--<tr>
            <td class="auto-style2">
                
            </td>
            
        </tr>--%>
        <tr>
            <td class="auto-style2">Your balance:</td>
            <td class="auto-style16">
                <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
            </td>

        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style13">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style22">Enter Bet Amount</td>
            <td class="auto-style23">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style24"></td>
            <td class="auto-style25"></td>
        </tr>
        <tr>
            <td class="auto-style26"></td>
            <td class="auto-style27">
                <asp:Button ID="Button1" runat="server" Text="Start" OnClick="Button1_Click" BackColor="green" Height="40px" Width="80px" BorderColor="green" Style="text-align: center" />
            </td>
            <td class="auto-style28"></td>
            <td class="auto-style29"></td>
        </tr>
        <tr>
            <td class="auto-style2" >
                <asp:Label ID="Label7" runat="server" Text="User Side" Visible="false"></asp:Label>
            </td>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style13">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2" style="font-size: medium" colspan="4">
                <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
            </td>
            <%-- <td class="auto-style16">&nbsp;</td>
            <td class="auto-style13">&nbsp;</td>--%>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Image ID="User1" runat="server" Height="100px" Width="100px" Visible="false" />
            </td>
            <td class="auto-style17">
                <asp:Image ID="User2" runat="server" Height="100px" Width="100px" Visible="false" />
            </td>
            <td class="auto-style14">
                <asp:Image ID="User3" runat="server" Height="100px" Width="100px" Visible="false" />
            </td>
            <td class="auto-style4">
                <asp:Image ID="User4" runat="server" Height="100px" Width="100px" Visible="false" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Image ID="User5" runat="server" Height="100px" Width="100px" Visible="false" />
            </td>
            <td class="auto-style17">
                <asp:Image ID="User6" runat="server" Height="100px" Width="100px" Visible="false" />
            </td>
            <td class="auto-style14">
                <asp:Image ID="User7" runat="server" Height="100px" Width="100px" Visible="false" />
            </td>
            <td class="auto-style4">
                <asp:Image ID="User8" runat="server" Height="100px" Width="100px" Visible="false" />
            </td>
        </tr>

        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label8" runat="server" Text="Dealer Side" Visible="false"></asp:Label>
            </td>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style13">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label5" runat="server" Text="" EnableViewState="false"></asp:Label>
            </td>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style13">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style18">
                <asp:Image ID="Dealer1" runat="server" Height="100px" Width="100px" Visible="false" />
            </td>
            <td class="auto-style19">
                <asp:Image ID="Dealer2" runat="server" Height="100px" Width="100px" Visible="false" />
            </td>
            <td class="auto-style20">
                <asp:Image ID="Dealer3" runat="server" Height="100px" Width="100px" Visible="false" />
            </td>
            <td class="auto-style21">
                <asp:Image ID="Dealer4" runat="server" Height="100px" Width="100px" Visible="false" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Image ID="Dealer5" runat="server" Height="100px" Width="100px" Visible="false" />
            </td>
            <td class="auto-style16">
                <asp:Image ID="Dealer6" runat="server" Height="100px" Width="100px" Visible="false" />
            </td>
            <td class="auto-style13">
                <asp:Image ID="Dealer7" runat="server" Height="100px" Width="100px" Visible="false" />
            </td>
            <td>
                <asp:Image ID="Dealer8" runat="server" Height="100px" Width="100px" Visible="false" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style13">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style13">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style16">
                <asp:Button ID="Button2" runat="server" Text="Hit" OnClick="Button2_Click" Visible="false" BackColor="green" Height="40px" Width="80px" BorderColor="green" Style="text-align: center" />
            </td>
            <td class="auto-style13">
                <%--<asp:Button ID="Button5" runat="server" Text="Stand" OnClick="Button3_Click" Visible="false" BackColor="green" Height="40px" Width="80px" BorderColor="green" Style="text-align: center" />--%>
                <asp:ImageButton ID="Button3" runat="server" ImageUrl="~/Images/stand1.jpg" OnClick="Button3_Click" Visible="false"  Height="36px" Width="90px"/>
            </td>
            <td>
                
                <%--<asp:Button ID="Button4" runat="server" Text="Play Again" Visible="false" BackColor="green" Height="40px" Width="80px" BorderColor="green" Style="text-align: center" OnClick="Button4_Click1" />--%>
                <asp:ImageButton ID="Button4" runat="server" visible="false" ImageUrl="~/Images/playagain.jpg" height="36px" Width="90px" OnClick="ImageButton1_Click"/>
                
            </td>
        </tr>
        <tr>
            <td class="auto-style2" colspan="4">
                <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>




</asp:Content>

