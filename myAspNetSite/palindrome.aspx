<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="palindrome.aspx.vb" Inherits="palindrome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        Enter starting number and end number range.
        <br />
        Then click button to calculate Palindromes.</p>
    <p>
        <asp:Label ID="Label" runat="server" BackColor="#CCFFFF" Text="Enter Starting Number"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="tbStart" runat="server"></asp:TextBox>
    </p>
    <asp:Label ID="Label2" runat="server" BackColor="#CCFFFF" Text="Enter Ending Number"></asp:Label>
    <p>
        <asp:TextBox ID="tbEnd" runat="server" style="margin-top: 0px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="bCalculate" runat="server" Text="Calcualte Palindromes" />
    </p>
    <p>
        <asp:ListBox ID="lbResults" runat="server" BackColor="#CCFFFF" Height="330px" Width="250px"></asp:ListBox>
    </p>
</asp:Content>

