<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Blog.Manage.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="login">
        <table width="100%" style="height: 222px">
            <tr>
                <td height="80px" class="style">
                    <strong><span class="style3">后台管理</span>登录</strong>
                </td>
            </tr>
            <tr>
                <td>
                    用户名
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:TextBox ID="txtuid" runat="server" CssClass="text"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Font-Size="Small"
                        ControlToValidate="txtuid" Display="Dynamic" ErrorMessage="*必填"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td height="13px">
                    密&nbsp;&nbsp; 码
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtpwd" runat="server" TextMode="Password" CssClass="text" Style="vertical-align: top"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Font-Size="Small"
                        ControlToValidate="txtpwd" Display="Dynamic" ErrorMessage="*必填"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr><td>
                <p style="text-align:right;margin-top:30px;height:40px">
                    <asp:Button ID="btnlogin" runat="server" Text="登录" onclick="btnlogin_Click"/>
                </p>
            </td></tr>
        </table>
    </div>
    </form>
</body>
</html>
