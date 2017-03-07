<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="calculator.aspx.vb" Inherits="calculator" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div>
            <asp:Label ID="lbValue1" runat="server" Text="Value 1"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbValue1" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddOp" runat="server">
            <asp:ListItem>+</asp:ListItem>
            <asp:ListItem>-</asp:ListItem>
            <asp:ListItem>*</asp:ListItem>
            <asp:ListItem>/</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="lbValue2" runat="server" Text="Value 2"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbValue2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btCalculate" runat="server" BackColor="#66FFFF" BorderColor="#333333" Font-Size="Large" Height="38px" Text="Calculate" Width="108px" />
        <br />
        <br />
        <asp:Label ID="lbAnswer" runat="server" Text="Answer"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbTheAnswer" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbAnswer" runat="server" BackColor="#CCCCCC" BorderStyle="Solid" ReadOnly="True" Width="76px"></asp:TextBox>
        <br />
    

</div>


</asp:Content>


