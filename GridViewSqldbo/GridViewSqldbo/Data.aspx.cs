using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace GridViewSqldbo
{
    public partial class Data : System.Web.UI.Page
    {
        String conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mcamock\Documents\Demo.mdf;Integrated Security=True;Connect Timeout=30";
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlconn = new SqlConnection(conn))
            {
                sqlconn.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("Select * from Student", sqlconn);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                GridView2.DataSource = dt;
                GridView2.DataBind();
            }
        }
    }
}