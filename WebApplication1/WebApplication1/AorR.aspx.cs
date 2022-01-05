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
    public partial class AorR : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int Aid = (int)Session["user"];
            int Cid = Int16.Parse(TextBox2.Text);

            SqlCommand Accept = new SqlCommand("AdminAcceptRejectCourse", conn);
            Accept.CommandType = System.Data.CommandType.StoredProcedure;
            Accept.Parameters.Add(new SqlParameter("@adminid", Aid));
            Accept.Parameters.Add(new SqlParameter("@courseId", Cid));
            SqlParameter success = Accept.Parameters.Add("@acc", SqlDbType.Int);
            success.Direction = ParameterDirection.Output;

            conn.Open();
            Accept.ExecuteNonQuery();
            conn.Close();
            if (success.Value.ToString() == "1")
            {
                Response.Write("This course is already accepted please go back to your home and view the non accepted courses");
            }
            else
            {
                Response.Write("Accepted Successfully");

            }
        }
    }
}