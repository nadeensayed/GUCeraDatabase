using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class chooseassignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (course.Text.Length == 0)
                Response.Write("Please enter the course to view its assignments!");


            else
            {
                int cid = Int16.Parse(course.Text);
                Session["course"] = cid;
                Response.Redirect("viewassignment.aspx");
            }
        }
    }

}
