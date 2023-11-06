using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Policy_Portal
{
    public partial class ThankyouForm : System.Web.UI.Page
    {
        String constring = "Data Source=crmtest;Initial Catalog=policy_db;User ID=t_graduate;Password=Oracle_123";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["IsLoggedIn"] == null || !(bool)Session["IsLoggedIn"])
            {
                Response.Redirect("/LoginPage.aspx");
            }

            int score = 0;
            string uname = Session["UserName"].ToString();
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string sql = "select Test_percentage from status where username='" + uname + "' and attempt = (select max(attempt) from status where username = '" + uname + "')";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                score = Convert.ToInt32(dr.GetValue(0));
            }
            con.Close();

            result.Text = "Your quiz result is: " + score.ToString() + "%";

            if (score < 60)
            {
                remarks.Text = "You've scored below the benchmark - Try again later";

                SqlConnection conn = new SqlConnection(constring);
                conn.Open();
                string query = "update IT_USER set status = 'Incomplete' where username = '"+uname+"'";
                SqlCommand cmmd = new SqlCommand(query, conn);
                cmmd.ExecuteNonQuery();
                conn.Close();

            }

            else if (score >= 60)
            {
                remarks.Text = "Congratulations! your score met the benchmark";

                SqlConnection conn = new SqlConnection(constring);
                conn.Open();
                string query = "update IT_USER set status = 'Complete' where username = '" + uname + "'";
                SqlCommand cmmd = new SqlCommand(query, conn);
                cmmd.ExecuteNonQuery();
                conn.Close();

            }



        }
    }
}