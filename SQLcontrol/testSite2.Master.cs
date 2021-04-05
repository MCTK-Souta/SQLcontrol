using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SQLcontrol
{
    public partial class testSite2 : System.Web.UI.MasterPage
    {

        public enum SourceType
        {
            Inner=0,
            Outter=1
        }

        public SourceType SType { get; set; }

        public string HeaderText { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ltHeader.Text = this.HeaderText;

        }

        public void SetHeaderText(string txt)
        {
            if (this.SType == SourceType.Inner)
                txt = "Inner" + txt;
            else
                txt = "Outter" + txt;



            this.ltHeader.Text = txt;
            this.HeaderText= txt;
        }

    }
}