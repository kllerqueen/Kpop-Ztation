<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="Kpop_Ztation.View.Homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="WebsiteContent" runat="server">
    <h1>Homepage</h1>
    <asp:Label ID="Label1" runat="server" Text="Artist List"></asp:Label><br />

    <a href="/View/ArtistDetail.aspx"><img src="/Images/638059447901481658.jfif"/></a>
    <h3>BTS</h3>
    
    <%--<asp:ListView ID="ArtistListView" runat="server">
        <ItemTemplate>
            <div class="list">
                <table>
                    <tr><td><img src="<%#Eval("ArtistImage") %>"/></td></tr>
                    <tr><td><h1><%#Eval("ArtistName") %></h1></td></tr>
                </table>
            </div>
        </ItemTemplate>
    </asp:ListView>--%>

    <asp:Button ID="Button1" runat="server" Text="Artist Detail" OnClick="Button1_Click" />    
</asp:Content>
