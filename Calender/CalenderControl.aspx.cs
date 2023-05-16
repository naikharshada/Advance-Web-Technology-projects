using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calender
{
    public partial class CalenderControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Calendar1.Caption = "Harshada's Calender";
            Label1.Text = "Todays Date : " + Calendar1.TodaysDate.ToShortDateString();
            Label2.Text = "Ganpati Vacation Start : 9-13-2023";
            TimeSpan d = new DateTime(2023, 6, 13) - DateTime.Now;
            Label3.Text = "Days Remaining for my Birthday : " + d.Days.ToString();

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Label4.Text = "Your Selected Date : " + Calendar1.SelectedDate.Date.ToString();
        }
    }
}