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
    public partial class issuecertificate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            
            
         
           
            
                string ConnStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(ConnStr);
                int cid = Int16.Parse(course.Text);
                int sid = Int16.Parse(student.Text);

                String d = date.Text;
                DateTime dd = Convert.ToDateTime(d);

                SqlCommand issue = new SqlCommand("InstructorIssueCertificateToStudent", conn);
                issue.CommandType = CommandType.StoredProcedure;
                int id = (int)Session["user"];
                issue.Parameters.Add(new SqlParameter("@cid", cid));
                issue.Parameters.Add(new SqlParameter("@sid", sid));
                issue.Parameters.Add(new SqlParameter("@issueDate", dd));
                issue.Parameters.Add(new SqlParameter("@insId", id));
                SqlParameter success = issue.Parameters.Add("@success", SqlDbType.Int);
                success.Direction = ParameterDirection.Output;

                conn.Open();
                try
                {
                    issue.ExecuteNonQuery();
                    
                    if (success.Value.ToString() == "2")
                    {
                        Response.Write("Error: <br > " +
                            "This student did not yet complete this course so you can't issue a certificate.<br >" +
                            "Please try again. <br >");
                    }
                    else if (success.Value.ToString() == "1")
                    {
                        Response.Write("Issued successfully. <br >");

                    }
                    else if (success.Value.ToString() == "3")
                    {
                        Response.Write("Error: <br > " +
                           "This student did not pass this course (grade<=2) so you can't issue a certificate.<br >" +
                           "Please try again. <br >");
                    }
                    else
                    {
                        Response.Write("Error: <br > " +
                          "This student did not take this course so you can't issue a certificate.<br >" +
                          "Please try again. <br >");
                    }
                }
                catch
                {
                    Response.Write("This Student is already certified in this course .<br >" +

                        "Please try again.");
                }
                conn.Close();
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("instHome.aspx");
        }
    }
}