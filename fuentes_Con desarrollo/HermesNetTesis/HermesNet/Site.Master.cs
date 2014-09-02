using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace HermesNet
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var nn = FormsAuthentication.Decrypt(Request.Cookies["Default"].Value);
            Array nn2 = nn.UserData.Split('|');
            string rol = nn2.GetValue(nn2.Length - 1).ToString();
            
        }
    }
}
