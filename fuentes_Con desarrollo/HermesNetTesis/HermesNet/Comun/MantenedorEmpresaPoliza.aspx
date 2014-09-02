<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MantenedorEmpresaPoliza.aspx.cs" Inherits="HermesNet.Comun.MantenedorEmpresaPoliza" %>
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
    <h2 align="center">Mantenedor Empresa Poliza</h2>
<br />
    <form runat="server">
    <table border="0px">
    <div id="dvMensaje" runat="server"></div>
        <tr>
            <td>Rut:</td>
            <td><asp:TextBox ID="txtRut" runat="server"></asp:TextBox></td>
            <td>-</td>
            <td><asp:TextBox ID="txtDV" runat="server" Width="26px"></asp:TextBox></td>
            <td>&nbsp;Raz&oacute;n Social</td>
            <td><asp:TextBox ID="txtRazonSocial" runat="server"></asp:TextBox></td>
            <td>&nbsp;<asp:Button ID="btnBuscar" runat="server" Text="Buscar" 
                    onclick="btnBuscar_Click" /></td>
            <td>&nbsp;<asp:Button ID="btnCrear" runat="server" Text="Crear Nueva" 
                    onclick="btnCrear_Click" /></td>
        </tr>
    </table>

    </form>
    
    <br />
    <div id="dvTabla" runat="server"></div>
    <br />
    <%--<table border="1px" align="center">
        <tr>
            <th>Rut</th>
            <th>Raz&oacute;n Social</th>
        </tr>
        <tr>
            <td>22.111.111-6</td>
            <td>Empresa Poliza 1</td>
        </tr>
        <tr>
            <td>33.555.111-6</td>
            <td>Empresa Poliza 2</td>
        </tr>
    </table>--%>
</asp:Content>
