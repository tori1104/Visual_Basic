<%@ Page Title="" Language="VB" MasterPageFile="~/site.master" AutoEventWireup="false" CodeFile="pollPage.aspx.vb" Inherits="pollPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
<asp:TextBox ID="fTB" runat="server"></asp:TextBox>
<asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label>
<asp:TextBox ID="lTB" runat="server"></asp:TextBox>
<br />
<br />
<asp:Label ID="Label3" runat="server" Text="Favorite Show"></asp:Label>
<asp:TextBox ID="favShowTB" runat="server"></asp:TextBox>
<br />
<br />
<asp:Label ID="Label4" runat="server" Text="Genre"></asp:Label>
<asp:DropDownList ID="favShowDD" runat="server">
    <asp:ListItem>Action</asp:ListItem>
    <asp:ListItem>Animation</asp:ListItem>
    <asp:ListItem>Comedy</asp:ListItem>
    <asp:ListItem>Documentary</asp:ListItem>
    <asp:ListItem>Family</asp:ListItem>
    <asp:ListItem>Film-Noir</asp:ListItem>
    <asp:ListItem>Horror</asp:ListItem>
    <asp:ListItem>Musical</asp:ListItem>
    <asp:ListItem>Romance</asp:ListItem>
    <asp:ListItem>Sport</asp:ListItem>
    <asp:ListItem>War</asp:ListItem>
    <asp:ListItem>Adventure</asp:ListItem>
    <asp:ListItem>Biography</asp:ListItem>
    <asp:ListItem>Crime</asp:ListItem>
    <asp:ListItem>Drama</asp:ListItem>
    <asp:ListItem>Fantasy</asp:ListItem>
    <asp:ListItem>History</asp:ListItem>
    <asp:ListItem>Music</asp:ListItem>
    <asp:ListItem>Mystery</asp:ListItem>
    <asp:ListItem>Sci-Fi</asp:ListItem>
    <asp:ListItem>Thriller</asp:ListItem>
    <asp:ListItem>Western</asp:ListItem>
    <asp:ListItem>Unknown</asp:ListItem>
</asp:DropDownList>
<br />
<br />
<asp:Label ID="Label5" runat="server" Text="Favorite Movie"></asp:Label>
<asp:TextBox ID="favMovieTB" runat="server"></asp:TextBox>
<br />
<br />
<asp:Label ID="Label6" runat="server" Text="Genre"></asp:Label>
<asp:DropDownList ID="favMovieDD" runat="server">
    <asp:ListItem>Action</asp:ListItem>
    <asp:ListItem>Animation</asp:ListItem>
    <asp:ListItem>Comedy</asp:ListItem>
    <asp:ListItem>Documentary</asp:ListItem>
    <asp:ListItem>Family</asp:ListItem>
    <asp:ListItem>Film-Noir</asp:ListItem>
    <asp:ListItem>Horror</asp:ListItem>
    <asp:ListItem>Musical</asp:ListItem>
    <asp:ListItem>Romance</asp:ListItem>
    <asp:ListItem>Sport</asp:ListItem>
    <asp:ListItem>War</asp:ListItem>
    <asp:ListItem>Adventure</asp:ListItem>
    <asp:ListItem>Biography</asp:ListItem>
    <asp:ListItem>Crime</asp:ListItem>
    <asp:ListItem>Drama</asp:ListItem>
    <asp:ListItem>Fantasy</asp:ListItem>
    <asp:ListItem>History</asp:ListItem>
    <asp:ListItem>Music</asp:ListItem>
    <asp:ListItem>Mystery</asp:ListItem>
    <asp:ListItem>Sci-Fi</asp:ListItem>
    <asp:ListItem>Thriller</asp:ListItem>
    <asp:ListItem>Western</asp:ListItem>
    <asp:ListItem>Unknown</asp:ListItem>
</asp:DropDownList>


<br />
<br />
<asp:Button ID="bSubmit" runat="server" Text="Submit" />


<asp:Button ID="bDelete" runat="server" Text="Delete" Visible="False" />
<br />
<br />
<asp:ListBox ID="lbPollPage" runat="server" Width="396px"></asp:ListBox>
<br />
<br />
<asp:ListBox ID="lbIDs" runat="server" Visible="False"></asp:ListBox>
<br />


</asp:Content>

