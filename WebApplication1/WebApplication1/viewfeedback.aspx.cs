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
    public partial class viewfeedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string ConnStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(ConnStr);
            SqlCommand viewfb = new SqlCommand("ViewFeedbacksAddedByStudentsOnMyCourse", conn);
            viewfb.CommandType = CommandType.StoredProcedure;
            int cid = (int)Session["course"];
            int instid = (int)Session["user"];

            viewfb.Parameters.Add(new SqlParameter("@cid", cid));
            viewfb.Parameters.Add(new SqlParameter("@instrId", instid));
            SqlParameter success = viewfb.Parameters.Add("@success", SqlDbType.Int);
            success.Direction = ParameterDirection.Output;
            conn.Open();
            viewfb.ExecuteNonQuery();


            if (success.Value.ToString() == "0")
            {
                Response.Write("You did not add this course so you can't view its feedbacks. Please go back and enter another course to proceed");
            }
            else
            {

                TableRow r1 = new TableRow();
                TableCell c1 = new TableCell();
                TableCell c2 = new TableCell();
                TableCell c3 = new TableCell();
                c1.Text = "Feedback Number";
                c2.Text = "Comment";
                c3.Text = "Number of likes";
                c1.Width = 130;
                c2.Width = 170;
                c3.Width = 130;
                r1.Cells.Add(c1);
                r1.Cells.Add(c2);
                r1.Cells.Add(c3);
                Table1.Rows.Add(r1);
                SqlDataReader rdr = viewfb.ExecuteReader(CommandBehavior.CloseConnection);
                while (rdr.Read())
                {
                    TableRow r = new TableRow();
                    String fbnumber = (rdr.GetInt32(rdr.GetOrdinal("number"))).ToString();
                    TableCell t1= new TableCell();
                    t1.Text = fbnumber;
                    String comment = rdr.GetString(rdr.GetOrdinal("comment"));
                    TableCell t2 = new TableCell();
                    t2.Text = comment;
                    String noll = (rdr.GetInt32(rdr.GetOrdinal("numberOfLikes"))).ToString();
                    TableCell t3= new TableCell();
                    t3.Text = noll;

                    t1.Width = 130;
                    t2.Width = 170;
                    t3.Width = 130;
                   
                    r.Cells.Add(t1);
                    r.Cells.Add(t2);
                    r.Cells.Add(t3);
                   
                    Table2.Rows.Add(r);

                }
            }
            conn.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("choosecoursefeedback.aspx");
        }
    }
}