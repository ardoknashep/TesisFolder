<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrearEmpresaContratante.aspx.cs" Inherits="HermesNet.Comun.CrearEmpresaContratante" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
<script type="text/javascript">
    $(function () {
        $("input[type=submit], input[type=button]")
			.button()
			.click(function (event) {
			    //event.preventDefault();
			    FrmLogin.submit();
			});
    });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2 align="center">Crear Empresa Contratante</h2>
    <br />
    <form runat="server">
    <table border="1px" align="center">
        <tr>
            <td>Rut:</td>
            <td><asp:TextBox ID="txtRutEmpresa" runat="server"></asp:TextBox></td>
            <td>-<asp:TextBox ID="txtDVEmp" runat="server" Width="30px"></asp:TextBox> &nbsp;<asp:Button ID="btnValidar" runat="server" Text="Validar" /></td>
        </tr>
        <tr>
            <td>Razón Social</td>
            <td colspan="2"><asp:TextBox ID="txtRazonSocial" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Regi&oacute;n</td>
            <td colspan="2"><asp:DropDownList ID="ddlRegion" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td>Comuna</td>
            <td colspan="2"><asp:DropDownList ID="ddlComuna" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td>Direcci&oacute;n</td>
            <td colspan="2"><asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Telefono</td>
            <td colspan="2"><asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>E-mail</td>
            <td colspan="2"><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Ejecutivo Responsable</td>
            <td colspan="2"><asp:DropDownList ID="ddlEjecutivoResp" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td colspan="3">&nbsp;
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" /> &nbsp; 
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" /></td>
        </tr>
    </table>
    </form>
</asp:Content>
