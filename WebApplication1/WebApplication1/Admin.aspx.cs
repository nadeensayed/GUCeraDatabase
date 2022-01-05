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
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("ViewAll.aspx");

        }



        protected void Button3_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("ViewNon.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
          
            Response.Redirect("IssuePC.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
           
            Response.Redirect("CreatePC.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("AorR.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("addmobile.aspx");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }
}