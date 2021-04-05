using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrylifeCode
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.plh.Controls.Add(
                new TextBox()
                {
                    ID="text1"                    
                }
                );

        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            TextBox textBox = this.plh.Controls[0] as TextBox;
            Response.Write($"{textBox.Text}");

        }

    }
}