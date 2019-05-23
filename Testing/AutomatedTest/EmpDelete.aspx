<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmpDelete.aspx.cs" Inherits="AutomatedTest.EmpDelete" %>

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
            width: 105px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="left" cellpadding="5" cellspacing="5" class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblEmpno" runat="server" Text="Empno"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmpno" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblResult" runat="server" Text="Result"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
