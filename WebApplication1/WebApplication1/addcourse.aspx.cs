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
    public partial class addcourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void add_Click(object sender, EventArgs e)

        {
            
           
                string ConnStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(ConnStr);
                int ch = Int16.Parse(credithours.Text);
                String n = name.Text;
                decimal p = decimal.Parse(price.Text);

                SqlCommand addcourse = new SqlCommand("InstAddCourse", conn);
                addcourse.CommandType = CommandType.StoredProcedure;
                int id = (int)Session["user"];
                addcourse.Parameters.Add(new SqlParameter("@creditHours", ch));
                addcourse.Parameters.Add(new SqlParameter("@name", n));
                addcourse.Parameters.Add(new SqlParameter("@price", p));
                addcourse.Parameters.Add(new SqlParameter("@instructorId", id));
                SqlParameter cid = addcourse.Parameters.Add("@cid", SqlDbType.Int);
                cid.Direction = ParameterDirection.Output;
                conn.Open();
                try
                {
                    addcourse.ExecuteNonQuery();
                    String idst = cid.Value.ToString();
                    Response.Write("Added successfully. The course ID is " + idst+"<br >");
                }
                catch
                {
                    Response.Write("Error:<br >" +
                        "A course with the same name already exists. Please change the name.<br >");

                }
                conn.Close();
                
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("instHome.aspx");
        }
    }
}