using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Security.Principal;

namespace HermesNet
{
    public class Global : System.Web.HttpApplication
    {

        void Application_Start(object sender, EventArgs e)
        {
            // Código que se ejecuta al iniciarse la aplicación

        }

        void Application_End(object sender, EventArgs e)
        {
            //  Código que se ejecuta cuando se cierra la aplicación

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Código que se ejecuta al producirse un error no controlado

        }

        void Session_Start(object sender, EventArgs e)
        {
            // Código que se ejecuta cuando se inicia una nueva sesión

        }

        void Session_End(object sender, EventArgs e)
        {
            // Código que se ejecuta cuando finaliza una sesión.
            // Nota: el evento Session_End se desencadena sólo cuando el modo sessionstate
            // se establece como InProc en el archivo Web.config. Si el modo de sesión se establece como StateServer 
            // o SQLServer, el evento no se genera.

        }

        /// <summary>
        /// Metodo para la autenticación , falta implementar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Application_AuthenticateRequest(Object sender, EventArgs e)
        {
            //if (HttpContext.Current.User != null)
            //{
            //    if (HttpContext.Current.User.Identity.IsAuthenticated)
            //    {
            //        if (HttpContext.Current.User.Identity is FormsIdentity)
            //        {
            //            FormsIdentity id =
            //                (FormsIdentity)HttpContext.Current.User.Identity;
            //            FormsAuthenticationTicket ticket = id.Ticket;

            //            // Get the stored user-data, in this case, our roles
            //            string userData = ticket.UserData;
            //            string[] roles = userData.Split('~');
            //            string[] rol = roles[1].Split(',');
            //            HttpContext.Current.User = new GenericPrincipal(id, rol);
            //        }
            //    }
            //}
        }

    }
}
