using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog.Manage
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            BlogDataClassesDataContext bdc = new BlogDataClassesDataContext();
            string uid = txtuid.Text.Trim().ToString();
            string pwd = txtpwd.Text.Trim().ToString();
            var result = from n in bdc.Register
                         where n.user_name == uid && n.password == pwd
                         select n;
            foreach (var n in result)
            {
                if (n.user_name!=null)
                {
                    Session["username"] = uid;
                    Response.Redirect("../Manage/Hou.aspx",true);
                }
            }
            Response.Write("<script>alert('用户名或密码错误，请重新输入！');history.back()</script>");
        }
    }
}