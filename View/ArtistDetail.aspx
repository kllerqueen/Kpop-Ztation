<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="ArtistDetail.aspx.cs" Inherits="Kpop_Ztation.View.ArtistDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Stylesheets" runat="server">
     <link href="../CSS/ArtistDetail.css" rel="stylesheet" runat="server"/>
    <link href="../CSS/Style.css" rel="stylesheet" runat="server"/>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="WebsiteContent" runat="server">
    <h1>Artist Detail</h1> <br />

    <asp:Image ID="artistImage" runat="server" /> <br />
    <asp:Label ID="artistName" runat="server"  Text=''></asp:Label> <br /> <br />

    <asp:Label ID="Label3" runat="server" Text="Artist Album Details"></asp:Label> <br />

     <asp:ListView ID="AlbumListView" runat="server">
            <ItemTemplate>
                <div class="list">
                    <table>
                        <tr><td><a href='#'><img class="ad-image" src='<%# Eval("AlbumImage") %>' /></a></td></tr>
                        <tr><td><asp:Label ID="Label2" runat="server" Text='<%# Eval("AlbumName") %>'></asp:Label></td></tr>
                        <tr><td><asp:Label ID="Label4" runat="server" Text='<%# Eval("AlbumPrice") %>'></asp:Label></td></tr>
                        <tr><td><asp:Label ID="Label5" runat="server" Text='<%# Eval("AlbumDescription") %>'></asp:Label></td></tr>
                        <tr><td><asp:Button ID="AlbumUpdateButton" runat="server" Text="Update Album" OnClick="AlbumUpdateButton_Click" /></td></tr>
                        <tr><td><asp:Button ID="AlbumDeleteButton" runat="server" Text="DeleteAlbum" OnClick="AlbumDeleteButton_Click" /></td></tr>
                    </table>
                </div>
            </ItemTemplate>
        </asp:ListView>   

    

    <div>
        <%if (checkRole())
        {  %>
        <%--<a href="../View/InsertAlbum.aspx">Insert Album</a>--%>
        <asp:Button ID="InsertAlbumButton" runat="server" Text="Insert Album" OnClick="InsertAlbumButton_Click" />   <%
        }  %>
    </div>
</asp:Content>
