<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="AlbumDetail.aspx.cs" Inherits="Kpop_Ztation.View.AlbumDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Stylesheets" runat="server">
    <link href="../CSS/ArtistDetail.css" rel="stylesheet" runat="server"/>
    <link href="../CSS/Style.css" rel="stylesheet" runat="server"/>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="WebsiteContent" runat="server">
    <div class="field">
        <div class="header">
            <h1>Album Detail</h1> 
        </div>

        <asp:Image ID="albumImage" class="image-header" runat="server" /> <br />
        <asp:Label ID="albumName" runat="server"  Text=''></asp:Label> <br />
        <asp:Label ID="albumDesc" runat="server"  Text=''></asp:Label> <br />
        <asp:Label ID="albumPrice" runat="server"  Text=''></asp:Label> <br />
        <asp:Label ID="albumStock" runat="server"  Text=''></asp:Label> <br />
        <asp:Label ID="errorTxt" runat="server"  Text=''></asp:Label> <br />
        
        <%if (checkRole() == false || Session["User"] != null)
            { %>
                <asp:TextBox ID="purchaseAmount" runat="server" placeholder="Amount to buy"></asp:TextBox>
                <asp:Button ID="addCart" runat="server" Text="Add to Cart" OnClick="addCart_Click" /> <br /><br /><br />
        <%} %>
    </div>
    
</asp:Content>
