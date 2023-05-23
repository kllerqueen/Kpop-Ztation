<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="ArtistDetail.aspx.cs" Inherits="Kpop_Ztation.View.ArtistDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="WebsiteContent" runat="server">
    <h1>Artist Detail</h1>

    <%if (checkRole())
        {%>
    <asp:Button ID="InsertAlbumButton" runat="server" Text="Insert Album" OnClick="InsertAlbumButton_Click" />   
    <%} %>
</asp:Content>
