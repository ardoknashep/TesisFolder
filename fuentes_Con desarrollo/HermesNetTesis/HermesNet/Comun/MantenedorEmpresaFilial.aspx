<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MantenedorEmpresaFilial.aspx.cs" Inherits="HermesNet.Comun.MantenedorEmpresaFilial" %>
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
    <h2 align="center">Mantenedor de Filiales</h2>
<br />
<form runat="server">
&nbsp;<asp:Button ID="btnCrearFilial" runat="server" Text="Crear Filial" 
    onclick="btnCrearFilial_Click" />
</form>

<br />
    <table border="1px" align="center">
    <tr>
        <th>Rut Filial</th>
        <th>Raz&oacute;n Social</th>
        <th>Direcci&oacute;n</th>
        <th></th>
    </tr>
        <tr>
            <td>11.222.222-0</td>
            <td>Filial de Empresa 1</td>
            <td>Avda 1 numero 123</td>
            <td>
                <input id="btnEliminarFilial" type="button" value="Eliminar" /></td>
        </tr>
    </table>
</asp:Content>
