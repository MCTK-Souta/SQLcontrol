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
            string phone = this.Phone.Text;
            string education = this.Education.Text;
            string school = this.School.Text;
            string department = this.Department.Text;
            string exp = this.Exp.Text;
            string expyear = this.Expyear.Text;
            DataBaseExecutor.InsertTestTablel(fn,ln,birthday,sex,address,idn,password,email,phone,education,school,department,exp,expyear);
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
            string phone = this.Phone.Text;
            string education = this.Education.Text;
            string school = this.School.Text;
            string department = this.Department.Text;
            string exp = this.Exp.Text;
            string expyear = this.Expyear.Text;
            DataBaseExecutor.UpdateTestTablel(fn, ln, birthday, sex, address, idn, password, 
                email, phone, education, school, department, exp, expyear);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string inum = this.IDN.Text;
            DataBaseExecutor.DeleteTestTablel(inum);
        }
    }
}