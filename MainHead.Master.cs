using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineTeaching
{
    public partial class MainHead : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Currentuser"] == null)
            {
                this.logindiv.Visible = true;
                this.shownamediv.Visible = false;
            }
            else
            {

                this.logindiv.Visible = false;
                this.shownamediv.Visible = true;
                this.Literal1.Text = Session["Currentuser"].ToString() + "，  欢迎登陆";
            }

        }
        protected void LinkButton1_Click(object sender, EventArgs e) //跳转教师登录界面
        {
            //WebForm2 form2 = new WebForm2();
            //formCall += form2.ShowForm2;

            Response.Redirect("~/Teacher/TeacherLogin.aspx", true);
            //formCall("hello world!");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)//跳转注册界面
        {
            Response.Redirect("~/Student/StudentRegist.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)//跳转同学登录界面
        {
            Response.Redirect("~/Student/StudentLogin.aspx");
        }
        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            String str = this.LinkButton6.Text;
            if (str.Equals("返回首页"))
            {
                this.LinkButton6.Text = "我的";
                Response.Redirect("~/AdminPage.aspx");
                
            }
            else
            {
                this.LinkButton6.Text = "返回首页";
                if ((int)Session["tag"]==1) {
                    Response.Redirect("~/Student/StudentAdmin.aspx");
                }
                else
                {
                    Response.Redirect("~/Teacher/TeacherAdmin.aspx");
                }
                
            }
            
        }
        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Session.Clear();
            this.logindiv.Visible = true;
            this.shownamediv.Visible = false;

        }
    }
}