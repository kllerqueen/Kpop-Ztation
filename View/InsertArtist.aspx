<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="InsertArtist.aspx.cs" Inherits="Kpop_Ztation.View.InsertArtist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="WebsiteContent" runat="server">
    <h1>Insert Artist</h1>

    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label> &nbsp
    <asp:TextBox ID="artistNameTxt" runat="server"></asp:TextBox> <br />

    <asp:Label ID="Label2" runat="server" Text="Image"></asp:Label> &nbsp
    <asp:FileUpload ID="ImageUpload" runat="server" /> <br />

    <asp:Label ID="errorTxt" runat="server" Text=""></asp:Label> <br />
    <asp:Button ID="InsertArtistButton" runat="server" Text="Add" OnClick="InsertArtistButton_Click" />
</asp:Content>
