using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
namespace Policy_Portal
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnlogin_Click(object sender, EventArgs e)
        {
            string domain = "jubileelife.com";
            string username = txtid.Text;
            string password = txtpass.Text;
           

            string ldapPath = $"LDAP://dc.jubileelife.com/DC=jubileelife,DC=com{domain}";

            PrincipalContext context = new PrincipalContext(ContextType.Domain, domain);
            //Username and password for authentication.
            bool is_valid = context.ValidateCredentials(username, password);

            if (is_valid)
            {
                Response.Redirect("PolicyForm.aspx");
            }
            else
            {
                lblerror.Visible = true;
                lblerror.Text = "incoorect password";
            
        
    }
}
        }
    }
