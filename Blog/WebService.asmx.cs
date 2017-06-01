using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Blog
{
    /// <summary>
    /// WebService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet GetNews() {
            string conn = ConfigurationManager.ConnectionStrings["BlogConnectionString"].ConnectionString;
            SqlDataAdapter da = new SqlDataAdapter("select * from News where issave=0 and isdel=0",conn);
            DataSet ds = new DataSet();
            da.Fill(ds,"news");
            return ds;
        }
    }
}
