using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineTeaching.Class
{
    public partial class ClassInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuy_Click(object sender, EventArgs e)
        {
            if (Session["Currentuser"] == null)
            {
                Response.Write("<script>alert('您还没有登录！！请登录后再购买!!')</script>");
            }
        }
    }
}