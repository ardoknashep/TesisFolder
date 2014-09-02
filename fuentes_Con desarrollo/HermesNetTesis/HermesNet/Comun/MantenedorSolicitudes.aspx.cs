using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HermesNet.Comun
{
    public partial class MantenedorSolicitudes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            llenarPolizas();
        }
        public void llenarPolizas()
        {
            List<string> arrPolizas = new List<string>();
            arrPolizas.Add("340004777");
            arrPolizas.Add("340004778");
            arrPolizas.Add("340004779");

            ddlPolizas.DataSource = arrPolizas;
            ddlPolizas.DataBind();
        }

        protected void btnRevisar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Administrador/ValidarDocumentacion.aspx");
        }

        protected void btnRev_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Administrador/ValidarEstadoFinalReembolso.aspx");
        }
    }
}