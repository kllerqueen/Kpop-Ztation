<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="Kpop_Ztation.View.Homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Stylesheets" runat="server">
     <link href="../CSS/Homepage.css" rel="stylesheet" runat="server"/>
    <link href="../CSS/Style.css" rel="stylesheet" runat="server"/>

</asp:Content>

<asp:Content ID ="Content3" ContentPlaceHolderID="WebsiteContent" runat="server">
    <%if(Session["User"] == null) { %>
    <asp:Literal ID="noLogInlbl" runat="server"></asp:Literal>
    <%} %>

    <%else{ %>
        <h1>Homepage</h1> <br />

        <%if (checkRole())
            { %>   
            <asp:Button ID="InsertArtistButton" runat="server" Text="Insert Artist" OnClick="InsertArtistButton_Click"/> &nbsp        
        <%}%>
            <%else if(!checkRole()) { %>
        <asp:Button ID="AlbumDetailButton" runat="server" Text="Album Details" OnClick="AlbumDetailButton_Click" />
        <%} %>

        <br /><br />

        <div>
            <h2>Artist List</h2>
            <asp:ListView ID="ArtistListView" runat="server">
                <ItemTemplate>
                    <div class="list">
                        <table>
                            <tr><td><a href='<%# "../View/ArtistDetail.aspx?artistId=" + Eval("ArtistID") %>'><img class="home-image" src='<%# Eval("ArtistImage") %>' /></a></td></tr>
                            <tr><td><asp:Label ID="Label2" runat="server" Text='<%# Eval("ArtistName") %>'></asp:Label></td></tr>
                            <tr><td><asp:Button ID="artistUpdateButton" runat="server" Text="Update Artist" OnClick="artistUpdateButton_Click" /></td></tr>
                            <tr><td><asp:Button ID="artistDeleteButton" runat="server" Text="Delete Artist" OnClick="artistDeleteButton_Click" /></td></tr>
                        </table>
                    </div>
                </ItemTemplate>
            </asp:ListView>   
        </div>
    <%} %>
</asp:Content>