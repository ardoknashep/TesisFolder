<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MantenedorDocumentos.aspx.cs" Inherits="HermesNet.Comun.MantenedorDocumentos" %>
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
<h2 align="center">Mantenedor Documentos</h2>
<br />
<br />
<form runat="server">
    <table align="center">
        <tr>
            <td>Aseguradora</td>
            <td><asp:DropDownList ID="ddlAseguradora" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td>Tipo Solicitud</td>
            <td><asp:DropDownList ID="ddlTipoSolicitud" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td><asp:Button ID="btnBuscar" runat="server" Text="Buscar" /></td>
            <td><asp:Button ID="btnIngresarNuevo" runat="server" Text="Ingresar Nuevo" 
                    onclick="btnIngresarNuevo_Click" /></td>
        </tr>
    </table>
</form>
<br />
<br />
<table align="center" border="1px">
    <tr>
        <th>Documento</th>
        <th>Tiene Monto</th>
        <th>Tipo Solicitud</th>
    </tr>
    <tr>
        <td>Formulario de Contrato</td>
        <td>NO</td>
        <td>Ingreso de Afiliado</td>
    </tr>
</table>
</asp:Content>
