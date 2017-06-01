using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog.Controls
{
    public partial class LeftList : System.Web.UI.UserControl
    {
        BlogDataClassesDataContext bdc = new BlogDataClassesDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind();
            }
        }
        protected void Bind()
        {
            var result = (from n in bdc.News
                          where n.IsDel == false && n.IsSave == false
                          orderby n.News_id descending
                          select n).Take(10);
            Repeater1.DataSource = result; ;
            Repeater1.DataBind();
        }
    }
}