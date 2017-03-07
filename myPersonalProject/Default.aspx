<%@ Page Title="" Language="VB" MasterPageFile="~/site.master" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
    <asp:ImageButton ID="ImageButton1" runat="server" Height="193px" ImageUrl="~/assets/me.jpg" Width="139px" CssClass="meImage" />
    <asp:Label ID="Label3" runat="server" Text="Victoria Humphrey"></asp:Label>
    <br />
        <br />
        <br />
        <asp:Button ID="createTable" runat="server" Text="Create Table" />
        <br />
        <br />
        Let&#39;s get started!<br />
        <asp:Button ID="startTB" runat="server" Text="Start" />
    <br />
</div>
</asp:Content>

