<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentRegist.aspx.cs" Inherits="OnlineTeaching.Student.StudentRegist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form method="post" runat="server" > 
        <div>
            <h1 style="text-align:center">欢迎注册</h1>
        </div>
        <div style="text-align:center">

            <div>用户名：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="RequiredFieldValidator" ForeColor="Red">请输入用户名</asp:RequiredFieldValidator>
                
            </div>
            <div>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" RepeatLayout="Flow">
                    <asp:ListItem Value="1">男</asp:ListItem>
                    <asp:ListItem Value="2">女</asp:ListItem>
                </asp:RadioButtonList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="RadioButtonList1" ErrorMessage="RequiredFieldValidator" ForeColor="Red">请选择性别</asp:RequiredFieldValidator>
            </div>
            <div>
                请输入电话号码：<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox4" Display="Dynamic" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="[1]+[3,,8,5]+\d{9}">请输入正确的电话号码</asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox4" ErrorMessage="RequiredFieldValidator" ForeColor="Red">请输入电话号码</asp:RequiredFieldValidator>
            </div>
                
            
            <div>输入密码：<asp:TextBox ID="TextBox2" runat="server" type="password" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="RequiredFieldValidator" ForeColor="Red">请输入密码</asp:RequiredFieldValidator>
            </div>
            <div>确认密码：<asp:TextBox ID="TextBox3" runat="server" type="password" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="RequiredFieldValidator" ForeColor="Red" Display="Dynamic">请确认密码</asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" Display="Dynamic" ErrorMessage="CompareValidator" ForeColor="Red">两次密码不一致</asp:CompareValidator>
            </div>
            <div><asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click"/></div>
        </div>
    </form>
   
</body>
</html>
