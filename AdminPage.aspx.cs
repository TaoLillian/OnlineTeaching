using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineTeaching
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["Currentuser"] == null)
            {
                Response.Write("<script>alert('您还没有登录！！请登录后再购买!!')</script>");
            }
            else
            {
                foreach (Control item in control.Controls)
                {
                    if (item is CheckBox)
                    {
                        CheckBox cb = (CheckBox)item;
                        if (cb.Checked)
                        {
                            Session["cart"] = Session["cart"] + cb.Text;
                        }

                    }
                }
                if (Session["cart"] == null)
                {
                    Response.Write("<script>alert('您还没有选中课程')</script>");
                }
                else
                {
                    //this.Button1.Text = "添加成功！";
                }

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Session["cart"] == null)
            {
                Response.Write("<script>alert('您还没有添加购物车')</script>");
            }
            else
            {
                //Response.Redirect("shoppingCart.aspx");
            }

        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Class/ClassInfo.aspx");
        }
    }
}