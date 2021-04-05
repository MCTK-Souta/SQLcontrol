using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrylifeCode
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("Master_Page_PreInit <br/>");
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Master_Page_Init <br/>");
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Master_Page_Load <br/>");

        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("Master_Page_PreRender <br/>");

        }
    }
}