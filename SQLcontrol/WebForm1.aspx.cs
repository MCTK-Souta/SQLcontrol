using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SQLcontrol
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        

        protected void Button1_Click(object sender, EventArgs e)
        {
            string inum = this.IDN.Text;
            this.GridView1.DataSource = DataBaseExecutor.ReadTestTable1DT(inum);
            this.GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string fn = this.FirstName.Text;
            string ln=this.LastName.Text;
            string birthday = this.Birthday.Text;
            string sex=this.Sex.Text;
            string address = this.Address.Text;
            string idn=this.IDN.Text;
            string password = this.Password.Text;
            string email = this.Email.Text;

            DataBaseExecutor.InsertTestTablel(fn,ln,birthday,sex,address,idn,password,email);
        }

        protected  void Button3_Click(object sender, EventArgs e)
        {
            string fn = this.FirstName.Text;
            string ln = this.LastName.Text;
            string birthday = this.Birthday.Text;
            string sex = this.Sex.Text;
            string address = this.Address.Text;
            string idn = this.IDN.Text;
            string password = this.Password.Text;
            string email = this.Email.Text;

            DataBaseExecutor.UpdateTestTablel(fn, ln, birthday, sex, address, idn, password, 
                email);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string inum = this.IDN.Text;
            DataBaseExecutor.DeleteTestTablel(inum);
        }
    }
}