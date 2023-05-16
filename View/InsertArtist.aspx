<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="InsertArtist.aspx.cs" Inherits="Kpop_Ztation.View.InsertArtist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="WebsiteContent" runat="server">
    <h1>Insert Artist</h1>

    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label> &nbsp
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> <br />

    <asp:Label ID="Label2" runat="server" Text="Image"></asp:Label> &nbsp
    <asp:Button ID="Button1" runat="server" Text="Upload Image" />
</asp:Content>
