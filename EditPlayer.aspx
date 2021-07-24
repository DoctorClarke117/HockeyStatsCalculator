<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="EditPlayer.aspx.cs" Inherits="HockeyNicholasNieto.EditPlayer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
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
    <asp:Label ID="Label6" runat="server" Text="Player Name:"></asp:Label>
</p>
<p>
    <asp:TextBox ID="txtEditPlayerName" runat="server" ValidationGroup="EditPlayer"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Must Not Be Empty!" ControlToValidate="txtEditPlayerName" ValidationGroup="EditPlayer"></asp:RequiredFieldValidator>
</p>
<p>
    <asp:Label ID="Label3" runat="server" Text="Jersey Number:"></asp:Label>
</p>
<p>
    <asp:TextBox ID="txtEditJerseyNumber" runat="server" ValidationGroup="EditPlayer"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Must Not Be Empty!" ControlToValidate="txtEditJerseyNumber" ValidationGroup="EditPlayer"></asp:RequiredFieldValidator>
</p>
<br />
<asp:Label ID="lblTest" runat="server"></asp:Label>
<br />
<asp:Label ID="lblEditMessage" runat="server"></asp:Label>
<p>
    <asp:Button ID="btnEditPlayer" runat="server" Text="Edit Player" OnClick="btnAddPlayer_Click" ValidationGroup="EditPlayer" />
    <asp:Button ID="btnDeletePlayer" runat="server" Text="Delete Player" OnClick="btnDeletePlayer_Click" />
</p>
</asp:Content>
