<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="Kpop_Ztation.View.Homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Stylesheets" runat="server">
     <link href="../CSS/Homepage.css" rel="stylesheet" runat="server"/>
    <link href="../CSS/Style.css" rel="stylesheet" runat="server"/>

</asp:Content>

<asp:Content ID ="Content3" ContentPlaceHolderID="WebsiteContent" runat="server">
    <%if(Session["User"] == null) { %>
        <div class="homepage-restrict">
            <h1>Please log in to view the website's contents</h1>
        </div>
    <%} %>

    <%else{ %>
        <h1>Homepage</h1> <br />

        <%if (checkRole())
            { %>   
            <asp:Button ID="InsertArtistButton" runat="server" Text="Insert Artist" OnClick="InsertArtistButton_Click"/> &nbsp        
        <%}%>

        <br /><br />

        <div>
            <h2>Artist List</h2>
            <asp:ListView ID="ArtistListView" runat="server">
                <ItemTemplate>
                    <div class="list">
                        <table>
                            <tr><td><a href='<%# "../View/ArtistDetail.aspx?artistId=" + Eval("ArtistID") %>'><img class="home-image" src='<%# Eval("ArtistImage") %>' /></a></td></tr>
                            <tr><td><asp:Label ID="artistName" runat="server" Text='<%# Eval("ArtistName") %>'></asp:Label></td></tr>
                            <%if(checkRole())
                                { %>
                            <tr><td><asp:Button ID="artistUpdateButton" runat="server" Text="Update Artist" OnClick="artistUpdateButton_Click" /></td></tr>
                            <tr><td><asp:Button ID="artistDeleteButton" runat="server" Text="Delete Artist" OnClick="artistDeleteButton_Click" /></td></tr>
                            <%  }%>
                        </table>
                    </div>
                </ItemTemplate>
            </asp:ListView> 
        </div>
        <br /> <br />
    <%} %>
</asp:Content>