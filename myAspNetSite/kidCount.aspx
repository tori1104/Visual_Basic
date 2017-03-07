<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="kidCount.aspx.vb" Inherits="kidCount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Enter of families"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="tbNumFam" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="bCompute" runat="server" Text="Compute number of kids to create one boy per family." />
        <br />
        <br />
        <br />
        <asp:Label ID="lbBoys" runat="server" Text="Numer of Boys"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lbGirls" runat="server" Text="Number of Girls"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lbKids" runat="server" Text="Total number of Kids"></asp:Label>
        <br />
        <br />
    
    </div>
 
</asp:Content>

