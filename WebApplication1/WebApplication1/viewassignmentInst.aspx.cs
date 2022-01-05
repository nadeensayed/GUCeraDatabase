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
    public partial class viewassignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string ConnStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(ConnStr);
            SqlCommand viewass = new SqlCommand("InstructorViewAssignmentsStudents", conn);
            viewass.CommandType = CommandType.StoredProcedure;
            int cid = (int)Session["course"];
            int instid = (int)Session["user"];

            viewass.Parameters.Add(new SqlParameter("@cid", cid));
            viewass.Parameters.Add(new SqlParameter("@instrId", instid));
            SqlParameter success = viewass.Parameters.Add("@success", SqlDbType.Int);
            success.Direction = ParameterDirection.Output;
            conn.Open();
            viewass.ExecuteNonQuery();

            
            if (success.Value.ToString() == "0")
            {
                Response.Write("You did not add this course so you can't view its assignments. Please go back and enter another course to proceed");
            }
            else 
            {
                TableRow r1 = new TableRow();
                TableCell c1 = new TableCell();
                TableCell c2 = new TableCell();
                TableCell c3 = new TableCell();
                TableCell c4 = new TableCell();
                TableCell c5 = new TableCell();
                c1.Text = "Student ID";
                c2.Text = "Course ID";
                c3.Text = "Assignment Number";
                c4.Text = "Assignment Type ";
                c5.Text = "Grade";
                c1.Width = 90;
                c2.Width = 90;
                c3.Width = 150;
                c4.Width = 150;
                c5.Width = 90;
                r1.Cells.Add(c1);
                r1.Cells.Add(c2);
                r1.Cells.Add(c3);
                r1.Cells.Add(c4);
                r1.Cells.Add(c5);
                Table1.Rows.Add(r1);
                SqlDataReader rdr = viewass.ExecuteReader(CommandBehavior.CloseConnection);
                while (rdr.Read())
                {
                    TableRow r = new TableRow();
                    TableCell t1 = new TableCell();
                    String student = (rdr.GetInt32(rdr.GetOrdinal("sid"))).ToString();
                    t1.Text = student;
                    String course = (rdr.GetInt32(rdr.GetOrdinal("cid"))).ToString();
                    TableCell t2 = new TableCell();
                    t2.Text =course;
                    String assno = (rdr.GetInt32(rdr.GetOrdinal("assignmentNumber"))).ToString();
                    TableCell t3 = new TableCell();
                    t3.Text = assno;
                    String type = rdr.GetString(rdr.GetOrdinal("assignmenttype"));
                    TableCell t4 = new TableCell();
                    t4.Text = type;
                    TableCell t5 = new TableCell();
                    if (!rdr.IsDBNull(rdr.GetOrdinal("grade")))
                    {
                        String grade = (rdr.GetDecimal(rdr.GetOrdinal("grade"))).ToString();
                        t5.Text = " " + grade + "<br >";
                    }
                    else
                    {
                        t5.Text = " Not graded yet" + "<br >";
                    }

                    t1.Width = 90;
                    t2.Width = 90;
                    t3.Width = 150;
                    t4.Width = 150;
                    t5.Width = 90;
                    r.Cells.Add(t1);
                    r.Cells.Add(t2);
                    r.Cells.Add(t3);
                    r.Cells.Add(t4);
                    r.Cells.Add(t5);
                    Table2.Rows.Add(r);

                }  
            }
            conn.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("choosecourse.aspx");
        }
    }
}