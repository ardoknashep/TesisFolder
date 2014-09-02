using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HermesNet.Administrador
{
    public partial class EditarUsuarioSistema : System.Web.UI.Page
    {
        public string RutUsuario
        {
            get
            {
                if (Session["_rutUsuario"] == null)
                {
                    Session["_rutUsuario"] = "NO";
                }
                return (string)(Session["_rutUsuario"]);
            }
            set
            {
                Session["_rutUsuario"] = value;
            }
        }

        public string AccionMantenedorUsuario
        {
            get
            {
                if (Session["_accionMUser"] == null)
                {
                    Session["_accionMUser"] = "NO";
                }
                return (string)(Session["_accionMUser"]);
            }
            set
            {
                Session["_accionMUser"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (RutUsuario != "NO" && AccionMantenedorUsuario == "Editar")
            {
                rutUsr.InnerHtml = RutUsuario;
            }
            else
            {

            }
        }
    }
}