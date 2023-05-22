using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FileUploder
{
    public partial class Uploader : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(@"C:\Harshada\AWT labs\" + FileUpload1.FileName);
                Label1.Text = "File Uploaded Successfully! " + FileUpload1.FileName;
            }
            else
            {
                Label1.Text = "No File Uploaded!";
            }
        }
    }
}