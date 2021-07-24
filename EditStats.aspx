<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="EditStats.aspx.cs" Inherits="HockeyNicholasNieto.EditStats" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Search Player:"></asp:Label>
</p>
<p>
    <asp:TextBox ID="txtSearchPlayers" runat="server" AutoPostBack="True"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Must Not Be Empty!" ControlToValidate="txtSearchPlayers"></asp:RequiredFieldValidator>
</p>
<p>
    <asp:Label ID="Label2" runat="server" Text="Matches Players:"></asp:Label>
</p>
<p>
    <asp:RadioButtonList ID="rdioMatchesPlayers" runat="server">
    </asp:RadioButtonList>
</p>
<p>
    <asp:Label ID="Label6" runat="server" Text="Matches Won:"></asp:Label>
</p>
<p>
    <asp:TextBox ID="txtMatchesWon" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Must Not Be Empty!" ControlToValidate="txtMatchesWon"></asp:RequiredFieldValidator>
</p>
<p>
    <asp:Label ID="Label3" runat="server" Text="Matches Played"></asp:Label>
</p>
<p>
    <asp:TextBox ID="txtMatchsPlayed" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Must Not Be Empty!" ControlToValidate="txtMatchsPlayed"></asp:RequiredFieldValidator>
</p>
<p>
    <asp:Label ID="Label4" runat="server" Text="Assists:"></asp:Label>
</p>
<p>
    <asp:TextBox ID="txtAssists" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Must Not Be Empty!" ControlToValidate="txtAssists"></asp:RequiredFieldValidator>
</p>
<p>
    <asp:Label ID="Label5" runat="server" Text="Goals:"></asp:Label>
</p>
<p>
    <asp:TextBox ID="txtGoals" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Must Not be Empty!" ControlToValidate="txtGoals"></asp:RequiredFieldValidator>
</p>
<p>
    <asp:Label ID="lblMessage" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</p>
<p>
    <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
</p>
<p>
    <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
</p>
<p>
</p>
</asp:Content>
