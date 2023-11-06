<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Policy_Portal.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Policy Portal"></asp:Label>
                    </td>
                   
                </tr>
                
                <tr>
                     <td>
                        <asp:Label ID="Label" runat="server" Text="Login ID"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtpass" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Btnlogin" runat="server" Text="Login" OnClick="Btnlogin_Click" />
                        <asp:Label ID="lblerror" runat="server" Visible="False"></asp:Label>
                    </td>
                </tr>
            </table>
                </center>
        </div>
    </form>
</body>
</html>
