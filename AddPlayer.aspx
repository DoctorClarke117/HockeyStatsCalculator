<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="AddPlayer.aspx.cs" Inherits="HockeyNicholasNieto.AddPlayer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <asp:Label ID="Label1" runat="server" Text="Player Name:"></asp:Label>
    <br />
    <asp:TextBox ID="txtPlayerName" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Must Not Be Empty!" ControlToValidate="txtPlayerName"></asp:RequiredFieldValidator>
</p>
<p>
</p>
<asp:Label ID="Label2" runat="server" Text="Jersey Number:"></asp:Label>
<p>
    <asp:TextBox ID="txtJerseyNumber" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Must Not Be Empty!" ControlToValidate="txtJerseyNumber"></asp:RequiredFieldValidator>
</p>
<asp:Label ID="lblMessage" runat="server"></asp:Label>
<p>
    <asp:Button ID="btnAddPlayer" runat="server" Text="Add Player" OnClick="btnAddPlayer_Click" />
</p>
</asp:Content>
