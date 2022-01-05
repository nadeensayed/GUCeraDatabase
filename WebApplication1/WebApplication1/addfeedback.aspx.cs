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
    public partial class addfeedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            string comm = comment.Text;
            int id = Int16.Parse(cid.Text);
            int sid = (int)Session["user"];

            SqlCommand addFeedbackproc = new SqlCommand("addFeedback", conn);
            addFeedbackproc.CommandType = System.Data.CommandType.StoredProcedure;
            addFeedbackproc.Parameters.Add(new SqlParameter("@comment", comm));
            addFeedbackproc.Parameters.Add(new SqlParameter("@cid", id));
            addFeedbackproc.Parameters.Add(new SqlParameter("@sid", sid));

            SqlParameter success = addFeedbackproc.Parameters.Add("@success", SqlDbType.Int);
            success.Direction = ParameterDirection.Output;
            conn.Open();
           
             addFeedbackproc.ExecuteNonQuery();
                if (success.Value.ToString() == "0")
                {
                    Response.Write("Error: <br > " +
                        "You are not enrolled in this course! <br >");
                }
                else
                {
                    Response.Write("Added Successfully.");

                }

            conn.Close();
        }
    }
}