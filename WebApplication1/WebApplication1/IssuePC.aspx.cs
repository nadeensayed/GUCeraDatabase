using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class IssuePC : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int id = Int16.Parse(TextBox1.Text);
            String code = TextBox2.Text;

            SqlCommand IssuePC = new SqlCommand("AdminIssuePromocodeToStudent", conn);
            IssuePC.CommandType = System.Data.CommandType.StoredProcedure;
            IssuePC.Parameters.Add(new SqlParameter("@sid", id));
            IssuePC.Parameters.Add(new SqlParameter("@pid", code));

            conn.Open();
            try
            {
                IssuePC.ExecuteNonQuery();
                Response.Write("Issued successfully. <br >");

            }
            catch
            {
                Response.Write("This promocode is already issued to this student <br >");
            }
            conn.Close();
        }
    }
}