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
    public partial class MantenedorAseguradoras : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscarAseguradora_Click(object sender, EventArgs e)
        {
            AseguradoraNegocio aseg = new AseguradoraNegocio();
            UtilitarioNegocio uNeg = new UtilitarioNegocio();
            //dv = Convert.ToChar(dvTexto);         
            long rut;
            char dv;
            string rutTexto = this.txtRutAseguradora.Text;
            string dvTexto = this.txtDvAseguradora.Text;
            if (txtRutAseguradora.Text == string.Empty && txtDvAseguradora.Text == string.Empty && txtRazonSocialAseg.Text == string.Empty)
            {
                this.LimpiarDiv();
                this.EliminaTabla();
                dvMensajeError.InnerHtml = "<p style='background-color:red;'>Debe ingresar filtro de búsqueda</p>";
            }
            else
            {
                if (txtRutAseguradora.Text != string.Empty && txtDvAseguradora.Text != string.Empty && txtRazonSocialAseg.Text==string.Empty)
                {
                    if (txtRutAseguradora.Text == "1" && txtDvAseguradora.Text == "9")
                    {
                        this.LimpiarDiv();
                        this.EliminaTabla();
                        dvMensajeError.InnerHtml = "<p style='background-color:red;'>El rut NO es válido</p>";
                    }
                    else
                    {
                        string rutAseg = txtRutAseguradora.Text.Trim() + txtDvAseguradora.Text.Trim();
                        bool valida = uNeg.ValidarRut(rutAseg);
                        if (valida)
                        {
                            if (long.TryParse(rutTexto, out rut))
                            {
                                if (char.TryParse(dvTexto, out dv))
                                {
                                    AseguradoraVO ase = aseg.AseguradoraPorRut(rut, dv);
                                    if (ase.Rut == 0)
                                    {
                                        this.LimpiarDiv();
                                        this.EliminaTabla();
                                        dvServidor.InnerHtml += "<p style='background-color:red'>NO existen coincidencias</p>";
                                    }
                                    else
                                    {
                                        this.LimpiarDiv();
                                        dvServidor.InnerHtml = "<table border=1 align='center'>";
                                        this.ObtenerEncabezado();
                                        dvServidor.InnerHtml += "<tr>";
                                        dvServidor.InnerHtml += "<td>" + string.Format("{0}-{1}", ase.Rut, ase.Dv) + "</td>";
                                        dvServidor.InnerHtml += "<td>" + ase.RazonSocial + "</td>";
                                        dvServidor.InnerHtml += "<td>" + ase.Direccion + "</td>";
                                        dvServidor.InnerHtml += "<td>" + ase.Telefono + "</td>";
                                        dvServidor.InnerHtml += "<td>" + ase.Email + "</td>";
                                        dvServidor.InnerHtml += "</tr>";
                                        dvServidor.InnerHtml += "</table>";
                                    }
                                }
                                //    else
                                //    {
                                //        this.LimpiarDiv();
                                //        this.EliminaTabla();
                                //        dvMensajeError.InnerHtml = "<p style='background-color:red;'>Debe ingresar sólo Números o letra K</p>";
                                //    }
                            }

                            //else
                            //{
                            //    this.LimpiarDiv();
                            //    this.EliminaTabla();
                            //    dvServidor.InnerHtml += "<p style='background-color:red'>El rut no es válido</p>";
                            //}
                        }

                        else
                        {
                            this.LimpiarDiv();
                            this.EliminaTabla();
                            dvMensajeError.InnerHtml = "<p style='background-color:red;'>El rut NO es válido</p>";
                        }
                    }

                }
                else
                {
                    this.LimpiarDiv();
                    this.EliminaTabla();
                    dvMensajeError.InnerHtml = "<p style='background-color:red;'>Debe ingresar rut y dígito verificador</p>";
                }

                string razonSocial = this.txtRazonSocialAseg.Text;

                if (txtRazonSocialAseg.Text != string.Empty)
                {

                    List<AseguradoraVO> asegu = aseg.AseguradoraPorRazonSocial(razonSocial);
                    if (asegu.Count > 0)
                    {
                        this.LimpiarDiv();
                        dvServidor.InnerHtml = "<table border=1 align='center'>";
                        this.ObtenerEncabezado();
                        foreach (AseguradoraVO item in asegu)
                        {                            
                            dvServidor.InnerHtml += "<tr>";
                            dvServidor.InnerHtml += "<td>" + string.Format("{0}-{1}", item.Rut, item.Dv) + "</td>";
                            dvServidor.InnerHtml += "<td>" + item.RazonSocial + "</td>";
                            dvServidor.InnerHtml += "<td>" + item.Direccion + "</td>";
                            dvServidor.InnerHtml += "<td>" + item.Telefono + "</td>";
                            dvServidor.InnerHtml += "<td>" + item.Email + "</td>";
                            dvServidor.InnerHtml += "</tr>";
                        }
                        dvServidor.InnerHtml += "</table>";
                    }
                    else
                    {
                        this.LimpiarDiv();
                        this.EliminaTabla();
                        dvServidor.InnerHtml += "<p style='background-color:red'>NO existen coincidencias</p>";
                        //dvServidor.InnerHtml = alertaNoCoincidencia();
                    }
                }
            }   
        }

        private void EliminaTabla()
        {
            dvServidor.InnerHtml = "";
        }

        private void LimpiarDiv()
        {
            dvMensajeError.InnerHtml = "";
            dvServidor.InnerHtml += "";
            
        }

        private void ObtenerEncabezado()
        {
            dvServidor.InnerHtml += "<tr>";
            dvServidor.InnerHtml += "<th>Rut</th>";
            dvServidor.InnerHtml += "<th>Raz&oacute;n Social</th>";
            dvServidor.InnerHtml += "<th>Direcci&oacute;n</th>";
            dvServidor.InnerHtml += "<th>Tel&eacute;fono</th>";
            dvServidor.InnerHtml += "<th>E-mail</th>";
            dvServidor.InnerHtml += "</tr>";
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtRutAseguradora.Text = "";
            txtDvAseguradora.Text = "";
            txtRazonSocialAseg.Text = "";
            dvMensajeError.InnerHtml = "<p></p>";
            dvServidor.InnerHtml = "<p></p>";
        }
    }
}