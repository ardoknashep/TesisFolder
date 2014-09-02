using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using HermesNet.Negocio;
using HermesNet.Model;
using HermesNet.WebServiceHermesNet;

namespace HermesNet.Administrador
{
    public partial class MantenedorUsuarios : System.Web.UI.Page
    {

        #region Sesiones

        public List<CargoVO> ListaCargos
        {
            get
            {
                if (Session["ListaCargo"] == null)
                {
                    Session["ListaCargo"] = new List<CargoVO>();
                }
                return (List<CargoVO>)(Session["ListaCargo"]);
            }
            set
            {
                Session["ListaCargo"] = value;
            }
        }

        public List<RolVO> ListaRol
        {
            get
            {
                if (Session["ListaRol"] == null)
                {
                    Session["ListaRol"] = new List<RolVO>();
                }
                return (List<RolVO>)(Session["ListaRol"]);
            }
            set
            {
                Session["ListaRol"] = value;
            }
        }

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
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarTodosUsers(User.Identity.Name);
                EscribirCargo();
                EscribirRol();
            }
        }

        /// <summary>
        /// Escribe en la web todos los roles en la base de datos
        /// </summary>
        private void EscribirRol()
        {
            if (ListaRol.Count == 0)
            {
                RolNegocio rneg = new RolNegocio();
                ListaRol = rneg.ObtenerTodosLosRoles();
            }

            dvRol.InnerHtml = "";
            dvRol.InnerHtml = @"<select id = 'rol' name='rol' class='select ui-widget-content ui-corner-all'>";
            foreach (RolVO rvo in ListaRol)
            {
                dvRol.InnerHtml += @"<option value='"+ rvo.IdRol +"'>"+ rvo.Descripcion +"</option>";
            }
            dvRol.InnerHtml += @"</select>";
        }

        /// <summary>
        /// Escribe en la web todos los cargos en la base de datos
        /// </summary>
        private void EscribirCargo()
        {
            if (ListaCargos.Count == 0)
            {
                CargoNegocio cneg = new CargoNegocio();
                ListaCargos = cneg.ObtenerTodosLosCargos();
            }
            dvListaCargo.InnerHtml = "";
            dvListaCargo.InnerHtml = @"<select id = 'cargo' name='cargo' class='select ui-widget-content ui-corner-all'>";
            foreach (CargoVO cvo in ListaCargos)
            {
                dvListaCargo.InnerHtml += @"<option value='"+ cvo.Id_cargo +"'>"+ cvo.Descripcion +"</option>";    
            }
            dvListaCargo.InnerHtml += @"</select>";
        }

        private void CargarTodosUsers(string p)
        {
            UsuarioNegocio uneg = new UsuarioNegocio();
            List<UsuarioVO> luvo = uneg.ObtenerTodosLosUsuarios(p);
            //string rutUser = txtRutUsuario.Text;
            tablaUsuario.InnerHtml = "<br/><br/>";
            tablaUsuario.InnerHtml += "<table align='center' border='1px'>";
            tablaUsuario.InnerHtml += "<tr>";
            tablaUsuario.InnerHtml += "<th>Rut</th>";
            tablaUsuario.InnerHtml += "<th>Nombre</th>";
            tablaUsuario.InnerHtml += "<th>Apellido Paterno</th>";
            tablaUsuario.InnerHtml += "<th>Apellido Materno</th>";
            tablaUsuario.InnerHtml += "<th>Mail</th>";
            tablaUsuario.InnerHtml += "<th>Cargo</th>";
            tablaUsuario.InnerHtml += "<th>Perfil</th>";
            tablaUsuario.InnerHtml += "<th>Contrase&ntilde;a</th>";
            tablaUsuario.InnerHtml += "<th>Editar - Borrar</th>";
            tablaUsuario.InnerHtml += "</tr>";
            foreach (UsuarioVO uvo in luvo)
            {
                
                tablaUsuario.InnerHtml += "<tr>";
                tablaUsuario.InnerHtml += "<td>" + string.Format("{0}-{1}", uvo.Rut, uvo.Dv) + "</td>";
                tablaUsuario.InnerHtml += "<td>" + uvo.Nombre + "</td>";
                tablaUsuario.InnerHtml += "<td>" + uvo.Apellido_p + "</td>";
                tablaUsuario.InnerHtml += "<td>" + uvo.Apellido_m + "</td>";
                tablaUsuario.InnerHtml += "<td>" + uvo.Email + "</td>";
                tablaUsuario.InnerHtml += "<td>" + uvo.Cargo.Descripcion + "</td>";
                tablaUsuario.InnerHtml += "<td>" + uvo.Rol.Descripcion + "</td>";
                tablaUsuario.InnerHtml += "<td><input id='btnReenvioPass' type='button' value='Reenviar' onClick='ReenviarPass(" + uvo.Rut + ")' /></td>";
                tablaUsuario.InnerHtml += "<td><input id='btnEditar' type='button' value='Editar - Borrar' onClick='editarBorra(" +uvo.Rut + ");' /></td>";
                tablaUsuario.InnerHtml += "</tr>";
                 
            }
            tablaUsuario.InnerHtml += "</table>"; 
        }

        /// <summary>
        /// Acción del botón buscar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int numero;

            if (!int.TryParse(txtRutUsuario.Text, out numero))
            {
                MensajeError.InnerHtml = "Se ingresaron valores no aceptados en el campo rut";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert", "ErrorRut()", true);
            }
            else
            {

                if (txtDv.Text != "0" && txtDv.Text != "1" && txtDv.Text != "2" && txtDv.Text != "3" &&
                    txtDv.Text != "4" && txtDv.Text != "5" && txtDv.Text != "6" && txtDv.Text != "7" &&
                    txtDv.Text != "8" && txtDv.Text != "9" && txtDv.Text != "K" && txtDv.Text != "k")
                {
                    MensajeError.InnerHtml = "El digito verificador ingresado no es correcto";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert", "ErrorRut()", true);
                }
                else
                {

                    string rut = txtRutUsuario.Text + txtDv.Text;
                    UtilitarioNegocio uneg = new UtilitarioNegocio();

                    if (uneg.ValidarRut(rut))
                    {
                        UsuarioNegocio UsNeg = new UsuarioNegocio();
                        string username = User.Identity.Name;
                        UsuarioVO uvo = UsNeg.ObtenerUsuarioByRut(username, numero);
                        CrearTablaFiltro(uvo);
                    }
                    else
                    {
                        MensajeError.InnerHtml = "Rut No Valido";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert", "ErrorRut()", true);
                    }
                    
                }
            }
        }

        /// <summary>
        /// Metodo que permite conectar por medio de ajax al servidor para guardar el rut del usuario en sesión antes de hacer el 
        /// paso al formulario de edición, además le indica a la página que lo que se va a hacer es editar un usuario por medio de 
        /// la variable de sesion _accionMUser
        /// </summary>
        /// <param name="rutUsuario"></param>
        /// <returns></returns>
        [WebMethod]
        public static string ReenviarPass(long rutUsuario)
        {
            try
            {
                //HttpContext.Current.Session["_rutUsuario"] = rutUsuario;
                //HttpContext.Current.Session["_accionMUser"] = "Editar";
                //return "OK";
                WSHermesNetSoapClient clWS = new WSHermesNetSoapClient();
                WSHeader wsHead = new WSHeader();
                AutenticacionLoginNegocio alneg = new AutenticacionLoginNegocio();
                wsHead.Credenciales = alneg.GenerarFirmaEncriptadaReenvioPass(rutUsuario);
                bool respuesta = clWS.ActualizarPasswd(wsHead, rutUsuario);
                if (respuesta)
                {
                    return "OK";
                }
                else
                {
                    return "NoOK";
                }
                
            }
            catch (Exception)
            {
                return "NoOk";
            }
        }

        /// <summary>
        /// Crea la tabla del mantenedor
        /// </summary>
        public void CrearTablaFiltro(UsuarioVO uvo)
        {
            if (uvo.Nombre == string.Empty)
            {
                tablaUsuario.InnerHtml = "";
                tablaUsuario.InnerHtml = "<br/><br/><p align='center' style='color:red; font-size: 14px;'><b>* Usuario no encontrado</b></p><br/><br/>";
            }
            else
            {
                string rutUser = txtRutUsuario.Text;
                tablaUsuario.InnerHtml = "<br/><br/>";
                tablaUsuario.InnerHtml += "<table align='center' border='1px'>";
                tablaUsuario.InnerHtml += "<tr>";
                tablaUsuario.InnerHtml += "<th>Rut</th>";
                tablaUsuario.InnerHtml += "<th>Nombre</th>";
                tablaUsuario.InnerHtml += "<th>Apellido Paterno</th>";
                tablaUsuario.InnerHtml += "<th>Apellido Materno</th>";
                tablaUsuario.InnerHtml += "<th>Mail</th>";
                tablaUsuario.InnerHtml += "<th>Cargo</th>";
                tablaUsuario.InnerHtml += "<th>Perfil</th>";
                //tablaUsuario.InnerHtml += "<th>Editar</th>";
                tablaUsuario.InnerHtml += "<th>Reenviar Contrase&ntilde;a</th>";
                tablaUsuario.InnerHtml += "<th>Editar - Borrar</th>";


                tablaUsuario.InnerHtml += "</tr>";
                tablaUsuario.InnerHtml += "<tr>";
                tablaUsuario.InnerHtml += "<td>" + string.Format("{0}-{1}", uvo.Rut, uvo.Dv) + "</td>";
                tablaUsuario.InnerHtml += "<td>" + uvo.Nombre + "</td>";
                tablaUsuario.InnerHtml += "<td>" + uvo.Apellido_p + "</td>";
                tablaUsuario.InnerHtml += "<td>" + uvo.Apellido_m + "</td>";
                tablaUsuario.InnerHtml += "<td>" + uvo.Email + "</td>";
                tablaUsuario.InnerHtml += "<td>" + uvo.Cargo.Descripcion + "</td>";
                tablaUsuario.InnerHtml += "<td>" + uvo.Rol.Descripcion + "</td>";
                //tablaUsuario.InnerHtml += "<td><input id='btnEditar' type='button' value='editar' onClick='editar("+ rutUser +")' /></td>";
                tablaUsuario.InnerHtml += "<td><input id='btnReenvioPass' type='button' value='Reenviar' onClick='ReenviarPass(" + uvo.Rut + ")' /></td>";
                tablaUsuario.InnerHtml += "<td><input id='btnEditar' type='button' value='Editar - Borrar' onClick='editarBorra(" + uvo.Rut + ");' /></td>";
                tablaUsuario.InnerHtml += "</tr>";
                tablaUsuario.InnerHtml += "</table>";
            }
        }


        /// <summary>
        /// Ingresa un nuevo usuario contactandose al web service 
        /// </summary>
        /// <param name="rutUsuario"></param>
        /// <param name="dv"></param>
        /// <param name="nombre"></param>
        /// <param name="apellidoP"></param>
        /// <param name="apellidoM"></param>
        /// <param name="mail"></param>
        /// <param name="cargo"></param>
        /// <param name="username"></param>
        /// <param name="passwd"></param>
        /// <param name="rol"></param>
        /// <returns></returns>
        [WebMethod]
        public static string IngresarUsuario(int rutUsuario, string dv, string nombre, string apellidoP, string apellidoM, string mail,
            int cargo, string username, string passwd, int rol)
        {
            string respuesta = string.Empty;
            UtilitarioNegocio utneg = new UtilitarioNegocio();
            string rut = string.Format("{0}-{1}",rutUsuario,dv);

            if (!utneg.ValidarRut(rut))
            {
                respuesta = "Rut no valido";
            }
            else
            {
                try
                {
                    WSHeader strHead = new WSHeader();
                    AutenticacionLoginNegocio alN = new AutenticacionLoginNegocio();
                    strHead.Credenciales = alN.GenerarFirmaEncriptada(username, passwd);
                    WSHermesNetSoapClient wscl = new WSHermesNetSoapClient();
                    RespuestaIngresoUsuarioVO rivo = wscl.IngresarLogin(strHead, rutUsuario, Convert.ToChar(dv), nombre, apellidoP, apellidoM, mail, cargo, username, passwd, rol);
                    if (rivo.Estado == 1)
                    {
                        respuesta = "OK";
                    }
                    else
                    {
                        respuesta = String.Format("Error : {0}", rivo.Mensaje);
                    }
                }
                catch (Exception ex)
                {
                    respuesta = ex.Message;
                    //throw;
                }
            }
            return respuesta;
        }

        [WebMethod]
        public static string BorrarUsuario(long rutUsuario)
        {
            string respuesta = string.Empty;
            try
            {
                AutenticacionLoginNegocio alog = new AutenticacionLoginNegocio();
                WSHeader wsh = new WSHeader();
                wsh.Credenciales = alog.GenerarFirmaEncriptada(HttpContext.Current.User.Identity.Name, rutUsuario.ToString());
                WSHermesNetSoapClient cliWs = new WSHermesNetSoapClient();
                RespuestaGenericaWSVO rgws = cliWs.EliminarUsuario(wsh, HttpContext.Current.User.Identity.Name, rutUsuario);
                if (rgws.Estado == 1)
                {
                    rgws.Mensaje = "OK";
                }
                return rgws.Mensaje;
            }
            catch (Exception ex)
            {
                return ex.Message;
                //throw;
            }
        }
    }
}