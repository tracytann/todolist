using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace TodoListApp_ASP_NET
{
    public class Class1
    {
        SqlConnection db = new SqlConnection();
        public Class1()
        {
            db = new SqlConnection(ConfigurationManager.ConnectionStrings["db_conn"].ConnectionString);
        }
        public int InsertAction(string str)
        {
            db.Open();
            SqlCommand cmd = new SqlCommand(str, db);
            int a = cmd.ExecuteNonQuery();
            db.Close();
            return a;
        }

        public int loginCheck(string str)
        {
            db.Open();
            SqlCommand cmd = new SqlCommand(str, db);
            SqlDataReader reader = cmd.ExecuteReader();

            int rowCount = 0;

            while (reader.Read())
            {
                // Assuming 'Name' is a column in your database table.
                string name = reader["Name"].ToString();
                rowCount++;
                // You can use 'name' variable if needed, but in this function, we only need to count rows.
            }

            reader.Close();
            db.Close();
            return rowCount;
        }

        public int loggedInUserDetails(string str)
        {
            db.Open();
            SqlCommand cmd = new SqlCommand(str, db);
            int a = cmd.ExecuteNonQuery();
            db.Close();
            return a;
        }

        public int retrieveFulltable(string str)
        {
            db.Open();
            SqlCommand cmd = new SqlCommand(str, db);
            int a = cmd.ExecuteNonQuery();
            db.Close();
            
            return a;
        }

        public DataTable getAll(string str)
        {
            db.Open();
            SqlCommand cmd = new SqlCommand(str, db);
            SqlDataAdapter obj = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            obj.Fill(dt);
           
            db.Close();
            return dt;
        }

    }
}