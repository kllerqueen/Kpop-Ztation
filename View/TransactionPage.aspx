<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="TransactionPage.aspx.cs" Inherits="Kpop_Ztation.View.TransactionPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Stylesheets" runat="server">
    <link href="../CSS/Style.css" rel="stylesheet" runat="server"/>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="WebsiteContent" runat="server">
    <h1>Transaction History</h1>
    <hr />
    <div style="padding:50px">
        <table style="width:500px" border="1">
            <thead>
                <tr>
                    <th>Transaction ID</th>
                    <th>Transaction Date</th>
                    <th>Customer's Name</th>
                    <th>Courier</th>
                    <th>Album's Picture</th>
                    <th>Album's Name</th>
                    <th>Album's Quantity</th>
                    <th>Album's Price</th>
                </tr>
            </thead>
            <tbody>
                <%foreach (var tran in tranDetail) {%>
                <tr>
                    <td><%= tran.TransactionID%></td>
                    <td><%= tran.TransactionHeader.TransactionDate %></td>
                    <td><%= tran.TransactionHeader.Customer.CustomerName %></td>
                    <td> Courier Name </td>
                    <td><img src=<%= tran.Album.AlbumImage %> alt="Album Image" width="100" height="100"></td>
                    <td><%= tran.Album.AlbumName %></td>
                    <td><%= tran.Qty %></td>
                    <td><%= tran.Qty * tran.Album.AlbumPrice %></td>
                </tr>
                <%} %>
            </tbody>
        </table>
    </div>
</asp:Content>
