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
    public partial class defineassignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (type.Text.ToLower() != "quiz" && type.Text.ToLower() != "exam" && type.Text.ToLower() != "project")
                Response.Write("The Type must be quiz or exam or project!");
            else if (decimal.TryParse(weight.Text, out _) == false)
                Response.Write("Weight must be a number!");
            else if (decimal.Parse(weight.Text) < 0 || decimal.Parse(weight.Text) > 100)
                Response.Write("The weight must be between 0 and 100!");
            
            else
            {
                string ConnStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(ConnStr);
                int cid = Int16.Parse(course.Text);
                int no = Int16.Parse(number.Text);
                int fg = Int16.Parse(fullgrade.Text);
                decimal wei = decimal.Parse(weight.Text);
                String t = type.Text.ToLower();
                String c = content.Text;
                String d = deadline.Text;
                DateTime dd = Convert.ToDateTime(d);

                SqlCommand defass = new SqlCommand("DefineAssignmentOfCourseOfCertianType", conn);
                defass.CommandType = CommandType.StoredProcedure;
                int id = (int)Session["user"];
                defass.Parameters.Add(new SqlParameter("@cid", cid));
                defass.Parameters.Add(new SqlParameter("@number", no));
                defass.Parameters.Add(new SqlParameter("@type", t));
                defass.Parameters.Add(new SqlParameter("@instId", id));
                defass.Parameters.Add(new SqlParameter("@fullGrade", fg));
                defass.Parameters.Add(new SqlParameter("@weight", wei));
                defass.Parameters.Add(new SqlParameter("@deadline", dd));
                defass.Parameters.Add(new SqlParameter("@content", c));
                SqlParameter success = defass.Parameters.Add("@success", SqlDbType.Int);
                success.Direction = ParameterDirection.Output;

                conn.Open();
                try
                {
                    defass.ExecuteNonQuery();

                    conn.Close();
                    if (success.Value.ToString() == "0")
                    {
                        Response.Write("Error:<br >" +
                            "You did not add this course so you can't define its assignments. Please enter another course to proceed.<br >");
                    }
                    else
                    {
                        Response.Write("Added successfully.<br >");

                    }
                }
                catch
                {
                    Response.Write("Error:<br > This assignment is already added!");
                }

                    conn.Close();

                }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("instHome.aspx");
        }
    }
}