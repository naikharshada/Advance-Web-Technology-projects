using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionDemo
{
    public partial class Counter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["counter"] == null)
            {
                Label1.Text = "First Visit";
                int c = 1;
                Session["Counter"] = c.ToString();
            }
            else
            {
                int c = int.Parse(Session["counter"].ToString());
                c++;
                Label1.Text = "This is Visit No. : " + c;
                Session["counter"] = c.ToString();
            }
        }
    }
}