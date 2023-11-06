<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Policy_Portal.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="~/LoginPage.css" rel="stylesheet" />
</head>
<body>
    <div class="container-left">
        <div class="image">
            <img src="/Jubilee_Logo_2-bgr.png" />
        </div>
    </div>
    <div class="container-right">
        <form id="loginForm" runat="server" class="login-form">
            <h1>Portal Login</h1>
            <div class="input-container">
                 <asp:TextBox ID="User" runat="server" placeholder="Username" ></asp:TextBox>
            </div>
            <div class="input-container">
                <asp:TextBox ID="Pass" runat="server" placeholder="Password" TextMode="Password" ></asp:TextBox>

            </div>
            
            <asp:Label ID="lblerror" runat="server" ForeColor="#BA0C25" style="margin-bottom: 15px"></asp:Label>
            <div>
                <asp:Button ID="Button1" runat="server" OnClick="Btnlogin_Click" Text="Sign In" CssClass="submit-button" />

            </div>
            
        </form>
    </div>
</body>
</html>
