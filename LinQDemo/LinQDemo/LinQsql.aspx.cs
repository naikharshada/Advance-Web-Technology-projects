using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinQDemo
{
    public partial class LinQsql : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StudentClasses1DataContext scdc = new StudentClasses1DataContext();
            var stud = (from x in scdc.Students select x).ToList();
            GridView1.DataSource = stud;
            GridView1.DataBind();
        }
    }
}