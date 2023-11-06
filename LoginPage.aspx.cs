using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Data.SqlClient;

namespace Policy_Portal
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session.Clear();
                Session.Abandon();
            }


        }

        protected void Btnlogin_Click(object sender, EventArgs e)
        {
            string domain = "jubileelife.com";
            string username = User.Text;
            string password = Pass.Text;
            ActiveDirectoryHelper ADhelper = new ActiveDirectoryHelper();
            var details = ADhelper.GetUserByLoginName(User.Text);
            var ADuser = details.LoginName;

            string ldapPath = $"LDAP://dc.jubileelife.com/DC=jubileelife,DC=com{domain}";

            PrincipalContext context = new PrincipalContext(ContextType.Domain, domain);
            //Username and password for authentication.
            bool is_valid = context.ValidateCredentials(username, password);

            if (is_valid)
            {
                // Check if the AD username matches a username in the PortalUsers table
                if (IsAuthorizedUser(ADuser, out string fullname, out string userName))
                {
                    // Store user data in session variables
                    Session["IsLoggedIn"] = true;
                    //Session["UserRole"] = role;
                    Session["UserName"] = userName;
                    // Session["EmployeeID"] = employeeID;
                    //Session["Department"] = Department;
                    Session["FullName"] = fullname;
                    // Session["TeamName"] = TeamName;
                    // Session["Email"] = Email;

                    Response.Redirect("PolicyForm.aspx");
                }
                else
                {
                    lblerror.Visible = true;
                    lblerror.Text = "Unauthorized user.";
                }
            }

            else
            {
                lblerror.Visible = true;
                lblerror.Text = "Invalid login credential.";
            }
        }

        private bool IsAuthorizedUser(string username, out string fullname, out string userName)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ConnectionString;
            // role = employeeID = fullname = Department = userName = TeamName = Email = string.Empty;
            userName = fullname = string.Empty;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM IT_USER WHERE Username = @UserName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", username);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Email = reader["Email"].ToString();
                        // role = reader["Designation"].ToString();
                        //  employeeID = reader["EmployeeID"].ToString();
                        fullname = reader["Name"].ToString();
                        // Department = reader["Department"].ToString();
                        userName = reader["Username"].ToString();
                        // TeamName = reader["TeamName"].ToString();
                        return true;
                    }
                }
            }

            return false;
        }

    }
}