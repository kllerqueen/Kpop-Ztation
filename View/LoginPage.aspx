<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Kpop_Ztation.View.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="WebsiteContent" runat="server">
    <h1>Login Page</h1>
    
    <br />
    <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label> &nbsp
    <asp:TextBox ID="emailTxt" runat="server"></asp:TextBox>
    
    <br />
    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label> &nbsp
    <asp:TextBox ID="passwordTxt" runat="server" TextMode="Password"></asp:TextBox>    

    <br />
    <asp:CheckBox ID="rememberMe" runat="server" OnCheckedChanged="rememberMe_CheckedChanged" />
    <asp:Label ID="Label3" runat="server" Text="Remember Me"></asp:Label>

    <br />
    <asp:Label ID="errorText" runat="server" Text=""></asp:Label> <br />
    <asp:Button ID="loginButton" runat="server" Text="Login" OnClick="loginButton_Click" />

</asp:Content>
