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
    public partial class gradeassignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (type.Text.ToLower() != "quiz" && type.Text.ToLower() != "exam" && type.Text.ToLower() != "project")
                Response.Write("The Type must be quiz or exam or project!");
            else if (decimal.TryParse(grade.Text, out _) == false)
                Response.Write("Grade must be a number!");
            else if (decimal.Parse(grade.Text) < 0 || decimal.Parse(grade.Text) > 100)
                Response.Write("The grade must be between 0 and 100!");

            else
            {
                string ConnStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(ConnStr);
                int cid = Int16.Parse(course.Text);
                int no = Int16.Parse(number.Text);
                int sid = Int16.Parse(student.Text);
                decimal g = decimal.Parse(grade.Text);
                String t = type.Text;


                SqlCommand grdass = new SqlCommand("InstructorgradeAssignmentOfAStudent", conn);
                grdass.CommandType = CommandType.StoredProcedure;
                int id = (int)Session["user"];
                grdass.Parameters.Add(new SqlParameter("@cid", cid));
                grdass.Parameters.Add(new SqlParameter("@assignmentNumber", no));
                grdass.Parameters.Add(new SqlParameter("@type", t));
                grdass.Parameters.Add(new SqlParameter("@instrId", id));
                grdass.Parameters.Add(new SqlParameter("@grade", g));
                grdass.Parameters.Add(new SqlParameter("@sid", sid));
                SqlParameter success = grdass.Parameters.Add("@success", SqlDbType.Int);
                success.Direction = ParameterDirection.Output;

                conn.Open();
                grdass.ExecuteNonQuery();
                conn.Close();
                if (success.Value.ToString() == "1")
                {
                    Response.Write("Added successfully. <br >");
                   
                }
                else if (success.Value.ToString() != "2")
                {

                    Response.Write("Error: <br > " +
                       "You did not add this course so you can't grade its assignments.<br >" +
                       "Please go back to home and then view assignments to see which assignments you are allowed to grade.<br > ");
                   
                }
                
                else if (success.Value.ToString() != "3")
                {
                    Response.Write("Error: <br > " +
                        "This student did not submit this assignment.<br >" +
                        "Please go back to home and then view assignments to see which assignments you are allowed to grade.<br > ");

                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("instHome.aspx");
        }
    }
}