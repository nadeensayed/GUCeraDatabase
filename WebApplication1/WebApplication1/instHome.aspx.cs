using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class instHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("addmobile.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("addcourse.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("defineassignment.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("choosecourse.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("gradeassignment.aspx");

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("issuecertificate.aspx");

        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("choosecoursefeedback.aspx");

        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }
}