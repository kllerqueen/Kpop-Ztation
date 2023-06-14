<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="Kpop_Ztation.View.CartPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Stylesheets" runat="server">
    <link href="../CSS/Style.css" rel="stylesheet" runat="server"/>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="WebsiteContent" runat="server">
    <h1>Cart</h1>
    <asp:GridView ID="CartGridView" runat="server" AutoGenerateColumns="False" OnRowDeleting="CartGridView_RowDeleting">
        <Columns>
            <asp:ImageField DataImageUrlField="Picture" HeaderText="Album's Picture" ControlStyle-Width="100" ControlStyle-Height="100"/>
            <asp:BoundField DataField="Name" HeaderText="Album's Name"/>
            <asp:BoundField DataField="Quantity" HeaderText="Album's Quantity"/>
            <asp:BoundField DataField="Price" HeaderText="Album's Price"/>
            <asp:BoundField DataField="albumID" HeaderText="Album ID"/>
            <asp:CommandField ButtonType="Button" HeaderText="Actions" ShowDeleteButton="True" ShowHeader="True" DeleteText="Remove" />
        </Columns>
        <EmptyDataTemplate>
            <p>No data has been put in the cart</p>
        </EmptyDataTemplate>
    </asp:GridView>

    <asp:Button ID="CheckOutButton" runat="server" Text="Check Out" OnClick="CheckOutButton_Click" />
</asp:Content>
