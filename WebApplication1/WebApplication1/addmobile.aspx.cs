using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class addmobile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      
        protected void submit_Click(object sender, EventArgs e)
        {
            String phone = mobile.Text;

            if (Int64.TryParse(phone, out _) == false)
                Response.Write("All the digits must be numbers!");
            else if (phone.Length != 11)
                Response.Write("Your phone number must be 11 digits." +
                    "Please Re-enter");
            else
            {
                string ConnStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(ConnStr);
                SqlCommand addmob = new SqlCommand("addMobile", conn);
                addmob.CommandType = CommandType.StoredProcedure;
                int id = (int)Session["user"];
                addmob.Parameters.Add(new SqlParameter("@ID", id));
                addmob.Parameters.Add(new SqlParameter("@mobile_number", phone));
                conn.Open();
                try
                {
                    addmob.ExecuteNonQuery();
                    Response.Write("Added successfully");
                }
                catch
                {
                    Response.Write("You already added this phone number!");
                }
                conn.Close();
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           if((int)Session["type"]==0)
             Response.Redirect("instHome.aspx");

            else if ((int)Session["type"] == 1)
                Response.Redirect("Admin.aspx");

            else if ((int)Session["type"] == 2)
                Response.Redirect("Profile.aspx");
        }
    }
}