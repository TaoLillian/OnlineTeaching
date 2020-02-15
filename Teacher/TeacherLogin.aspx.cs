using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace OnlineTeaching
{
    public partial class TeacherLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection1 = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["MySqlCon"]);
            sqlConnection1.Open();
            String sql1 = "select * from TeacherInfo where TName='" + this.TextBox1.Text + "' and Tkey='" + this.TextBox2.Text + "';";
            SqlCommand sqlCommand1 = new SqlCommand(sql1, sqlConnection1);
            SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();
            if (sqlDataReader1.HasRows)
            {
                Session["Currentuser"] = this.TextBox1.Text+"老师";
                Session["tag"] = 0;
                Response.Redirect("~/Teacher/TeacherAdmin.aspx");
            }
            else
            {
                Response.Write("<script>alert('用户名或者密码错了哦!!')</script>");
            }
            sqlConnection1.Close();   // 关闭数据库连接
        }
    }
}