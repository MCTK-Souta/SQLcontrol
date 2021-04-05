using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SQLcontrol
{
    public partial class testWebForm3 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            testSite2 masterPage = (this.Master as testSite2);
            //masterPage.HeaderText = "This is set by page";
            masterPage.SetHeaderText("Header Text");
            masterPage.SType = testSite2.SourceType.Inner;
        }
    }
}