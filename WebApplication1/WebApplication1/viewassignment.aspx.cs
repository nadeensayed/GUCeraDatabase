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
    public partial class viewassignment1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //Create a new connection 
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand assignment = new SqlCommand("viewAssign", conn);
            assignment.CommandType = System.Data.CommandType.StoredProcedure;
            int id = (int)Session["course"];
            int sid = (int)Session["user"];

            assignment.Parameters.Add(new SqlParameter("@courseId", id));
            assignment.Parameters.Add(new SqlParameter("@Sid", sid));
            SqlParameter success = assignment.Parameters.Add("@success", SqlDbType.Int);
            success.Direction = ParameterDirection.Output;
            conn.Open();
            assignment.ExecuteNonQuery();
            if (success.Value.ToString() == "0")
            {
                Response.Write("Error: <br > " +
                    "You are not enrolled in this course please go back and enter another course id. <br >");
            }
            else
            {

            SqlDataReader rdr = assignment.ExecuteReader(CommandBehavior.CloseConnection);
                while (rdr.Read())
                {
                    int cid = rdr.GetInt32(rdr.GetOrdinal("cid"));
                    Label code = new Label();
                    code.Text = cid.ToString() + " ";
                    form1.Controls.Add(code);

                    int number = rdr.GetInt32(rdr.GetOrdinal("number"));
                    Label num = new Label();
                    num.Text = number.ToString() + " ";
                    form1.Controls.Add(num);


                    String type = rdr.GetString(rdr.GetOrdinal("type"));
                    Label Type = new Label();
                    Type.Text = type + " ";
                    form1.Controls.Add(Type);
                    String grade;
                    Label fgrade = new Label();
                    grade = (rdr.GetInt32(rdr.GetOrdinal("fullGrade"))).ToString();
                    fgrade.Text = grade + " ";

                    form1.Controls.Add(fgrade);

                    decimal weight = rdr.GetDecimal(rdr.GetOrdinal("weight"));
                    Label Weight = new Label();
                    Weight.Text = weight.ToString() + " ";
                    form1.Controls.Add(Weight);

                    DateTime deadline = rdr.GetDateTime(rdr.GetOrdinal("deadline"));
                    Label Deadline = new Label();
                    Deadline.Text = deadline.ToString() + " ";
                    form1.Controls.Add(Deadline);

                    String content = rdr.GetString(rdr.GetOrdinal("content"));
                    Label cont = new Label();
                    cont.Text = content + "<br > ";
                    form1.Controls.Add(cont);
                }
            }
            conn.Close();
        }
    }
}