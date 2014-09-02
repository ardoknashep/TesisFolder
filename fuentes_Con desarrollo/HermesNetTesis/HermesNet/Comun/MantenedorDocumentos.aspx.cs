using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HermesNet.Comun
{
    public partial class MantenedorDocumentos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            llenarAseguradora();
            llenarTipoSolicitud();
        }

        public void llenarAseguradora()
        {
            List<string> aseguradora = new List<string>();
            aseguradora.Add("Aseguradora 1");
            aseguradora.Add("Aseguradora 2");

            ddlAseguradora.DataSource = aseguradora;
            ddlAseguradora.DataBind();
        }

        public void llenarTipoSolicitud()
        {
            List<string> tipoSolicitud = new List<string>();
            tipoSolicitud.Add("Tipo 1");
            tipoSolicitud.Add("Tipo 2");

            ddlTipoSolicitud.DataSource = tipoSolicitud;
            ddlTipoSolicitud.DataBind();
        }

        protected void btnIngresarNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Administrador/IngresarNuevoDocumento.aspx");
        }
    }
}