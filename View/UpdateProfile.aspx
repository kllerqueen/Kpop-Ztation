<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="Kpop_Ztation.View.UpdateProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Stylesheets" runat="server">
    <link href="../CSS/Style.css" rel="stylesheet" runat="server"/>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="WebsiteContent" runat="server">
    <h1>Update Profile</h1>

    <br />
    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label> &nbsp
    <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox> <br />

    <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label> &nbsp
    <asp:TextBox ID="emailTxt" runat="server"></asp:TextBox> <br />

    <asp:Label ID="Label3" runat="server" Text="Gender"></asp:Label> &nbsp
    <asp:RadioButtonList ID="GenderSelect" runat="server">
        <asp:ListItem Selected="True">Male</asp:ListItem>
        <asp:ListItem>Female</asp:ListItem>
    </asp:RadioButtonList>

    <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label> &nbsp
    <asp:TextBox ID="addressTxt" runat="server"></asp:TextBox> <br />

    <asp:Label ID="Label5" runat="server" Text="Password"></asp:Label> &nbsp
    <asp:TextBox ID="passwordTxt" runat="server" TextMode="Password"></asp:TextBox> <br />

    <asp:Label ID="errorTxt" runat="server" Text=""></asp:Label> <br />
    <asp:Button ID="updateProfile" runat="server" Text="Update" />
</asp:Content>
