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
    public partial class EnrollCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //Create a new connection 
            SqlConnection conn = new SqlConnection(connStr);
            int ID = int.Parse(CourseID.Text);
            int ID2 = Int16.Parse(InstructorID.Text);


            SqlCommand Course = new SqlCommand("enrollInCourse", conn);
            Course.CommandType = CommandType.StoredProcedure;
            int sid = (int)Session["User"];
            Course.Parameters.Add(new SqlParameter("@sid", sid));
            Course.Parameters.Add(new SqlParameter("@cid", ID));
            Course.Parameters.Add(new SqlParameter("@instr", ID2));


            SqlParameter success = Course.Parameters.Add("@success", SqlDbType.Int);
            success.Direction = ParameterDirection.Output;

            conn.Open();
            try{
                Course.ExecuteNonQuery();
                
                if (success.Value.ToString() == "1")
                {
                    Response.Write("Enrolled successfully. <br >");

                }
                else if (success.Value.ToString() == "2")
                {

                    Response.Write("Error: <br > " +
                       "You did not take the prerequisites of this course! ");

                }

                else if (success.Value.ToString() == "3")
                {
                    Response.Write("Error: <br > " +
                        "This instructor does not teach this course!");


                }

                else if (success.Value.ToString() == "4")
                {
                    Response.Write("Error: <br > " +
                        "This course is not yet accepted and you can't enroll in unaccepted course.<br >" +
                        "Please go back to your home and view available course.");


                }


            }
            catch
            {
                Response.Write("Error: <br > " +
                       "You are already enrolled in this course!");
            }
            conn.Close();

        }
    }
}