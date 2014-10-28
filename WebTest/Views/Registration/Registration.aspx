<%@ Page Title="" Language="C#" MasterPageFile="~/WebTestSite.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebApplication1.Views.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">


Регистрация нового аккаунта<br />
<asp:TextBox ID="FirstName" runat="server" />Ваше имя
<br />
<asp:TextBox ID="LastName" runat="server" />Ваша фамилия
<br />
<asp:TextBox ID="login" runat="server" />Логин
<br />
<asp:TextBox ID="password" runat="server" />Пароль
<br />
<br />
<div>
<asp:Button ID="Register" runat="server" Text="Зарегистрироваться" Height="40px" />

<input type="button" ID="VCon" style="height: 40px; background-color: #3399ff; border-color: #3399ff; color: white; border-radius: 5px" value="Войти через ВКонтакте" OnClick="VK.Auth.login(authInfo, 1);"  />

<script src="//vk.com/js/api/openapi.js" type="text/javascript"></script>
<script>
    VK.init({
        apiId: 4564667
    });

    function authInfo(response) {
        if (response.session) {
            alert('user: ' + response.session.mid);
        } else {
            alert('not auth');
        }
    }

</script>

</div>


</asp:Content>
