<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrearEmpresaFilial.aspx.cs" Inherits="HermesNet.Comun.CrearEmpresaFilial" %>
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
    <h2 align="center">Crear Filial</h2>
<br />
<form runat="server">
    <table border="1px" align="center">
        <tr>
            <td>Rut:</td>
            <td><asp:TextBox ID="txtRut" runat="server"></asp:TextBox></td>
            <td>-<asp:TextBox ID="txtDv" runat="server" Width="27px"></asp:TextBox> &nbsp;<asp:Button ID="btnValidar" runat="server" Text="Validar" /></td>
        </tr>
        <tr>
            <td>Raz&oacute;n Social:</td>
            <td colspan="2"><asp:TextBox ID="txtRazonSocial" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Dirección:</td>
            <td colspan="2"><asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox></td>
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
            <td>Telefono</td>
            <td><asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>E-mail</td>
            <td><asp:TextBox ID="txtMail" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="3">&nbsp;<asp:Button ID="btnGuardar" runat="server" Text="Guardar" />
            &nbsp; 
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" /></td>
        </tr>
    </table>
</form>
</asp:Content>
