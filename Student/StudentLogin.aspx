<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentLogin.aspx.cs" Inherits="OnlineTeaching.Student.StudentLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <%--CTRL+k&ctrl+c --添加注释--%>
    <%--CTRL+k&CTRL+u --取消注释--%>

    <%--get表示显式传输--%>
    <%--post表示隐式传送--%>
    <%--取得表单数据后会自动封装到request中--%>
    <form method="post" runat="server">
        <div>
            <h1 style="text-align: center">欢迎登录</h1>
        </div>
        <div style="text-align: center">
            <div>
                用户名：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="RequiredFieldValidator" ForeColor="Red">请输入用户名</asp:RequiredFieldValidator>
            </div>
            <div>
                密码：<asp:TextBox ID="TextBox2" runat="server" type="password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="RequiredFieldValidator" ForeColor="Red">请输入密码</asp:RequiredFieldValidator>
            </div>
            <div>
                <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" />
            </div>
        </div>
    </form>
</body>
</html>
