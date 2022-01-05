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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void log_Click(object sender, EventArgs e)
        {

           
                string ConnStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(ConnStr);
                int idd = Int16.Parse(id.Text);
                String pass = password.Text;
                SqlCommand logproc = new SqlCommand("userLogin", conn);
                logproc.CommandType = CommandType.StoredProcedure;

                logproc.Parameters.Add(new SqlParameter("@id", idd));
                logproc.Parameters.Add(new SqlParameter("@password", pass));
                SqlParameter success = logproc.Parameters.Add("@success", SqlDbType.Int);
                SqlParameter type = logproc.Parameters.Add("@type", SqlDbType.Int);
                success.Direction = ParameterDirection.Output;
                type.Direction = ParameterDirection.Output;

                conn.Open();
                logproc.ExecuteNonQuery();
                conn.Close();
                if (success.Value.ToString() == "0")
                {
                    Response.Write("Error: Incorrect id or password please re-enter.");
                }
                else
                {
                    Session["user"] = idd;
                    Session["type"] = type.Value;
                    if (type.Value.ToString() == "0")
                        Response.Redirect("instHome.aspx");
                    else if (type.Value.ToString() == "1")
                        Response.Redirect("Admin.aspx");
                    else if (type.Value.ToString() == "2")
                        Response.Redirect("Profile.aspx");

                }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }
    }
}