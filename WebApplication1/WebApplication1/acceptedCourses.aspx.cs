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
    public partial class acceptedCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //Create a new connection 
            SqlConnection conn = new SqlConnection(connStr);


            SqlCommand Courses = new SqlCommand("availableCourses", conn);
            Courses.CommandType = CommandType.StoredProcedure;

            conn.Open();
            SqlDataReader rdr = Courses.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                String Name = rdr.GetString(rdr.GetOrdinal("name"));
                Label Coursename = new Label();
                Coursename.Text = " "+Name+" ";
                form1.Controls.Add(Coursename);
                int id = rdr.GetInt32(rdr.GetOrdinal("id"));
                Label Courseid = new Label();
                Courseid.Text = " " + id + "<br >";
                form1.Controls.Add(Courseid);


            }

        }
    }
}