using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //Create a new connection 
            SqlConnection conn = new SqlConnection(connStr);


            SqlCommand Users = new SqlCommand("ViewMyProfile", conn);
            Users.CommandType = CommandType.StoredProcedure;
            int id = Int32.Parse(Session["user"].ToString());
            Users.Parameters.Add(new SqlParameter("@id", id));

            conn.Open();
            SqlDataReader rdr = Users.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                String firstname = rdr.GetString(rdr.GetOrdinal("firstname"));
                Label firstName = new Label();
                firstName.Text = firstname + " ";
                form1.Controls.Add(firstName);

                String lastname = rdr.GetString(rdr.GetOrdinal("lastname"));
                Label lastName = new Label();
                lastName.Text = lastname + " ";
                form1.Controls.Add(lastName);

                String pass = rdr.GetString(rdr.GetOrdinal("password"));
                Label password = new Label();
                password.Text = pass + " ";
                form1.Controls.Add(password);

                String email = rdr.GetString(rdr.GetOrdinal("email"));
                Label mail = new Label();
                mail.Text = email + " ";
                form1.Controls.Add(mail);

                String address = rdr.GetString(rdr.GetOrdinal("address"));
                Label add = new Label();
                add.Text = address + " ";
                form1.Controls.Add(add);

                int ID = rdr.GetInt32(rdr.GetOrdinal("id"));
                Label num = new Label();
                num.Text = ID.ToString() + " ";
                form1.Controls.Add(num);

                SqlBinary gender = rdr.GetSqlBinary(rdr.GetOrdinal("gender"));
                String gende = "";
                if (gender.Equals(0))
                    gende = "M";
                else
                    gende = "F";

                Label gend = new Label();
                gend.Text = gende + " ";
                form1.Controls.Add(gend);




            }


        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("acceptedCourses.aspx");
        }

        protected void GO2_Click(object sender, EventArgs e)
        {
            Response.Redirect("EnrollCourse.aspx");
        }

        protected void GO3_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreditCard.aspx");
        }

        protected void GO4_Click(object sender, EventArgs e)
        {
            Response.Redirect("IssuedPromoCode.aspx");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("addmobile.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("stHome.aspx");
        }
    }
}