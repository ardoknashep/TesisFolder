using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HermesNet.Comun
{
    public partial class MantenedorPoliza : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            llenarEsaContratante();
        }
        public void llenarEsaContratante()
        {
            List<string> arrEsaCont = new List<string>();
            arrEsaCont.Add("Empresa Contratante N°1");
            arrEsaCont.Add("Empresa Contratante N°2");
            arrEsaCont.Add("Empresa Contratante N°3");

            ddlEsaContratante.DataSource = arrEsaCont;
            ddlEsaContratante.DataBind();
        }

        protected void btnCrearPoliza_Click(object sender, EventArgs e)
        {
            Response.Redirect("CrearPoliza.aspx");
        }
    }
}