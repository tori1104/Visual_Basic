<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
       
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 245px">
    
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
    </form>
</body>
</html>
