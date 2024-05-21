using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TodoListApp_ASP_NET
{
    public partial class HomePage : System.Web.UI.Page
    {
        Class1 objC = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                showGrid();
            }
        }

        public void showGrid()
        {
            DataTable d = objC.getAll("SELECT id,Name,Age,Gender FROM registrationtable");
            //GridView1.DataSource = dt;
            //GridView1.DataBind();
            GridView1.DataSource = d;
            GridView1.DataBind();
        }
    }
}