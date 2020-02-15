<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistWellcom.aspx.cs" Inherits="OnlineTeaching.Student.RegistWellcom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <script type="text/javascript">
        var i = 5;
        
        // 获取登录事件，并处理自动跳转
        window.onload = function JumpPage() 
        {
            //alert(i + "秒后跳转到登录界面");
            //// 计时为0后，立即跳转
            //i--;
            //if (i < 0) 
            //{
            //    window.location.href = "./Student/StudentLogin.aspx";
            //}
            //setTimeout("JumpPage()", 1000);


            var c = confirm("注册成功。是否前往登录界面？？");
            if (c == true) {  //确定         
                window.location.href = 'StudentLogin.aspx';
            } else {
                //取消    
                window.location.href = '../Adminweb.aspx';        
            }
               
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
