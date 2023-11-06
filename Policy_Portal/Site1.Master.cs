using System;
using System.Collections.Generic;
using System.EnterpriseServices.CompensatingResourceManager;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Policy_Portal
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        public string Username
        {
            get
            {
                // Get value of control on master page  
                return ULabel.Text;
            }
            set
            {
                // Set new value for control on master page  
                ULabel.Text = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

    }
}