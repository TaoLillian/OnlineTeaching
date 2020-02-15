using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace OnlineTeaching.Student
{
    public partial class StudentRegist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection1 = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["MySqlCon"]);
            connection1.Open();
            String Sname = this.TextBox1.Text;
            String Ssex = this.RadioButtonList1.SelectedValue;
            String Skey = this.TextBox2.Text;
            String Snum = this.TextBox4.Text;
            String sql1 = "insert into StudentInfo values('" + Sname + "','" + Ssex + "','" + Snum + "','" + Skey + "')";

            String sql2 = "select * from StudentInfo where SName='"+Sname+"'";
            SqlCommand command2 = new SqlCommand(sql2, connection1);
            SqlDataReader sqlDataReader2 = command2.ExecuteReader();
            if (sqlDataReader2.HasRows)
            {
                Response.Write("<script>alert('用户名已经存在!!')</script>");
                connection1.Close();   // 关闭数据库连接
            }
            else
            {
                
                SqlCommand command1 = new SqlCommand(sql1, connection1);
                command1.Connection = connection1;
                int var = command1.ExecuteNonQuery(); //执行数据库命令
                connection1.Close();   // 关闭数据库连接
                if (var > 0)
                {
                    Response.Redirect("~/Student/RegistWellcom.aspx");
                }
                else
                {
                    Response.Write("<script>alert('注册失败')</script>");
                }
                
                //Response.Redirect("~/Student/StudentLogin.aspx");
            }
           

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}