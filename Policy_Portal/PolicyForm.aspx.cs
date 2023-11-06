using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Net.NetworkInformation;

namespace Policy_Portal
{
    public partial class PolicyForm : System.Web.UI.Page
    {
        int attempt = 0;
        String constring = "Data Source=crmtest;Initial Catalog=policy_db;User ID=t_graduate;Password=Oracle_123";
        protected void Page_Load(object sender, EventArgs e)
        {
            string uname = Master.Username;
            bool p1;
            bool p2;
            bool p3;
            bool p4;
            bool p5;
            bool p6;
            bool p7;
            bool p8;
            bool p9;
            bool p10;
            bool p11;
            bool p12;
            bool p13;
            bool p14;
            bool p15;
            bool p16;
            bool p17;
            bool p18;
            bool p19;
            bool p20;
            bool p21;
            bool p22;
            bool p23;
            bool p24;

            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string sql = "select attempt, policy_1, policy_2, policy_3, policy_4, policy_5, policy_6, policy_7, policy_8, policy_9, policy_10, policy_11, policy_12, policy_13, policy_14, policy_15, policy_16, policy_17, policy_18, policy_19, policy_20, policy_21, policy_22, policy_23, policy_24 from status where username='" + uname + "' and attempt = (select max(attempt) from status where username = '" + uname + "')";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                attempt = Convert.ToInt32(dr.GetValue(0));
                p1 = Convert.ToBoolean(dr.GetValue(1));
                p2 = Convert.ToBoolean(dr.GetValue(2));
                p3 = Convert.ToBoolean(dr.GetValue(3));
                p4 = Convert.ToBoolean(dr.GetValue(4));
                p5 = Convert.ToBoolean(dr.GetValue(5));
                p6 = Convert.ToBoolean(dr.GetValue(6));
                p7 = Convert.ToBoolean(dr.GetValue(7));
                p8 = Convert.ToBoolean(dr.GetValue(8));
                p9 = Convert.ToBoolean(dr.GetValue(9));
                p10 = Convert.ToBoolean(dr.GetValue(10));
                p11 = Convert.ToBoolean(dr.GetValue(11));
                p12 = Convert.ToBoolean(dr.GetValue(12));
                p13 = Convert.ToBoolean(dr.GetValue(13));
                p14 = Convert.ToBoolean(dr.GetValue(14));
                p15 = Convert.ToBoolean(dr.GetValue(15));
                p16 = Convert.ToBoolean(dr.GetValue(16));
                p17 = Convert.ToBoolean(dr.GetValue(17));
                p18 = Convert.ToBoolean(dr.GetValue(18));
                p19 = Convert.ToBoolean(dr.GetValue(19));
                p20 = Convert.ToBoolean(dr.GetValue(20));
                p21 = Convert.ToBoolean(dr.GetValue(21));
                p22 = Convert.ToBoolean(dr.GetValue(22));
                p23 = Convert.ToBoolean(dr.GetValue(23));
                p24 = Convert.ToBoolean(dr.GetValue(24));
            }

            else
            {
                SqlConnection conn = new SqlConnection(constring);
                conn.Open();
                string query = "insert into status (username, attempt, policy_1, policy_2, policy_3, policy_4, policy_5, policy_6, policy_7, policy_8, policy_9, policy_10, policy_11, policy_12, policy_13, policy_14, policy_15, policy_16, policy_17, policy_18, policy_19, policy_20, policy_21, policy_22, policy_23, policy_24, Acceptance, Test_percentage) values ('" + uname + "',0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0)";
                SqlCommand cmmd = new SqlCommand(query, conn);
                cmmd.ExecuteNonQuery();
                conn.Close();
            }

            con.Close();

        }



        protected void DownloadFile1(object sender, EventArgs e)
        {
            string uname = Master.Username;
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "update status set policy_1 = 1 where username = '" + uname + "' and attempt = '" + attempt + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            //File to be downloaded.
            string fileName = "Automated Patch Management Policy.pdf";

            //Path of the File to be downloaded.
            string filePath = Server.MapPath(string.Format("~/Files/{0}", fileName));

            //Content Type and Header.
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);

            //Writing the File to Response Stream.
            Response.WriteFile(filePath);

            //Flushing the Response.
            Response.Flush();
            Response.End();

        }

        protected void DownloadFile2(object sender, EventArgs e)
        {
            string uname = Master.Username;
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "update status set policy_2 = 1 where username = '" + uname + "' and attempt = '" + attempt + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            //File to be downloaded.
            string fileName = "Backup Restoration and Retention Policy.pdf";

            //Path of the File to be downloaded.
            string filePath = Server.MapPath(string.Format("~/Files/{0}", fileName));

            //Content Type and Header.
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);

            //Writing the File to Response Stream.
            Response.WriteFile(filePath);

            //Flushing the Response.
            Response.Flush();
            Response.End();
        }

        protected void DownloadFile3(object sender, EventArgs e)
        {
            string uname = Master.Username;
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "update status set policy_3 = 1 where username = '" + uname + "' and attempt = '" + attempt + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            //File to be downloaded.
            string fileName = "IT Risk Management Policy.pdf";

            //Path of the File to be downloaded.
            string filePath = Server.MapPath(string.Format("~/Files/{0}", fileName));

            //Content Type and Header.
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);

            //Writing the File to Response Stream.
            Response.WriteFile(filePath);

            //Flushing the Response.
            Response.Flush();
            Response.End();
        }

        protected void DownloadFile4(object sender, EventArgs e)
        {
            string uname = Master.Username;
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "update status set policy_4 = 1 where username = '" + uname + "' and attempt = '" + attempt + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            //File to be downloaded.
            string fileName = "SOP - EOD.pdf";

            //Path of the File to be downloaded.
            string filePath = Server.MapPath(string.Format("~/Files/{0}", fileName));

            //Content Type and Header.
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);

            //Writing the File to Response Stream.
            Response.WriteFile(filePath);

            //Flushing the Response.
            Response.Flush();
            Response.End();
        }
        protected void DownloadFile5(object sender, EventArgs e)
        {
            string uname = Master.Username;
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "update status set policy_5 = 1 where username = '" + uname + "' and attempt = '" + attempt + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            //File to be downloaded.
            string fileName = "Active Directory and Email Access Management.pdf";

            //Path of the File to be downloaded.
            string filePath = Server.MapPath(string.Format("~/Files/{0}", fileName));

            //Content Type and Header.
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);

            //Writing the File to Response Stream.
            Response.WriteFile(filePath);

            //Flushing the Response.
            Response.Flush();
            Response.End();
        }
        protected void DownloadFile6(object sender, EventArgs e)
        {
            string uname = Master.Username;
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "update status set policy_6 = 1 where username = '" + uname + "' and attempt = '" + attempt + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            //File to be downloaded.
            string fileName = "Application Development.pdf";

            //Path of the File to be downloaded.
            string filePath = Server.MapPath(string.Format("~/Files/{0}", fileName));

            //Content Type and Header.
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);

            //Writing the File to Response Stream.
            Response.WriteFile(filePath);

            //Flushing the Response.
            Response.Flush();
            Response.End();
        }

        protected void DownloadFile7(object sender, EventArgs e)
        {
            string uname = Master.Username;
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "update status set policy_7 = 1 where username = '" + uname + "' and attempt = '" + attempt + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            //File to be downloaded.
            string fileName = "Capacity Planning.pdf";

            //Path of the File to be downloaded.
            string filePath = Server.MapPath(string.Format("~/Files/{0}", fileName));

            //Content Type and Header.
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);

            //Writing the File to Response Stream.
            Response.WriteFile(filePath);

            //Flushing the Response.
            Response.Flush();
            Response.End();
        }

        protected void DownloadFile8(object sender, EventArgs e)
        {
            string uname = Master.Username;
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "update status set policy_8 = 1 where username = '" + uname + "' and attempt = '" + attempt + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            //File to be downloaded.
            string fileName = "Change Management.pdf";

            //Path of the File to be downloaded.
            string filePath = Server.MapPath(string.Format("~/Files/{0}", fileName));

            //Content Type and Header.
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);

            //Writing the File to Response Stream.
            Response.WriteFile(filePath);

            //Flushing the Response.
            Response.Flush();
            Response.End();
        }

        protected void DownloadFile9(object sender, EventArgs e)
        {
            string uname = Master.Username;
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "update status set policy_9 = 1 where username = '" + uname + "' and attempt = '" + attempt + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            //File to be downloaded.
            string fileName = "Database Management.pdf";

            //Path of the File to be downloaded.
            string filePath = Server.MapPath(string.Format("~/Files/{0}", fileName));

            //Content Type and Header.
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);

            //Writing the File to Response Stream.
            Response.WriteFile(filePath);

            //Flushing the Response.
            Response.Flush();
            Response.End();
        }
        protected void DownloadFile10(object sender, EventArgs e)
        {
            string uname = Master.Username;
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "update status set policy_10 = 1 where username = '" + uname + "' and attempt = '" + attempt + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            //File to be downloaded.
            string fileName = "Emergency Change Management.pdf";

            //Path of the File to be downloaded.
            string filePath = Server.MapPath(string.Format("~/Files/{0}", fileName));

            //Content Type and Header.
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);

            //Writing the File to Response Stream.
            Response.WriteFile(filePath);

            //Flushing the Response.
            Response.Flush();
            Response.End();
        }
        protected void DownloadFile11(object sender, EventArgs e)
        {
            string uname = Master.Username;
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "update status set policy_11 = 1 where username = '" + uname + "' and attempt = '" + attempt + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            //File to be downloaded.
            string fileName = "Helpdesk and IT Support.pdf";

            //Path of the File to be downloaded.
            string filePath = Server.MapPath(string.Format("~/Files/{0}", fileName));

            //Content Type and Header.
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);

            //Writing the File to Response Stream.
            Response.WriteFile(filePath);

            //Flushing the Response.
            Response.Flush();
            Response.End();
        }
        protected void DownloadFile12(object sender, EventArgs e)
        {
            string uname = Master.Username;
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "update status set policy_12 = 1 where username = '" + uname + "' and attempt = '" + attempt + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            //File to be downloaded.
            string fileName = "IT Asset Management.pdf";

            //Path of the File to be downloaded.
            string filePath = Server.MapPath(string.Format("~/Files/{0}", fileName));

            //Content Type and Header.
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);

            //Writing the File to Response Stream.
            Response.WriteFile(filePath);

            //Flushing the Response.
            Response.Flush();
            Response.End();
        }
        protected void DownloadFile13(object sender, EventArgs e)
        {
            string uname = Master.Username;
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "update status set policy_13 = 1 where username = '" + uname + "' and attempt = '" + attempt + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            //File to be downloaded.
            string fileName = "IT Budgeting Policy.pdf";

            //Path of the File to be downloaded.
            string filePath = Server.MapPath(string.Format("~/Files/{0}", fileName));

            //Content Type and Header.
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);

            //Writing the File to Response Stream.
            Response.WriteFile(filePath);

            //Flushing the Response.
            Response.Flush();
            Response.End();
        }
        protected void DownloadFile14(object sender, EventArgs e)
        {
            string uname = Master.Username;
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "update status set policy_14 = 1 where username = '" + uname + "' and attempt = '" + attempt + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            //File to be downloaded.
            string fileName = "IT Governance Policy.pdf";

            //Path of the File to be downloaded.
            string filePath = Server.MapPath(string.Format("~/Files/{0}", fileName));

            //Content Type and Header.
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);

            //Writing the File to Response Stream.
            Response.WriteFile(filePath);

            //Flushing the Response.
            Response.Flush();
            Response.End();
        }
        protected void DownloadFile15(object sender, EventArgs e)
        {
            string uname = Master.Username;
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "update status set policy_15 = 1 where username = '" + uname + "' and attempt = '" + attempt + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            //File to be downloaded.
            string fileName = "IT Monitoring.pdf";

            //Path of the File to be downloaded.
            string filePath = Server.MapPath(string.Format("~/Files/{0}", fileName));

            //Content Type and Header.
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);

            //Writing the File to Response Stream.
            Response.WriteFile(filePath);

            //Flushing the Response.
            Response.Flush();
            Response.End();
        }
        protected void DownloadFile16(object sender, EventArgs e)
        {
            string uname = Master.Username;
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "update status set policy_16 = 1 where username = '" + uname + "' and attempt = '" + attempt + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            //File to be downloaded.
            string fileName = "IT Personnel Management.pdf";

            //Path of the File to be downloaded.
            string filePath = Server.MapPath(string.Format("~/Files/{0}", fileName));

            //Content Type and Header.
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);

            //Writing the File to Response Stream.
            Response.WriteFile(filePath);

            //Flushing the Response.
            Response.Flush();
            Response.End();
        }
        protected void DownloadFile17(object sender, EventArgs e)
        {
            string uname = Master.Username;
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "update status set policy_17 = 1 where username = '" + uname + "' and attempt = '" + attempt + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            //File to be downloaded.
            string fileName = "IT Physical Access Management.pdf";

            //Path of the File to be downloaded.
            string filePath = Server.MapPath(string.Format("~/Files/{0}", fileName));

            //Content Type and Header.
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);

            //Writing the File to Response Stream.
            Response.WriteFile(filePath);

            //Flushing the Response.
            Response.Flush();
            Response.End();
        }
        protected void DownloadFile18(object sender, EventArgs e)
        {
            string uname = Master.Username;
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "update status set policy_18 = 1 where username = '" + uname + "' and attempt = '" + attempt + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            //File to be downloaded.
            string fileName = "IT Strategic Planning.pdf";

            //Path of the File to be downloaded.
            string filePath = Server.MapPath(string.Format("~/Files/{0}", fileName));

            //Content Type and Header.
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);

            //Writing the File to Response Stream.
            Response.WriteFile(filePath);

            //Flushing the Response.
            Response.Flush();
            Response.End();
        }
        protected void DownloadFile19(object sender, EventArgs e)
        {
            string uname = Master.Username;
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "update status set policy_19 = 1 where username = '" + uname + "' and attempt = '" + attempt + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            //File to be downloaded.
            string fileName = "Logical Access Management.pdf";

            //Path of the File to be downloaded.
            string filePath = Server.MapPath(string.Format("~/Files/{0}", fileName));

            //Content Type and Header.
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);

            //Writing the File to Response Stream.
            Response.WriteFile(filePath);

            //Flushing the Response.
            Response.Flush();
            Response.End();
        }
        protected void DownloadFile20(object sender, EventArgs e)
        {
            string uname = Master.Username;
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "update status set policy_20 = 1 where username = '" + uname + "' and attempt = '" + attempt + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            //File to be downloaded.
            string fileName = "Network Management.pdf";

            //Path of the File to be downloaded.
            string filePath = Server.MapPath(string.Format("~/Files/{0}", fileName));

            //Content Type and Header.
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);

            //Writing the File to Response Stream.
            Response.WriteFile(filePath);

            //Flushing the Response.
            Response.Flush();
            Response.End();
        }
        protected void DownloadFile21(object sender, EventArgs e)
        {
            string uname = Master.Username;
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "update status set policy_21 = 1 where username = '" + uname + "' and attempt = '" + attempt + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            //File to be downloaded.
            string fileName = "Project Management.pdf";

            //Path of the File to be downloaded.
            string filePath = Server.MapPath(string.Format("~/Files/{0}", fileName));

            //Content Type and Header.
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);

            //Writing the File to Response Stream.
            Response.WriteFile(filePath);

            //Flushing the Response.
            Response.Flush();
            Response.End();
        }
        protected void DownloadFile22(object sender, EventArgs e)
        {
            string uname = Master.Username;
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "update status set policy_22 = 1 where username = '" + uname + "' and attempt = '" + attempt + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            //File to be downloaded.
            string fileName = "Quality Assurance (QA).pdf";

            //Path of the File to be downloaded.
            string filePath = Server.MapPath(string.Format("~/Files/{0}", fileName));

            //Content Type and Header.
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);

            //Writing the File to Response Stream.
            Response.WriteFile(filePath);

            //Flushing the Response.
            Response.Flush();
            Response.End();
        }
        protected void DownloadFile23(object sender, EventArgs e)
        {
            string uname = Master.Username;
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "update status set policy_23 = 1 where username = '" + uname + "' and attempt = '" + attempt + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            //File to be downloaded.
            string fileName = "Supplier Management.pdf";

            //Path of the File to be downloaded.
            string filePath = Server.MapPath(string.Format("~/Files/{0}", fileName));

            //Content Type and Header.
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);

            //Writing the File to Response Stream.
            Response.WriteFile(filePath);

            //Flushing the Response.
            Response.Flush();
            Response.End();
        }
        protected void DownloadFile24(object sender, EventArgs e)
        {
            string uname = Master.Username;
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "update status set policy_24 = 1 where username = '" + uname + "' and attempt = '" + attempt + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            //File to be downloaded.
            string fileName = "System Management and Administration.pdf";

            //Path of the File to be downloaded.
            string filePath = Server.MapPath(string.Format("~/Files/{0}", fileName));

            //Content Type and Header.
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);

            //Writing the File to Response Stream.
            Response.WriteFile(filePath);

            //Flushing the Response.
            Response.Flush();
            Response.End();
        }
    }
}