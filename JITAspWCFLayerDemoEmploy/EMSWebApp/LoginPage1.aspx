<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage1.aspx.cs" Inherits="EMSWebApp.LoginPage1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 70%;
            border-style: solid;
            border-width: 5px;
        }
        .auto-style2 {
            width: 153px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="left" cellpadding="5" cellspacing="5" class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblName" runat="server" Text="User Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtUsrname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
                    </td>
                </tr>
            </table>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
