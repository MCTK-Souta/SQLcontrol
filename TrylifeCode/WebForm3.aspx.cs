using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrylifeCode
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            this.plc1.Controls.Add(
                new Button()
                {
                    Text = "Hello Button"
                }
                );


            ucA ctl = (ucA)Page.LoadControl("~/ucA.ascx");
            this.plc1.Controls.Add(ctl);


            Control ctlUCB = ctl.FindControl("ucB");
            Response.Write(ctlUCB.ClientID);


            foreach(Control ctlA in this.plc1.Controls)
            {
                if(ctlA is Button)
                    Response.Write((ctlA as Button).Text+"<br/>");

            }


        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}