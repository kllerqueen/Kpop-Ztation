<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="Kpop_Ztation.View.Homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="WebsiteContent" runat="server">
    <h1>Homepage</h1>
    <asp:Label ID="Label1" runat="server" Text="Artist List"></asp:Label><br />
    
    <asp:ListView ID="ArtistListView" runat="server">
        <ItemTemplate>
            <div class="list">
                <table>
                    <tr><td><a href="../View/ArtistDetail.aspx"><img height="320px" src='<%# "/" +  Eval("ArtistImage") %>' width="320px"/></a></td></tr>
                    <tr><td><asp:Label ID="Label2" runat="server" Text='<%# Eval("ArtistName") %>'></asp:Label></td></tr>
                    
                </table>
            </div>
        </ItemTemplate>
    </asp:ListView>   

    <asp:Button ID="InsertArtistButton" runat="server" Text="Insert Artist" OnClick="InsertArtistButton_Click"/>    
</asp:Content>

<asp:Content ID ="Content3" ContentPlaceHolderID="Stylesheets" runat="server">
    <link href="../CSS/Homepage.css" rel="stylesheet" runat="server"/>
    <link href="../CSS/Style.css" rel="stylesheet" runat="server"/>
</asp:Content>