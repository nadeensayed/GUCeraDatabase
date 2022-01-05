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
    public partial class CreditCard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Submit(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //Create a new connection 
            SqlConnection conn = new SqlConnection(connStr);

            int id = (int)Session["user"];
            String CreditCardNumber = (CardNumber.Text);
            String CardHolderName = Name.Text;
            String Expirydate = ExpiryDate.Text;

            DateTime dd = Convert.ToDateTime(Expirydate);
            String cvv = Cvv.Text;

            SqlCommand Card = new SqlCommand("addCreditCard", conn);
            Card.CommandType = CommandType.StoredProcedure;
            Card.Parameters.Add(new SqlParameter("@sid", id));
            Card.Parameters.Add(new SqlParameter("@number", CreditCardNumber));
            Card.Parameters.Add(new SqlParameter("@cardHolderName", CardHolderName));
            Card.Parameters.Add(new SqlParameter("@expiryDate", dd));
            Card.Parameters.Add(new SqlParameter("@cvv", cvv));

            conn.Open();
            try
            {
                Card.ExecuteNonQuery();
                Response.Write("added successfully");
            }
            catch
            {
                Response.Write("Error:<br >" +
                    "You already added this credit card!");
            }
            conn.Close();
            
        }
    }
}