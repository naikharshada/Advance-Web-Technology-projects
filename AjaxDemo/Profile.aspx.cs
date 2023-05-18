using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AjaxDemo
{
    public partial class Profile : System.Web.UI.Page
    {
        List<String> qt;
        Random rnd;

        protected void Page_Load(object sender, EventArgs e)
        {
            qt = new List<string>();
            rnd = new Random();
            qt.Add("The future belongs to those who believe in the beauty of their dreams.");
            qt.Add("Life is either a daring adventure or nothing at all.");
            qt.Add("Only a life lived for others is a life worthwhile.");
            qt.Add("You can, you should, and if you’re brave enough to start, you will.");
            qt.Add("Life is what happens when you're busy making other plans.");
            lblquote.Text = qt[rnd.Next(qt.Count)];
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            lblquote.Text = qt[rnd.Next(qt.Count)];
        }

        protected void Timer2_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}