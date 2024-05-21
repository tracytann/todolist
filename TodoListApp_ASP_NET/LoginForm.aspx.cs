using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TodoListApp_ASP_NET
{
    public partial class LoginForm : System.Web.UI.Page
    {
        Class1 c1 = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label4.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int n = c1.loginCheck("SELECT Name FROM registrationtable WHERE Username='"+TextBox1.Text+"' AND Password='"+TextBox2.Text+"' ");
            System.Diagnostics.Debug.WriteLine("Part 1");
            System.Diagnostics.Debug.WriteLine(TextBox1.Text);
            System.Diagnostics.Debug.WriteLine(TextBox2.Text);
            
            System.Diagnostics.Debug.WriteLine(n);
            if (n > 0)
            {
            System.Diagnostics.Debug.WriteLine("Part 2");
                Label4.Text = "";
                Response.Redirect("HomePage.aspx");
            }
            else
            {
                Label4.Text = "Invalid Username or Password ";
            }


        }
    }
}