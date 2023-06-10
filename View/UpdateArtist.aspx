<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="UpdateArtist.aspx.cs" Inherits="Kpop_Ztation.View.UpdateArtist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Stylesheets" runat="server">
     <link href="../CSS/Homepage.css" rel="stylesheet" runat="server"/>
    <link href="../CSS/Style.css" rel="stylesheet" runat="server"/>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="WebsiteContent" runat="server">
    <h1>Update Artist</h1>

    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label> &nbsp
    <asp:TextBox ID="artistNameTxt" runat="server"></asp:TextBox> <br />

    <asp:Label ID="Label2" runat="server" Text="Image"></asp:Label> &nbsp
    <asp:FileUpload ID="ImageUpload" runat="server" /> <br />

    <asp:Label ID="errorTxt" runat="server" Text=""></asp:Label> <br />
    <asp:Button ID="UpdateArtistButton" runat="server" Text="Update" />
</asp:Content>
