using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace SQLcontrol
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = DataBaseExecutor.ReadTestTable1DTtest();

            ucPager.TotalSize = dt.Rows.Count;
            ucPager.Url = "~/test.aspx";
            ucPager.Bind();

            this.repList.DataSource = dt;
            this.repList.DataBind();
        }
    }
}