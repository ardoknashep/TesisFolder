<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MantenedorPoliza.aspx.cs" Inherits="HermesNet.Comun.MantenedorPoliza" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script>
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
<form runat="server">
<h1 align="center">Mantenedor P&oacute;lizas</h1>
<br />
    <table>
    <tr>
        <td>Número de Póliza</td>
        <td><asp:TextBox ID="txtNPoliza" runat="server"></asp:TextBox> </td>
        <td>Empresa Contratante</td>
        <td><asp:DropDownList ID="ddlEsaContratante" runat="server">
            </asp:DropDownList> </td>
        <td><asp:Button ID="btnBuscar" runat="server" Text="Buscar" /></td>
        <td><asp:Button ID="btnCrearPoliza" runat="server" Text="Crear P&oacute;liza" 
                onclick="btnCrearPoliza_Click" /> </td>
    </tr>
    </table>
<br />
</form>
<table border="1px" align="center">
<tr>
    <th>N° P&oacute;liza</th>
    <th>Razón Social Empresa Contratante</th>
    <th>Rut Filial</th>
    <th>Razón Social Empresa Filial</th>
    <th>Empresa P&oacute;liza</th>
    <th>Fecha Inicio Vigencia</th>
    <th>Fecha Fin Vigencia</th>
</tr>
<tr>
    <td>340004777</td>
    <td>Codelco VP</td>
    <td>96.000.000-0</td>
    <td>Vicepresidencia de Proyectos</td>
    <td>CCAF Los Andes</td>
    <td>01-08-2013</td>
    <td>31-07-2014</td>
</tr>
</table>
</asp:Content>
