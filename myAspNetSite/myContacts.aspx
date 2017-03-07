<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="myContacts.aspx.vb" Inherits="myContacts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  
    <span class="fldGrp">
    <asp:ListBox ID="lbContacts" runat="server" Width="941px"></asp:ListBox>
    <asp:ListBox ID="lbIDs" runat="server" Visible="False"></asp:ListBox>
 
     <br />
    <br />
        <asp:Label ID="Label4" runat="server" Text="Last Name" CssClass="lbl"></asp:Label>
    
    <asp:Label ID="Label3" runat="server" Text="First name" CssClass="lbl"></asp:Label>
   
    <asp:Label ID="Label2" runat="server" Text="Birth Date" CssClass="lbl"></asp:Label>
    
    <asp:Label ID="Label1" runat="server" Text="Anniversary Date" CssClass="lbl"></asp:Label>

    <br />
    <br />
</span>
   
<span class="fldGrp">
    <asp:TextBox ID="tbLname" runat="server" CssClass="fld"></asp:TextBox>
    <asp:TextBox ID="tbFname" runat="server" CssClass="fld"></asp:TextBox>
      <asp:TextBox ID="tbBdate" runat="server" CssClass="fld">mm/dd/yyyy</asp:TextBox>  
      
        <asp:TextBox ID="tbAdate" runat="server" CssClass="fld">mm/dd/yyyy</asp:TextBox>  
        &nbsp;
        <asp:Button ID="bSave" runat="server" Text="Save" />
    <asp:Button ID="bDelete" runat="server" Text="Delete" Visible="False" />
    
    <br />
    
</span>

        
 
     

        
 
     <br />
    <br />
    <asp:Label ID="lbPhType" runat="server" Text="Type" Visible="False"></asp:Label>
    <asp:Label ID="lbPhNo" runat="server" Text="Phone Number" Visible="False"></asp:Label>
    <br />
    <asp:TextBox ID="tbPhType" runat="server" Visible="False"></asp:TextBox>
    <asp:TextBox ID="tbPhNo" runat="server" Visible="False"></asp:TextBox>
    <asp:Button ID="bPhSave" runat="server" Text="Save" Visible="False" />
    <asp:Button ID="bPhDelete" runat="server" Text="Delete" Visible="False" />
    <br />
    <asp:ListBox ID="lbxPhNo" runat="server" Width="296px" Visible="False"></asp:ListBox>
    <asp:ListBox ID="lbxPhIds" runat="server" Visible="False"></asp:ListBox>
    <br />
  
 
     </asp:Content>

