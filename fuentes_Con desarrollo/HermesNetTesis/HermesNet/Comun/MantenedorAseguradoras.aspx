<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MantenedorAseguradoras.aspx.cs" Inherits="HermesNet.Comun.MantenedorAseguradoras" %>
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
    <style type="text/css">
        .style1
        {
            width: 24px;
        }
    </style>
    <script language="javascript" type="text/javascript" >
        function alertaNoCoincidencia()
        {
            window.alert("No se encontraron coincidencias!!!!");
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<form id="frmMAseguradoras" runat="server">
<div id="dvMensajeError" runat="server"></div>
<h1 align="center">Mantenedor de Aseguradora</h1>
<br />
    <table>
    <tr>
        <td>Rut Aseguradora</td>
        <td><asp:TextBox ID="txtRutAseguradora" runat="server"></asp:TextBox></td>
        <td>-</td>
        <td ><asp:TextBox ID="txtDvAseguradora" runat="server" Width="26px"></asp:TextBox></td>
        <td>Raz&oacute;n Social Aseguradora</td>
        <td><asp:TextBox ID="txtRazonSocialAseg" runat="server"></asp:TextBox></td>
        <td><asp:Button ID="btnBuscarAseguradora" runat="server" Text="Buscar" 
                onclick="btnBuscarAseguradora_Click" /></td>
        <td>
            <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" 
                onclick="btnLimpiar_Click" /></td>
    </tr>
    </table>
</form>
<br />
<%--<table border="1px" align="center">
    <tr>
        <th>Rut</th>
        <th>Razón Social</th>
        <th>Dirección</th>
        <th>Teléfono</th>
        <th>E-mail</th>
    </tr>
    <tr>
        <td>22.445.999-3</td>
        <td>Metlife Seguros de Vida</td>
        <td>Providencia 234</td>
        <td>02-2330270</td>
        <td>contacto@metlife.cl</td>
    </tr>
</table>
--%><div id="dvServidor" runat="server">
</div>
</asp:Content>
