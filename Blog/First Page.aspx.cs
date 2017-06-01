using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog
{
    public partial class First_Page : System.Web.UI.Page
    {
        BlogDataClassesDataContext bdc = new BlogDataClassesDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind();
            }
        }
        protected void Bind() {
            var result = (from n in bdc.News select n).Take(3);
            Repeater2.DataSource = result;
            Repeater2.DataBind();
        }
    }
}