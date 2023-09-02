using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinQDemo
{
    public partial class Form1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] marks = { 23, 45, 60, 50, 34 };
            IEnumerable<int> res = from p1 in marks where p1 % 2 == 0 select p1;
            foreach(int data in res)
            {
                Response.Write(data + "<br>");
            }

            int[] num = { 10, 101, 305, 56, 67, 113, 100 };
            
            IEnumerable<int> re = from p2 in num where p2 % 2 == 1 && p2 > 100 select p2;
            
            foreach(int data in re)
            {
                Response.Write(data + "<br>");
            }
        }
    }
}