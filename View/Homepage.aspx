<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="Kpop_Ztation.View.Homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="WebsiteContent" runat="server">
    <h1>Homepage</h1>
    <asp:Label ID="Label1" runat="server" Text="Artist List"></asp:Label><br />

    <%--<a href="/View/ArtistDetail.aspx"><img src="/Images/638059447901481658.jfif"/></a>
    <h3>BTS</h3>--%>
    
    <%--<asp:ListView ID="ArtistListView" runat="server">
        <ItemTemplate>
            <div class="list">
                <table>
                    <tr><td><a href="../View/ArtistDetail.aspx"><asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("ArtistImage") %>'/></a></td></tr>
                    <tr><td><asp:Label ID="Label2" runat="server" Text='<%#Eval("ArtistName") %>'></asp:Label></td></tr>
                </table>
            </div>
        </ItemTemplate>
    </asp:ListView>--%>

    <%--<asp:GridView ID="ArtistGridView" runat="server" AutoGenerateSelectButton="true" OnSelectedIndexChanged="ArtistGridView_SelectedIndexChanged" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="ArtistName" HeaderText="Name"/>
            <asp:TemplateField HeaderText="ArtistImage">
                <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("ArtistImage") %>'></asp:Image>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>--%>

    <asp:Button ID="InsertArtistButton" runat="server" Text="Insert Artist" OnClick="InsertArtistButton_Click"/>    
</asp:Content>
