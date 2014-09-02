using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HermesNet.Negocio;
using HermesNet.Model;

namespace HermesNet.Comun
{
    public partial class MantenedorEmpresaPoliza : System.Web.UI.Page
    {
        public EmpresaPolizaVO EmpPol
        {
            get
            {
                if (Session["empresaPoliza"] == null)
                {
                    Session["empresaPoliza"] = new EmpresaPolizaVO();
                }
                return (EmpresaPolizaVO)Session["empresaPoliza"];
            }
            set
            {
                Session["empresaPoliza"] = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            Response.Redirect("CrearEmpresaPoliza.aspx");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            EmpresaPolizaNegocio emp = new EmpresaPolizaNegocio();

            if (txtRut.Text == string.Empty && txtDV.Text == string.Empty && txtRazonSocial.Text == string.Empty)
            {
                this.LimpiarDV();
                dvMensaje.InnerHtml = "<p style='background-color:red;'>Debe ingresar filtro de búsqueda</p>";
            }
            else
            {
                if (txtRut.Text != string.Empty && txtDV.Text != string.Empty && txtRazonSocial.Text == string.Empty)
                {
                    if (txtRut.Text != string.Empty && txtDV.Text != string.Empty)
                    {
                        if (txtRut.Text == "1" && txtDV.Text == "9")
                        {
                            this.LimpiarDV();
                            dvMensaje.InnerHtml = "<p style='background-color:red;'>El rut NO es válido</p>";
                        }
                        else
                        {
                            long rut;
                            char dv;
                            UtilitarioNegocio uNeg = new UtilitarioNegocio();
                            string rutEmp = txtRut.Text.Trim() + txtDV.Text.Trim();
                            bool validaRut = false;
                            validaRut = uNeg.ValidarRut(rutEmp);
                            if (validaRut == true)
                            {
                                if (long.TryParse(txtRut.Text, out rut))
                                {
                                    if (char.TryParse(txtDV.Text, out dv))
                                    {
                                        EmpPol = emp.BuscarEmpPolizaPorRut(rut, dv);
                                        if (EmpPol.RazonSocial != string.Empty)
                                        {
                                            this.LimpiarDV();
                                            dvTabla.InnerHtml = "<table border=1 align='center'>";
                                            this.CrearTabla();
                                            dvTabla.InnerHtml += "<tr>";
                                            dvTabla.InnerHtml += "<td>" + EmpPol.Rut + "-" + EmpPol.Dv + "</td>";
                                            dvTabla.InnerHtml += "<td>" + EmpPol.RazonSocial + "</td>";
                                            dvTabla.InnerHtml += "</tr>";
                                            dvTabla.InnerHtml += "</table>";
                                        }
                                        else
                                        {
                                            this.LimpiarDV();
                                            dvMensaje.InnerHtml = "<p style='background-color:red;'>No se encontraron coincidencias</p>";
                                        }
                                    }
                                }
                            }
                            else
                            {
                                this.LimpiarDV();
                                dvMensaje.InnerHtml = "<p style='background-color:red;'>El rut NO es válido</p>";
                            }
                        }
                    }
                }
                else
                {
                    this.LimpiarDV();
                    dvMensaje.InnerHtml = "<p style='background-color:red;'>Debe ingresar Rut y Dígito Verificador</p>";
                }
                if(txtRazonSocial.Text!= string.Empty)
                    {
                        this.LimpiarDV();
                        List<EmpresaPolizaVO> lempPoliza = emp.ObtenerEmpPolizaPorRazonSocial(txtRazonSocial.Text);
                        //EmpresaPolizaVO empresaP = new EmpresaPolizaVO();

                        if (lempPoliza.Count > 0)
                        {
                            dvTabla.InnerHtml = "<table border=1 align='center'>";
                            this.CrearTabla();
                            foreach (EmpresaPolizaVO item in lempPoliza)
                            {

                                dvTabla.InnerHtml += "<tr>";
                                dvTabla.InnerHtml += "<td>" + item.Rut + "-" + item.Dv + "</td>";
                                dvTabla.InnerHtml += "<td>" + item.RazonSocial+ "</td>";
                                dvTabla.InnerHtml += "</tr>";
                                
                            }
                            dvTabla.InnerHtml += "</table>";

                        }
                        else
                        {
                            this.LimpiarDV();
                            dvMensaje.InnerHtml = "<p style='background-color:red;'>No se encontraron coincidencias</p>";
                        }
                    } 
            }
        }

        private void LimpiarDV()
        {
            dvMensaje.InnerHtml = "";
            dvTabla.InnerHtml = "";
        }

        private void CrearTabla()
        {
            dvTabla.InnerHtml += "<tr>";
            dvTabla.InnerHtml += "<th>Rut Empresa</th>";
            dvTabla.InnerHtml += "<th>Razón Social</th>";
            dvTabla.InnerHtml += "</tr>";

        }
    }
}