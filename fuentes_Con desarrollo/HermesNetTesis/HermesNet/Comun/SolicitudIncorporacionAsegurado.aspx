<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SolicitudIncorporacionAsegurado.aspx.cs" Inherits="HermesNet.Comun.SolicitudIncorporacionAsegurado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
<script type="text/javascript">
    $(function () {
        $("input[type=submit], input[type=button]")
			.button()
			.click(function (event) {
			    //event.preventDefault();
			    //FrmLogin.submit();
			});
    });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h2 align="center">Incorporaci&oacute;n Asegurado</h2>
<br />
<br />
<form runat="server">
    <table border="1px" align="center" >
        <tr>
            <td>Empresa Contratante</td>
            <td><asp:DropDownList ID="ddlEmpresaContratante" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td>Empresa Filial</td>
            <td><asp:DropDownList ID="ddlEmpresaFilial" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td>Poliza</td>
            <td><asp:DropDownList ID="ddlPoliza" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td>Rut Asegurado:</td>
            <td><asp:TextBox ID="txtRutAsegurado" runat="server"></asp:TextBox>&nbsp;<asp:Button ID="btnValidar" runat="server" Text="Validar Rut" /></td>
        </tr>
        <tr>
            <td>Nombre</td>
            <td><asp:TextBox ID="txtNombre" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Apellido Paterno</td>
            <td><asp:TextBox ID="txtApellidoPaterno" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Apellido Materno</td>
            <td><asp:TextBox ID="txtApellidoMaterno" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Fecha Nacimiento</td>
            <td><asp:TextBox ID="txtFechaNacimiento" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Genero</td>
            <td><asp:DropDownList ID="txtSexo" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td>Tel&eacute;fono</td>
            <td><asp:TextBox ID="txtFono" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>E-mail</td>
            <td><asp:TextBox ID="txtMail" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Direcci&oacute;n</td>
            <td><asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Regi&oacute;n</td>
            <td><asp:DropDownList ID="ddlRegion" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td>Comuna</td>
            <td><asp:DropDownList ID="ddlComuna" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td>N&uacute;mero de Cuenta</td>
            <td><asp:TextBox ID="txtNumeroCuenta" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Tipo de Cuenta Bancaria</td>
            <td><asp:TextBox ID="txtTipoCtaBancaria" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Banco</td>
            <td><asp:DropDownList ID="ddlBanco" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td>Previsi&oacute;n</td>
            <td><asp:DropDownList ID="ddlPrevisionSocial" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td>Forma de Pago</td>
            <td><asp:DropDownList ID="ddlFormaPago" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td colspan="2">
                <table id="TablaDocumentos" align="center">
                    <tr>
                        <td>Documento 1</td>
                        <td><asp:CheckBox ID="chkDocto1" runat="server" /></td>
                    </tr>
                    <tr>
                        <td>Documento 2</td>
                        <td><asp:CheckBox ID="CheckBox1" runat="server" /></td>
                    </tr>
                    <tr>
                        <td>Documento 3</td>
                        <td><asp:CheckBox ID="CheckBox2" runat="server" /></td>
                    </tr>
                </table>

            </td>
        </tr>
        <tr>
            <td colspan="2"><asp:Button ID="btnIngresar" runat="server" Text="Ingresar Solicitud" />
                &nbsp;&nbsp;<asp:Button ID="btnCancelar" runat="server" Text="Cancelar" /></td>
        </tr>
    </table>
    </form>
</asp:Content>
