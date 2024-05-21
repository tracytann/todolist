using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace TodoListApp_ASP_NET
{
    public partial class RegistrationForm : System.Web.UI.Page
    {
        Class1 dothis = new Class1();
        protected void Page_Load(object sender, EventArgs e)
         {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(Server.MapPath("~/Newfolder1/") + FileUpload1.FileName);
            }
            int n = dothis.InsertAction("INSERT INTO registrationtable (Name,Age,Gender,Image,Username,Password) VALUES ('"+TextBox1.Text+"','"+TextBox2.Text+"','"+RadioButtonList1.SelectedValue+"','"+FileUpload1.FileName+"','"+TextBox3.Text+"','"+TextBox4.Text+"')");
            if(n > 0)
            {
                Response.Write("USER Registered successfully !");
                Response.Redirect("LoginForm.aspx");
            }
        }
    }
}