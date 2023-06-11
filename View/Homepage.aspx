<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="Kpop_Ztation.View.Homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Stylesheets" runat="server">
     <link href="../CSS/Homepage.css" rel="stylesheet" runat="server"/>
    <link href="../CSS/Style.css" rel="stylesheet" runat="server"/>

</asp:Content>

<asp:Content ID ="Content3" ContentPlaceHolderID="WebsiteContent" runat="server">
    <%if(Session["User"] == null) { %>
        <div class="homepage-header">
            <h1>Please log in to view the website's contents</h1>
        </div>
    <%} %>

    <%else{ %>
        <h1>Home</h1>
            <%if (checkRole())
            { %>   
            <asp:Button ID="InsertArtistButton" class="Button" runat="server" Text="Insert Artist" OnClick="InsertArtistButton_Click"/> &nbsp        
        <%}%>     

        

        <br /><br />

        <h2 class="header-text">Artist List</h2>

        <div class="listview-container">            
            <asp:ListView ID="ArtistListView" runat="server">
                <ItemTemplate>
                    <div class="list">
                        <table>
                            <tr><td><a href='<%# "../View/ArtistDetail.aspx?artistId=" + Eval("ArtistID") %>'><img class="home-image" src='<%# Eval("ArtistImage") %>' /></a></td></tr>
                            <tr><td><asp:Label ID="artistName" runat="server" Text='<%# Eval("ArtistName") %>'></asp:Label></td></tr>
                            <%if(checkRole())
                                { %>
                            <tr><td><a class="listview-button" href='<%# "../View/UpdateArtist.aspx?artistId=" + Eval("ArtistID") %>'>Update Artist</a></td></tr>
                            <tr><td><asp:LinkButton ID="deleteButton" class="listview-button" CommandArgument='<%#Eval("ArtistID") %>' OnClick="deleteButton_Click" runat="server">Delete Artist</asp:LinkButton></td></tr>                                                        
                            <%  }%>
                        </table>
                    </div>
                </ItemTemplate>
            </asp:ListView> 
        </div>
        <br /> <br />
    <%} %>
</asp:Content>