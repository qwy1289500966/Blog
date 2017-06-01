using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog
{
    public partial class Blog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dlbind();
            }
        }
        public void dlbind() {
            WebService ws = new WebService();
            int curpage = Convert.ToInt32(lb_currentpage.Text);
            PagedDataSource ps = new PagedDataSource();
            ps.DataSource = ws.GetNews().Tables["News"].DefaultView;
            ps.AllowPaging = true;
            ps.PageSize = 3;
            ps.CurrentPageIndex = curpage - 1;
            lb_page.Text = Convert.ToString(ps.PageCount);
            if (!IsPostBack)
            {
                for (int i = 1; i <=ps.PageCount; i++)
                {
                    DropDownList1.SelectedItem.Text = curpage.ToString();
                }
            }
            lbtn_frist.Enabled = true;
            lbtn_up.Enabled = true;
            lbtn_down.Enabled = true;
            lbtn_last.Enabled = true;
            if (curpage==1)
            {
                lbtn_frist.Enabled = false;
                lbtn_up.Enabled = false;
            }
            if (curpage==ps.PageCount)
            {
                lbtn_down.Enabled = false;
                lbtn_last.Enabled = false;
            }
            Repeater1.DataSource = ps;
            Repeater1.DataBind();
        }

        protected void lbtn_frist_Click(object sender, EventArgs e)
        {
            lb_currentpage.Text = "1";
            dlbind();
        }

        protected void lbtn_up_Click(object sender, EventArgs e)
        {
            lb_currentpage.Text = Convert.ToString(Convert.ToInt32(lb_currentpage.Text)-1);
            dlbind();
        }

        protected void lbtn_down_Click(object sender, EventArgs e)
        {
            lb_currentpage.Text = Convert.ToString(Convert.ToInt32(lb_currentpage.Text) + 1);
            dlbind();
        }

        protected void lbtn_last_Click(object sender, EventArgs e)
        {
            lb_currentpage.Text = lb_page.Text;
            dlbind();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int page=Convert.ToInt32(DropDownList1.SelectedItem.Value);
            lb_currentpage.Text=page.ToString();
            dlbind();
        }
    }
}