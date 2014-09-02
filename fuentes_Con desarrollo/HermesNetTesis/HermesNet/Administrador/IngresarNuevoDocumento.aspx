<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IngresarNuevoDocumento.aspx.cs" Inherits="HermesNet.Administrador.IngresarNuevoDocumento" %>
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
<h2 align="center">Ingresar Nuevo Documento</h2>
<br />
<br />
<form runat="server">
    <table border="1px" align="center">
        <tr>
            <td>Aseguradora</td>
            <td><asp:DropDownList ID="ddlAseguradora" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td>Tipo Solicitud</td>
            <td><asp:DropDownList ID="ddlTipoSolicitud" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td>Nombre Documento</td>
            <td><asp:TextBox ID="txtNombreDocumento" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Tipo Documento</td>
            <td><asp:DropDownList ID="ddlTipoDocumento" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td><asp:Button ID="btnGuardar" runat="server" Text="Guardar" /></td>
            <td><asp:Button ID="btnCancelar" runat="server" Text="Cancelar" /></td>
        </tr>
    </table>
</form>
</asp:Content>
