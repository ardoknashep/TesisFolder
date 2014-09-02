<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ValidarDocumentacion.aspx.cs" Inherits="HermesNet.Administrador.ValidarDocumentacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script>
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
    <h1 align="center">Validar Documentación y Cambio de Estado</h1>
    <br />
    <form runat="server">
    <table border="1px" align="center">
    <tr>
        <td>Descripci&oacute;n</td>
        <td>Fue recibido por ejecutivo</td>
        <td>Monto $</td>
        <td>Confirmar</td>
        <td>Validaci&oacute;n</td>
    </tr>
    <tr>
        <td>Boleta</td>
        <td>
            Si<asp:RadioButton ID="rbSi" runat="server" />
            No<asp:RadioButton ID="rbNo" runat="server" />
        </td>
        <td>41.000</td>
        <td>
            Si<asp:RadioButton ID="RadioButton1" runat="server" />
            No<asp:RadioButton ID="RadioButton2" runat="server" />
        </td>
        <td><asp:Button ID="btnValidar" runat="server" Text="Validar" /> </td>
    </tr>
    </table>
    </form>
</asp:Content>
