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
    public partial class CreatePC : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)

        {
            if (decimal.TryParse(TextBox4.Text, out _) == false)
                Response.Write("Discount must be a number!");
            else
            {
                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(connStr);

                String code = TextBox1.Text;
                DateTime issueDate = DateTime.Parse(TextBox2.Text);
                DateTime expiryDate = DateTime.Parse(TextBox3.Text);
                Decimal dis = Convert.ToDecimal(TextBox4.Text);
                int id = (int)Session["user"];

                SqlCommand CreatePromoCode = new SqlCommand("AdminCreatePromocode", conn);
                CreatePromoCode.CommandType = System.Data.CommandType.StoredProcedure;
                CreatePromoCode.Parameters.Add(new SqlParameter("@code", code));
                CreatePromoCode.Parameters.Add(new SqlParameter("@isuueDate", issueDate));
                CreatePromoCode.Parameters.Add(new SqlParameter("@expiryDate", expiryDate));
                CreatePromoCode.Parameters.Add(new SqlParameter("@discount", dis));
                CreatePromoCode.Parameters.Add(new SqlParameter("@adminId", id));

                conn.Open();
                try
                {
                    CreatePromoCode.ExecuteNonQuery();
                    Response.Write("Created Successfully");
                }
                catch
                {
                    Response.Write("PromoCode with the same code already exists");
                }
                conn.Close();
            }
        }
    }
}