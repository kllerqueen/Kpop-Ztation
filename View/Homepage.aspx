<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="Kpop_Ztation.View.Homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="WebsiteContent" runat="server">
    <h1>Homepage</h1>
    <asp:Label ID="Label1" runat="server" Text="Artist List"></asp:Label><br />
    <asp:Button ID="Button1" runat="server" Text="Artist Detail" OnClick="Button1_Click" />
    <%--<asp:GridView ID="GridView1" runat="server" GridLines="None" ></asp:GridView>--%>
</asp:Content>
