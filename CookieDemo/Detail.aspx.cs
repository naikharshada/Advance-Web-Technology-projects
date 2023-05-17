using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookieDemo
{
    public partial class Detail : System.Web.UI.Page
    {
        HttpCookieCollection cookies;
        protected void Page_Load(object sender, EventArgs e)
        {
            cookies = Request.Cookies;
            if(cookies.Count > 0)
            {
                for(int i = 0; i < cookies.Count; i++)
                {
                    ListBox1.Items.Add("Book: " + cookies[i].Name + "  Description  " + cookies[i].Value);
                    
                }
            }
            else
            {
                ListBox1.Items.Add("No Books Selected");
            }
        }
    }
}