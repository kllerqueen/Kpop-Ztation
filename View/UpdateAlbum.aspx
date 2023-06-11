<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="UpdateAlbum.aspx.cs" Inherits="Kpop_Ztation.View.UpdateAlbum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Stylesheets" runat="server">
    <link href="../CSS/ArtistDetail.css" rel="stylesheet" runat="server"/>
    <link href="../CSS/Style.css" rel="stylesheet" runat="server"/>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="WebsiteContent" runat="server">
    <h1>Update Album</h1>

    <asp:Image ID="albumImage" runat="server" /> <br />
    
    <label>Album Name:</label>
    <asp:TextBox ID="txtAlbumName" runat="server"></asp:TextBox><br />

    <label>Description:</label>
    <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox><br />

    <label>Price:</label>
    <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox><br />

    <label>Stock:</label>
    <asp:TextBox ID="txtStock" runat="server"></asp:TextBox><br />

    <asp:Label ID="Label5" runat="server" Text="Image"></asp:Label>
    <asp:FileUpload ID="ImageUpload" runat="server" /> <br />

    <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label> <br />
    <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />

</asp:Content>