<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="AddStats.aspx.cs" Inherits="HockeyNicholasNieto.AddStats" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <asp:Label ID="Label1" runat="server" Text="Players Name:"></asp:Label>
    <br />
    <asp:DropDownList ID="displayPlayer" runat="server" Height="24px" Width="325px" AutoPostBack="True">
    </asp:DropDownList>
</p>
<p>
    <asp:Label ID="Label2" runat="server" Text="Matches Won:"></asp:Label>
</p>
<p>
    <asp:TextBox ID="txtMatchesWon" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label3" runat="server" Text="Matches Played"></asp:Label>
</p>
<p>
    <asp:TextBox ID="txtMatchsPlayed" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label4" runat="server" Text="Assists:"></asp:Label>
</p>
<p>
    <asp:TextBox ID="txtAssists" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label5" runat="server" Text="Goals:"></asp:Label>
</p>
<p>
    <asp:TextBox ID="txtGoals" runat="server"></asp:TextBox>
</p>
<asp:Button ID="btnAddStats" runat="server" Height="32px" Text="Add" Width="100px" OnClick="btnAddStats_Click" />
<p>
    <asp:Label ID="lblMessage" runat="server"></asp:Label>
</p>
</asp:Content>
