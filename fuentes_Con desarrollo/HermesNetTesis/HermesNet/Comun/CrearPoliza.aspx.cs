using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HermesNet.Comun
{
    public partial class CrearPoliza : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            llenarEsaContratante();
            llenarFiliales();
            llenarEsaPoliza();
            llenaAseguradoras();
            llenarTipoSeguro();
        }

        public void llenarEsaContratante()
        {
            List<string> arrllenarEsa = new List<string>();
            arrllenarEsa.Add("Empresa N°1");
            arrllenarEsa.Add("Empresa N°2");
            arrllenarEsa.Add("Empresa N°3");

            ddlEsaContratante.DataSource = arrllenarEsa;
            ddlEsaContratante.DataBind();
        }

        public void llenarFiliales()
        {
            List<string> arrfiliales = new List<string>();
            arrfiliales.Add("Filial N°1");
            arrfiliales.Add("Filial N°2");
            arrfiliales.Add("Filial N°3");

            ddlFiliales.DataSource = arrfiliales;
            ddlFiliales.DataBind();
        }

        public void llenarEsaPoliza()
        {
            List<string> arrEsaPoliza = new List<string>();
            arrEsaPoliza.Add("CCAF Los Andes");
            arrEsaPoliza.Add("Yamana Gold");
            arrEsaPoliza.Add("Minera Florida");

            ddlEsaPoliza.DataSource = arrEsaPoliza;
            ddlEsaPoliza.DataBind();
        }

        public void llenaAseguradoras()
        {
            List<string> arrAseguradora = new List<string>();
            arrAseguradora.Add("Metlife");
            arrAseguradora.Add("Consorcio");
            arrAseguradora.Add("Euroamérica");

            ddlAseguradoras.DataSource = arrAseguradora;
            ddlAseguradoras.DataBind();
        }

        public void llenarTipoSeguro()
        {
            List<string> arrTipoSeg = new List<string>();
            arrTipoSeg.Add("Vida");
            arrTipoSeg.Add("Salud");

            ddlTipoSeguro.DataSource = arrTipoSeg;
            ddlTipoSeguro.DataBind();
        }
    }
}