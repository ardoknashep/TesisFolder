using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HermesNet.Comun
{
    public partial class CrearAseguradora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            llenarRegion();
            llenarComuna();
        }

        public void llenarRegion()
        {
            List<string> arrRegion = new List<string>();
            arrRegion.Add("I Región");
            arrRegion.Add("II Región");

            ddlRegion.DataSource = arrRegion;
            ddlRegion.DataBind();
        }

        public void llenarComuna()
        {
            List<string> arrComuna = new List<string>();
            arrComuna.Add("Comuna 1");
            arrComuna.Add("Comuna 2");

            ddlComuna.DataSource = arrComuna;
            ddlComuna.DataBind();
        }
    }
}