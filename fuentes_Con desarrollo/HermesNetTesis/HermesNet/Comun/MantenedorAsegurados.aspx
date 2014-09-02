<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MantenedorAsegurados.aspx.cs" Inherits="HermesNet.Comun.MantenedorAsegurados" %>
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
    <h2 align="center">Mantenedor de Asegurados</h2>
<br />
<form runat="server">
<table border="0px">
    <tr>
        <td>Rut:</td>
        <td><asp:TextBox ID="txtRut" runat="server"></asp:TextBox></td>
        <td><asp:Button ID="btnBuscar" runat="server" Text="Buscar" /></td>
        <%--<td>&nbsp;&nbsp;<asp:Button ID="btnCrear" runat="server" Text="Crear Asegurado" /></td>--%>
    </tr>
</table>
</form>
<br />
<br />
    <table border="1px" align="center">
        <tr>
            <th>Rut</th>
            <th>Nombre</th>
            <th>Apellido Paterno</th>
            <th>Apellido Materno</th>
            <th>N&uacute;mero P&oacute;liza</th>
            <th>Empresa Contratante</th>
            <th>Empresa Filial</th>
            <th></th>
        </tr>
        <tr>
            <td>16821045-0</td>
            <td>Reynaldo A.</td>
            <td>Araya</td>
            <td>Villalón</td>
            <td>05367</td>
            <td>Empresa contratante 1</td>
            <td>Empresa Filial 1</td>
            <td><input id="btnEliminar" type="button" value="Eliminar" /></td>
        </tr>
    </table>
</asp:Content>
