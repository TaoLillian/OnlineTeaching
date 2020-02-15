using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineTeaching.Student
{
    public partial class StudentLogin : System.Web.UI.Page
    {
        //数据库连接字符串
        //可以在每个后台页面都定义连接字符串，也可以把连接字符串定义到web.config中，后序将不再定义。x   
        //private String MySqlCon = "Data Source=DESKTOP-4B0726J;Initial Catalog=dbOnlineTeaching;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //1.连接数据库。
            SqlConnection connection1 = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["MySqlCon"]);//连接数据库
            connection1.Open();//打开数据库
            //2.查询学号，密码是否存在，符合。
            //拼接查询字符串
            string select1 = "select * from StudentInfo where SName='" + this.TextBox1.Text + "' and Skey = '"+this.TextBox2.Text +"'; ";
            //在sql中执行查询语句
            SqlCommand command1 = new SqlCommand(select1, connection1);
            //使用SqlDataReader保存查询到的数据。
            command1.Connection = connection1;
            SqlDataReader sqlDataReader1 = command1.ExecuteReader();
            if (sqlDataReader1.HasRows)
            {
                //定义一个分类标志tag。1表示学生登录。0表示老师登录。
                Session["Currentuser"] = this.TextBox1.Text+"同学";
                Session["tag"] = 1;
                Response.Redirect("~/Student/StudentAdmin.aspx");
            }
            else
            {
                Response.Write("<script>alert('用户名或者密码错了哦!!')</script>");
            }
            connection1.Close();   // 关闭数据库连接

        }

        
    }
}