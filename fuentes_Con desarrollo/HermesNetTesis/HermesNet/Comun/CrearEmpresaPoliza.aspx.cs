using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HermesNet.Model;
using HermesNet.Negocio;

namespace HermesNet.Comun
{
    public partial class CrearEmpresaPoliza : System.Web.UI.Page
    {
        public EmpresaPolizaVO EmpPoliza
        {
            get
            {
                if (Session["empPoliza"] == null)
                {
                    Session["empPoliza"] = new EmpresaPolizaVO();
                }
                return (EmpresaPolizaVO)Session["empPoliza"];
            }
            set
            {
                Session["empPoliza"] = value;
            }
        }


        public List<RegionVO> Regiones
        {
            get
            {
                if (Session["regiones"] == null)
                {
                    Session["regiones"] = new List<RegionVO>();
                }
                return (List<RegionVO>)(Session["regiones"]);
            }
            set
            {
                Session["regiones"] = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["regiones"] == null && ddlRegion.DataSource == null)
                {
                    this.llenarRegion();
                    this.llenarComuna();
                }
            }
        }

        public void llenarRegion()
        {
            RegionNegocio reg = new RegionNegocio();
            List<RegionVO> lreg = reg.ObtenerRegiones();
            
            //foreach (RegionVO item in lreg)
            //{
            //    ddlRegion.Items.Add(item.Descripcion);
                
            //}
            
            ddlRegion.DataTextField = "Descripcion";
            ddlRegion.DataValueField = "Id_region";
            ddlRegion.DataSource = lreg;
            ddlRegion.DataBind();
        }

        public void llenarComuna()
        {
            ComunaNegocio com = new ComunaNegocio();
            long idReg;
            if (long.TryParse(ddlRegion.SelectedValue, out idReg))
            {
                List<ComunaVO> lcom = com.ObtenerComunas(idReg);
                //foreach (ComunaVO item in lcom)
                //{
                //    ddlComuna.Items.Add(item.Nombre);

                //}
                ddlComuna.DataTextField = "Nombre";
                ddlComuna.DataValueField = "Id_comuna";
                ddlComuna.DataSource = lcom;
                ddlComuna.DataBind();
            }
        }

        protected void btnValidar_Click(object sender, EventArgs e)
        {

            //UtilitarioNegocio uNeg = new UtilitarioNegocio();
            //long rut;
            //char dv;
            if (txtRut.Text != string.Empty && txtDV.Text != string.Empty)
            {
                if (txtRut.Text == "1" && txtDV.Text == "9")
                {
                    dvPrueba.InnerHtml = "<p style='background-color:red'>El rut NO es válido</p>";
                }
                else
                {
                    this.ValidaSiExisteRut();
            //        string rutEmp = txtRut.Text.Trim() + txtDV.Text.Trim();
            //        bool valida = uNeg.ValidarRut(rutEmp);
            //        if (valida)
            //        {
            //            if (long.TryParse(txtRut.Text, out rut))
            //            {
            //                if (char.TryParse(txtDV.Text, out dv))
            //                {

            //                    EmpresaPolizaNegocio emPN = new EmpresaPolizaNegocio();
            //                    EmpresaPolizaVO empP = emPN.BuscarEmpPolizaPorRut(rut, dv);

            //                    if (empP.RazonSocial == string.Empty)
            //                    {
            //                        dvPrueba.InnerHtml = "<p style='background-color:yellow'>La Empresa Póliza No Existe, favor ingrese datos</p>";
            //                    }
            //                    else
            //                    {
            //                        dvPrueba.InnerHtml = "<p style='background-color:red'>La empresa " + empP.RazonSocial + " ya existe en sistema</p>";
            //                    }
            //                }
            //                else
            //                {
            //                    dvPrueba.InnerHtml = "<p style='background-color:red'>Deben ingresar sólo números o letra K</p>";
            //                }
            //            }
            //            else
            //            {
            //                dvPrueba.InnerHtml = "<p style='background-color:red'>Deben ingresar sólo números</p>";
            //            }
            //        }
            //        else
            //        {
            //            dvPrueba.InnerHtml = "<p style='background-color:red'>El rut NO es válido</p>";
            //        }
               }
            }
            else
            {
                dvPrueba.InnerHtml = "<p style='background-color:red'>Debe ingresar rut y dígito verificador</p>";
            }

        }

        private void ValidaSiExisteRut()
        {
            UtilitarioNegocio uNeg = new UtilitarioNegocio();
            long rut;
            char dv;
            string rutEmp = txtRut.Text.Trim() + txtDV.Text.Trim();
            bool valida = uNeg.ValidarRut(rutEmp);
            if (valida)
            {
                if (long.TryParse(txtRut.Text, out rut))
                {
                    if (char.TryParse(txtDV.Text, out dv))
                    {

                        EmpresaPolizaNegocio emPN = new EmpresaPolizaNegocio();
                        EmpresaPolizaVO empP = emPN.BuscarEmpPolizaPorRut(rut, dv);

                        if (empP.RazonSocial == string.Empty)
                        {
                            dvPrueba.InnerHtml = "<p style='background-color:yellow'>La Empresa Póliza No Existe, favor ingrese datos</p>";
                        }
                        else
                        {
                            dvPrueba.InnerHtml = "<p style='background-color:red'>La empresa " + empP.RazonSocial + " ya existe en sistema</p>";
                        }
                    }
                    else
                    {
                        dvPrueba.InnerHtml = "<p style='background-color:red'>Deben ingresar sólo números o letra K</p>";
                    }
                }
                else
                {
                    dvPrueba.InnerHtml = "<p style='background-color:red'>Deben ingresar sólo números</p>";
                }
            }
            else
            {
                dvPrueba.InnerHtml = "<p style='background-color:red'>El rut NO es válido</p>";
            }
        }

        protected void ddlRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.llenarComuna();
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtRut.Text != string.Empty && txtDV.Text != string.Empty && txtRazonSocial.Text != string.Empty)
            {
                this.ValidaSiExisteRut();
                EmpresaPolizaNegocio empPN = new EmpresaPolizaNegocio();
                //EmpresaPolizaVO empP = new EmpresaPolizaVO();
                long rut, idComuna;
                char dv;
                string razonSoc = txtRazonSocial.Text, direccion = txtDireccion.Text, telefono = txtTelefono.Text, email = txtMail.Text;

                if(long.TryParse(txtRut.Text, out rut))
                {
                    if(char.TryParse(txtDV.Text, out dv))
                    {
                        if(long.TryParse(ddlComuna.SelectedValue, out idComuna))
                        {
                            int crear = empPN.CrearEmpresaPoliza(rut,dv,razonSoc,direccion,idComuna,telefono,email);
                            EmpPoliza = empPN.BuscarEmpPolizaPorRut(rut, dv);
                            if (EmpPoliza.RazonSocial != string.Empty)
                            {
                                this.LimpiarControles();
                                dvPrueba.InnerHtml = "<p style='background-color:lime'>La empresa " + EmpPoliza.RazonSocial + " ha sido ingresada!</p>";
                            }
                            else
                            {
                                dvPrueba.InnerHtml = "<p style='background-color:red'>No se han podido ingresar los datos</p>";
                            }
                        }
                    }
                }
            }
            else
            {
                dvPrueba.InnerHtml = "<p style='background-color:red'>Debe ingresar rut, dígito verificador y razón social empresa</p>";
            }
        }

        private void LimpiarControles()
        {
            txtDireccion.Text = "";
            txtDV.Text = "";
            txtMail.Text = "";
            txtRazonSocial.Text = "";
            txtRut.Text = "";
            txtTelefono.Text = "";
            llenarRegion();
            llenarComuna();
            dvPrueba.InnerHtml = "";
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpiarControles();
        }
    }
}