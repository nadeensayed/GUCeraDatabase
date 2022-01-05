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
    public partial class ViewNon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand viewAll = new SqlCommand("AdminViewNonAcceptedCourses", conn);
            viewAll.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader rdr = viewAll.ExecuteReader(CommandBehavior.CloseConnection);

            while (rdr.Read())
            {
                String course = rdr.GetString(rdr.GetOrdinal("name"));

                String content;
                if (!rdr.IsDBNull(rdr.GetOrdinal("content")))
                {
                    content = rdr.GetString(rdr.GetOrdinal("content"));


                }
                else
                {
                    content = " No content";
                }
                int credit = rdr.GetInt32(rdr.GetOrdinal("creditHours"));
                Decimal price = rdr.GetDecimal(rdr.GetOrdinal("price"));
                Label price1 = new Label();
                Label credit1 = new Label();
                Label name = new Label();
                Label name1 = new Label();
                Label name2 = new Label();
                price1.Text = " " + price.ToString() + " ";
                name1.Text = " " + content + " ";
                credit1.Text = " " + credit.ToString() + "<br > ";
                name.Text = " " + course + " ";
                form1.Controls.Add(name);
                form1.Controls.Add(name1);
                form1.Controls.Add(price1);
                form1.Controls.Add(credit1);
            }
        }
    }
}