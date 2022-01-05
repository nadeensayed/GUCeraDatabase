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
    public partial class listcer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //Create a new connection 
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand assignment = new SqlCommand("viewCertificate", conn);
            assignment.CommandType = System.Data.CommandType.StoredProcedure;
            int id = (int)Session["course"];
            int sid = (int)Session["user"];

            assignment.Parameters.Add(new SqlParameter("@cid", id));
            assignment.Parameters.Add(new SqlParameter("@sid", sid));
            SqlParameter success = assignment.Parameters.Add("@success", SqlDbType.Int);
            success.Direction = ParameterDirection.Output;
            conn.Open();
            assignment.ExecuteNonQuery();
            if (success.Value.ToString() == "0")
            {
                Response.Write("Error: <br > " +
                    "Either you are not enrolled in this course or you did not yet finish it. <br >");
            }
            else
            {
               
            SqlDataReader rdr = assignment.ExecuteReader(CommandBehavior.CloseConnection);
                while (rdr.Read())
                {

                    int s = rdr.GetInt32(rdr.GetOrdinal("sid"));
                    Label code1 = new Label();
                    code1.Text = s.ToString() + " ";
                    form1.Controls.Add(code1);

                    int cid = rdr.GetInt32(rdr.GetOrdinal("cid"));
                    Label code = new Label();
                    code.Text = cid.ToString() + " ";
                    form1.Controls.Add(code);

                    DateTime iss = rdr.GetDateTime(rdr.GetOrdinal("issueDate"));
                    Label isd = new Label();
                    isd.Text = iss.ToString() + "<br >";
                    form1.Controls.Add(isd);



                } 
            }
            conn.Close();
        }
    }
}