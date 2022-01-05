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
    public partial class submit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (type.Text.ToLower() != "quiz" && type.Text.ToLower() != "exam" && type.Text.ToLower() != "project")
                Response.Write("The Type must be quiz or exam or project!");
            else
            {
                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(connStr);

                string AssignType = type.Text;
                int num = Int16.Parse(number.Text);
                int id = (int)Session["user"];
                int cid = Int16.Parse(course.Text);

                SqlCommand submitproc = new SqlCommand("submitAssign", conn);
                submitproc.CommandType = System.Data.CommandType.StoredProcedure;

                submitproc.Parameters.Add(new SqlParameter("@assignType", AssignType));
                submitproc.Parameters.Add(new SqlParameter("@assignnumber", num));
                submitproc.Parameters.Add(new SqlParameter("@sid", id));
                submitproc.Parameters.Add(new SqlParameter("@cid", cid));
                SqlParameter success = submitproc.Parameters.Add("@success", SqlDbType.Int);
                success.Direction = ParameterDirection.Output;
                conn.Open();
                try
                {
                    submitproc.ExecuteNonQuery();
                    if (success.Value.ToString() == "0")
                    {
                        Response.Write("Error: <br > " +
                            "You are not enrolled in this course! <br >");
                    }
                    else
                    {
                        Response.Write("Submitted Successfully.");

                    }

                }
                catch
                {
                    Response.Write("You already submitted this assignment!");
                }
                conn.Close();
            }

        }
    }
}