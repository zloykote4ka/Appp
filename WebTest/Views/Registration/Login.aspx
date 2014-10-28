<%@ Page Title="" Language="C#" MasterPageFile="~/WebTestSite.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Views.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
<asp:TextBox ID="login" runat="server" />Login
<br>
<asp:TextBox ID="pafsswordfield" runat="server" />Password
<br>
<asp:Button ID="LoginButton" runat="server" Text="Log in" />
</asp:Content>
