using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HermesNet.Comun
{
    public partial class SolIncorporacionCarga : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            llenaEsaContratante();
            llenaFiliales();
            llenarPolizas();
            llenarParetntesco();
        }

        public void llenaEsaContratante()
        {
            List<string> arrEsaContratante = new List<string>();
            arrEsaContratante.Add("Empresa N°1");
            arrEsaContratante.Add("Empresa N°2");

            ddlEsaContratante.DataSource = arrEsaContratante;
            ddlEsaContratante.DataBind();
        }

        public void llenaFiliales()
        {
            List<string> arrFiliales = new List<string>();
            arrFiliales.Add("Filial N°1");
            arrFiliales.Add("Filial N°2");

            ddlFiliales.DataSource = arrFiliales;
            ddlFiliales.DataBind();
        }

        public void llenarPolizas()
        {
            List<string> arrPolizas = new List<string>();
            arrPolizas.Add("340004777");
            arrPolizas.Add("340004778");
            arrPolizas.Add("340002779");

            ddlPolizas.DataSource = arrPolizas;
            ddlPolizas.DataBind();
        }

        public void llenarParetntesco()
        {
            List<string> arrParentesco = new List<string>();
            arrParentesco.Add("Cónyuge");
            arrParentesco.Add("Hijo(a)");
            arrParentesco.Add("Otro");

            ddlParentesco.DataSource = arrParentesco;
            ddlParentesco.DataBind();
        }
    }
}