<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="ArtistDetail.aspx.cs" Inherits="Kpop_Ztation.View.ArtistDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Stylesheets" runat="server">
     <link href="../CSS/Homepage.css" rel="stylesheet" runat="server"/>
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
                        <tr><td><a href='../View/AlbumDetail.aspx'><img class="ad-image" src='' /></a></td></tr>
                        <tr><td><asp:Label ID="Label2" runat="server" Text="Album Name"></asp:Label></td></tr>
                        <tr><td><asp:Label ID="Label4" runat="server" Text="Price"></asp:Label></td></tr>
                        <tr><td><asp:Label ID="Label5" runat="server" Text="Description"></asp:Label></td></tr>
                    </table>
                </div>
            </ItemTemplate>
        </asp:ListView>   

    

    <div>
        <%if (checkRole())
        {  %>
        <asp:Button ID="InsertAlbumButton" runat="server" Text="Insert Album" OnClick="InsertAlbumButton_Click" />   <%
        }  %>
    </div>
</asp:Content>
