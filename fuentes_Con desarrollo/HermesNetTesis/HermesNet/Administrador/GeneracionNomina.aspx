<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GeneracionNomina.aspx.cs" Inherits="HermesNet.Administrador.GeneracionNomina" %>
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
<h2 align="center">Generaci&oacute;n N&oacute;mina</h2>
<br />
<br />
<form runat="server">
<table border="1px" align="center">
    <tr>
        <td>Empresa Contratante</td>
        <td><asp:DropDownList ID="ddlEmpresaContratante" runat="server"></asp:DropDownList></td>
    </tr>
    <tr>
        <td>Estados Solicitud</td>
        <td><asp:DropDownList ID="ddlEstadoSolicitud" runat="server"></asp:DropDownList></td>
    </tr>
    <tr align="center">
        <td colspan="2"><asp:Button ID="btnGenerar" runat="server" Text="Generar" />&nbsp;&nbsp;
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" /></td>
    </tr>
</table>
</form>
</asp:Content>
