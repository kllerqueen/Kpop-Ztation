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
    <asp:Label ID="testLbl" runat="server" Text=""></asp:Label>

     <asp:ListView ID="AlbumListView" runat="server">
            <ItemTemplate>
                <div class="list">
                    <table>
                        <tr><td><a href='<%# "../View/AlbumDetail.aspx?albumId=" + Eval("AlbumID") %>'><img class="ad-image" src='<%# Eval("AlbumImage") %>' /></a></td></tr>
                        <tr><td><asp:Label ID="Label2" runat="server" Text='<%# Eval("AlbumName") %>'></asp:Label></td></tr>                        
                        <tr><td><asp:Label ID="Label5" runat="server" Text='<%# Eval("AlbumDescription") %>'></asp:Label></td></tr>                        
                        <tr><td><asp:Label ID="Label4" runat="server" Text='<%#Eval("AlbumPrice") %>'></asp:Label></td></tr>
                        <%if (checkRole())
                            { %>
                        <tr><td><a class="listview-button" href='<%# "../View/UpdateAlbum.aspx?albumId=" + Eval("AlbumID") %>'>Update Album</a></td></tr>
                        <tr><td><asp:LinkButton ID="deleteButton" class="listview-button" OnClick="deleteButton_Click" CommandArgument='<%# Eval("AlbumID") %>' runat="server">Delete Album</asp:LinkButton></td></tr>                                                                                
                        <%} %>
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
