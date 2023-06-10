﻿<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="UpdateAlbum.aspx.cs" Inherits="Kpop_Ztation.View.UpdateAlbum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Stylesheets" runat="server">
    <link href="../CSS/ArtistDetail.css" rel="stylesheet" runat="server"/>
    <link href="../CSS/Style.css" rel="stylesheet" runat="server"/>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="WebsiteContent" runat="server">
    <h1>Update Album</h1>

    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label> &nbsp
    <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox> <br />

    <asp:Label ID="Label2" runat="server" Text="Description"></asp:Label> &nbsp
    <asp:TextBox ID="descTxt" runat="server"></asp:TextBox> <br />

    <asp:Label ID="Label3" runat="server" Text="Price"></asp:Label> &nbsp
    <asp:TextBox ID="priceTxt" runat="server"></asp:TextBox> <br />

    <asp:Label ID="Label4" runat="server" Text="Stock"></asp:Label> &nbsp
    <asp:TextBox ID="stockTxt" runat="server"></asp:TextBox> <br />

    <asp:Label ID="Label5" runat="server" Text="Image"></asp:Label> &nbsp
    <asp:FileUpload ID="ImageUpload" runat="server" /> <br />

    <asp:Label ID="errorTxt" runat="server" Text=""></asp:Label>

    <asp:Button ID="UpdateAlbumButton" runat="server" Text="Update" />
</asp:Content>
