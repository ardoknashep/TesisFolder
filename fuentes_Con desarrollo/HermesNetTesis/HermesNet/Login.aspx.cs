using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using HermesNet.WebServiceHermesNet;
using HermesNet.Negocio;
using System.Web.Security;

namespace HermesNet
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["txtUsr"] != null)
            {
                string username = Request.Form["txtUsr"];
                string password = Request.Form["txtPasswd"];

                /*Establece la conexión al web Service*/
                var cliWS = new WebServiceHermesNet.WSHermesNetSoapClient();

                AutenticacionLoginNegocio aln = new AutenticacionLoginNegocio();
                WSHeader cab = new WSHeader();
                cab.Credenciales = aln.GenerarFirmaEncriptada(username, password);

                RespuestaLoginVO rlvo = cliWS.buscarLogin(cab, username, password);

                if (rlvo.Estado == 1)
                {
                    GenerarAutenticacion(rlvo,username);
                    
                    string strRedirect;
                    strRedirect = Request["ReturnUrl"];
                    if (strRedirect == null)
                    {
                        strRedirect = "Default.aspx";
                    }

                    Response.Redirect(strRedirect, true);
                }
                else
                {
                    Response.Redirect("Login.aspx", true);
                    //Falta escribir mensaje de error con script manager
                }

            }
        }

        /// <summary>
        /// Genera la cookie de Session para mantenerse conectado a la aplicación
        /// </summary>
        /// <param name="rlvo"></param>
        /// <param name="username"></param>
        private void GenerarAutenticacion(RespuestaLoginVO rlvo,string username)
        {
            string data = string.Format("{0}-{1}|{2}|{3}|{4}|{5}|{6}|{7}", rlvo.Rut,
                                                            rlvo.Dv,
                                                            rlvo.NombreUsuario,
                                                            rlvo.ApellidoPaterno,
                                                            rlvo.ApellidoMaterno,
                                                            rlvo.Cargo,
                                                            rlvo.Mail,
                                                            rlvo.Rol.ToUpper());
            FormsAuthenticationTicket tkt;
            
            string cookiestr;
            HttpCookie ck;
            tkt = new FormsAuthenticationTicket(1, username, DateTime.Now, DateTime.Now.AddHours(24), false, data);
            
            cookiestr = FormsAuthentication.Encrypt(tkt);
            ck = new HttpCookie(FormsAuthentication.FormsCookieName, cookiestr);
            ck.Expires = tkt.Expiration;
            Response.Cookies.Add(ck);
        }
    }
}