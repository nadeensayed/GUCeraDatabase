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
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void student_Click(object sender, EventArgs e)
        {
            String g = (gender.Text).ToLower();
            if (g != "male" && g != "female")
            {
                Response.Write("Please write either male or female in gender");


            }

            else
            {

                string ConnStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(ConnStr);
                String fn = firstname.Text;
                String ln = lastname.Text;
                String pass = password.Text;
                String add = address.Text;
                String em = email.Text;
                int gen = 1;
                if (g == "male")
                    gen = 0;
                SqlCommand streg = new SqlCommand("studentRegister", conn);
                streg.CommandType = CommandType.StoredProcedure;



                streg.Parameters.Add(new SqlParameter("@address", add));
                streg.Parameters.Add(new SqlParameter("@first_name", fn));
                streg.Parameters.Add(new SqlParameter("@last_name", ln));
                streg.Parameters.Add(new SqlParameter("@password", pass));
                streg.Parameters.Add(new SqlParameter("@email", em));
                streg.Parameters.Add(new SqlParameter("@gender", gen));
                SqlParameter id = streg.Parameters.Add("@id", SqlDbType.Int);
                id.Direction = ParameterDirection.Output;

                conn.Open();
                try
                {
                    streg.ExecuteNonQuery();
                    String idst = id.Value.ToString();
                    Response.Write("Registration successful. Your Id is : " + idst+"<br >");
                }
                catch
                {
                    Response.Write("Please enter a unique email! <br >");
                }

                conn.Close();

            }

        }

        protected void instructor_Click(object sender, EventArgs e)

        {
            String g = (gender.Text).ToLower();
            if (g != "male" && g != "female")
            {
                Response.Write("Please write either male or female in gender");


            }

            else
            {

                string ConnStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(ConnStr);
                String fn = firstname.Text;
                String ln = lastname.Text;
                String pass = password.Text;
                String add = address.Text;
                String em = email.Text;
                int gen = 1;
                if (g == "male")
                    gen = 0;
                SqlCommand instreg = new SqlCommand("InstructorRegister", conn);
                instreg.CommandType = CommandType.StoredProcedure;



                instreg.Parameters.Add(new SqlParameter("@address", add));
                instreg.Parameters.Add(new SqlParameter("@first_name", fn));
                instreg.Parameters.Add(new SqlParameter("@last_name", ln));
                instreg.Parameters.Add(new SqlParameter("@password", pass));
                instreg.Parameters.Add(new SqlParameter("@email", em));
                instreg.Parameters.Add(new SqlParameter("@gender", gen));
                SqlParameter id = instreg.Parameters.Add("@id", SqlDbType.Int);
                id.Direction = ParameterDirection.Output;
               
                conn.Open();
                try
                {
                    instreg.ExecuteNonQuery();
                    String idst = id.Value.ToString();
                    Response.Write("Registration successful. Your Id is : "+idst);
                }
                catch
                {
                    Response.Write("Please enter a unique email");
                }

                conn.Close();
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }
}