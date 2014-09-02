<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CargaMasiva.aspx.cs" Inherits="HermesNet.Administrador.CargaMasiva" %>
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
    <h2 align="center">Carga Masiva</h2>
<br />
<form runat="server">
    <table align="center">
    <tr>
        <td>Empresa Contratante:</td>
        <td><asp:DropDownList ID="ddlEmpresaContratante" runat="server"></asp:DropDownList></td>
    </tr>
    <tr>
        <td>Empresa Filial</td>
        <td><asp:DropDownList ID="ddlEmpresaFilial" runat="server"></asp:DropDownList></td>
    </tr>
    <tr>
        <td colspan="2"><asp:FileUpload ID="fuCargaMasiva" runat="server" /></td>
    </tr>
    <tr>
        <td><asp:Button ID="btnSubir" runat="server" Text="Subir" /></td>
        <td><asp:Button ID="btnCancelar" runat="server" Text="Cancelar" /></td>
    </tr>
    </table>
</form>
</asp:Content>
