using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookieDemo
{
    public partial class Book : System.Web.UI.Page
    {

         Dictionary<String,String>BookData;

        protected void Page_init(object Sender, EventArgs e)
        {
            BookData = new Dictionary<string, string>();
            BookData.Add("C++", "Bjarne Stroupstrup");
            BookData.Add("Java", "E Balguruswami");
            BookData.Add("Let us C", "Yashwant kanetake");
            BookData.Add("Machine Learning", "Tom Mitchell");
            BookData.Add("Harry Potter", "J K Rowling");

            RadioButtonList1.Items.Clear();
            foreach(String s in BookData.Keys)
            {
                RadioButtonList1.Items.Add(s);
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            if(RadioButtonList1.SelectedIndex >= 0)
            {
                String bn = RadioButtonList1.SelectedValue;
                String bndesc = BookData[bn];

                HttpCookie ck1 = new HttpCookie(bn, bndesc);
                Response.Cookies.Add(ck1);
            }
            else
            {
                Lblerr.Text = "Please Select a book";
            }
        }

        protected void BtnView_Click(object sender, EventArgs e)
        {
            Response.Redirect("Detail.aspx");
        }
    }
}