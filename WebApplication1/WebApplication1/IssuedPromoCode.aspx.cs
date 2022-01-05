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
    public partial class IssuedPromoCode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //Create a new connection 
            SqlConnection conn = new SqlConnection(connStr);


            SqlCommand PromoCode = new SqlCommand("viewPromocode", conn);
            PromoCode.CommandType = CommandType.StoredProcedure;
            int id = (int)Session["user"];
            PromoCode.Parameters.Add(new SqlParameter("@sid", id));


            conn.Open();
            SqlDataReader rdr = PromoCode.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                String idcode = rdr.GetString(rdr.GetOrdinal("code"));
                Label code = new Label();
                code.Text = idcode + " ";
                form1.Controls.Add(code);

                decimal discount = rdr.GetDecimal(rdr.GetOrdinal("discount"));
                Label disc = new Label();
                disc.Text = discount + " ";
                form1.Controls.Add(disc);

                String issuedate = rdr.GetSqlDateTime(rdr.GetOrdinal("isuueDate")).ToString();
                Label issdate = new Label();
                issdate.Text = issuedate + " ";
                form1.Controls.Add(issdate);

                String ExpiryDate = rdr.GetSqlDateTime(rdr.GetOrdinal("expiryDate")).ToString();
                Label expdate = new Label();
                expdate.Text = ExpiryDate + " ";
                form1.Controls.Add(expdate);


                int adminid = rdr.GetInt32(rdr.GetOrdinal("adminId"));
                Label adminID = new Label();
                adminID.Text = adminid + "<br >";
                form1.Controls.Add(adminID);
            }


            }
        }
}