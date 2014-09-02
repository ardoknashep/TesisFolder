<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AprobacionAsegurados.aspx.cs" Inherits="HermesNet.Administrador.AprobacionAsegurados" %>
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
<h2 align="center">Aprobaci&oacute;n Asegurado</h2>
<br />
<br />
<form runat="server">
<table align="center">
    <tr>
        <td><asp:FileUpload ID="fuApruebaAsegurado" runat="server" /><br /></td>
    </tr>
    <tr align="center">
        <td>
        <br />
            <asp:Button ID="btnAprobar" runat="server" Text="Aprobar" /> &nbsp;&nbsp;
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
        </td>
    </tr>
</table>
</form>
</asp:Content>
