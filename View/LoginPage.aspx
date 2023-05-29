<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Kpop_Ztation.View.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Stylesheets" runat="server">     
    <link href="../CSS/Style.css" rel="stylesheet" runat="server"/>
    <link href="../CSS/LoginRegister.css" rel="stylesheet" runat="server"/>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="WebsiteContent" runat="server">    
    <div class="login-box">
        <div class="login-elements">
            <h3>Login Page</h3> <br />

            <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label> <br />
            <asp:TextBox ID="emailTxt" runat="server"></asp:TextBox>
    
            <br />
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label> <br />
            <asp:TextBox ID="passwordTxt" runat="server" TextMode="Password"></asp:TextBox>    

            <br />
            <asp:CheckBox ID="rememberMe" runat="server" OnCheckedChanged="rememberMe_CheckedChanged" />
            <asp:Label ID="Label3" runat="server" Text="Remember Me"></asp:Label>

            <br />
            <asp:Label ID="errorText" runat="server" Text=""></asp:Label> <br />

            <asp:Label ID="Label4" runat="server" Text="No account?"></asp:Label> 
            <a href="../View/RegisterPage.aspx" class="register-now">register now</a> <br />

            <asp:Button ID="loginButton" class="loginButton" runat="server" Text="Login" OnClick="loginButton_Click" />
        </div>
    </div>

</asp:Content>
