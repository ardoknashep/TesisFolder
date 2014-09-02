using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Web.Security;

namespace HermesNet
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("Login.aspx");
        }

        //[WebMethod]
        //public static string CerrarSesion()
        //{
        //    try
        //    {
        //        FormsAuthentication.SignOut();
        //        return "SI";
        //    }
        //    catch (Exception)
        //    {
        //        return "Error";
        //    }            
        //}
    }
}