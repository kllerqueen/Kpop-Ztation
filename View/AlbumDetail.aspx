<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="AlbumDetail.aspx.cs" Inherits="Kpop_Ztation.View.AlbumDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Stylesheets" runat="server">
    <link href="../CSS/ArtistDetail.css" rel="stylesheet" runat="server"/>
    <link href="../CSS/Style.css" rel="stylesheet" runat="server"/>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="WebsiteContent" runat="server">
    <h1>Album Detail</h1> <br />

    <asp:ListView ID="AlbumListView" runat="server">
            <ItemTemplate>
                <div class="list">
                    <table>
                        <tr><td><a href='#'><img class="ad-image" src='<%# Eval("AlbumImage") %>' /></a></td></tr>
                        <tr><td><asp:Label ID="Label2" runat="server" Text='<%# Eval("AlbumName") %>'></asp:Label></td></tr>
                        <tr><td><asp:Label ID="Label4" runat="server" Text='<%# Eval("AlbumDescription") %>'></asp:Label></td></tr>
                        <tr><td><asp:Label ID="Label5" runat="server" Text='<%# Eval("AlbumPrice") %>'></asp:Label></td></tr>
                        <tr><td><asp:Label ID="Label1" runat="server" Text='<%# Eval("AlbumStock") %>'></asp:Label></td></tr>
                        <tr><td><asp:TextBox ID="purchaseAmount" runat="server"></asp:TextBox></td></tr>
                        <tr><td><asp:Button ID="addCart" runat="server" Text="Add to Cart" /></td></tr>
                    </table>
                </div>
            </ItemTemplate>
        </asp:ListView>
</asp:Content>
