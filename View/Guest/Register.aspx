<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Kpop_Ztation.View.Guest.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="WebsiteContent" runat="server">
    <asp:Label ID="Label6" runat="server" Text="Register Page"></asp:Label>

    <br />
    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label> &nbsp
    <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox>
    <asp:Label ID="nameError" runat="server" Text=""></asp:Label> <br />

    <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label> &nbsp
    <asp:TextBox ID="emailTxt" runat="server"></asp:TextBox>
    <asp:Label ID="emailError" runat="server" Text=""></asp:Label> <br />

    <asp:Label ID="Label3" runat="server" Text="Gender"></asp:Label> &nbsp
    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
        <asp:ListItem Selected="True">Male</asp:ListItem>
        <asp:ListItem>Female</asp:ListItem>
    </asp:RadioButtonList>

    <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label> &nbsp
    <asp:TextBox ID="addressTxt" runat="server"></asp:TextBox>
    <asp:Label ID="addressError" runat="server" Text=""></asp:Label> <br />

    <asp:Label ID="Label5" runat="server" Text="Password"></asp:Label> &nbsp
    <asp:TextBox ID="passwordText" runat="server"></asp:TextBox>
    <asp:Label ID="passwordError" runat="server" Text=""></asp:Label> <br />

    <asp:Button ID="registerButton" runat="server" Text="Register" />

</asp:Content>
