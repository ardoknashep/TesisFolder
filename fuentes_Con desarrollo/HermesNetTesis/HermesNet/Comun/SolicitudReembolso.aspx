<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SolicitudReembolso.aspx.cs" Inherits="HermesNet.Comun.SolicitudReembolso" %>
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
    <h2 align="center">Solicitud Reembolso</h2>
<br />
<br />
<form runat="server">
<table border="1px" align="center">
    <tr>
        <td>Empresa Contratante</td>
        <td><asp:DropDownList ID="ddlEmpresaContratante" runat="server"></asp:DropDownList></td>
    </tr>
    <tr>
        <td>Empresa Filial</td>
        <td><asp:DropDownList ID="ddlEmpresaFilial" runat="server"></asp:DropDownList></td>
    </tr>
    <tr>
        <td>Polizas</td>
        <td><asp:DropDownList ID="ddlPoliza" runat="server"></asp:DropDownList></td>
    </tr>
    <tr>
        <td>Rut Asegurado</td>
        <td><asp:TextBox ID="txtRut" runat="server"></asp:TextBox> &nbsp; 
            <asp:Button ID="btnValidar" runat="server" Text="Validar" /></td>
    </tr>
    <tr>
        <td>Tipo Reembolso</td>
        <td><asp:DropDownList ID="ddlTipoReembolso" runat="server"></asp:DropDownList></td>
    </tr>
    <tr>
        <td colspan="2">
            <table>
                <tr>
                    <td>Documento 1</td>
                    <td><asp:CheckBox ID="CheckBox1" runat="server" /></td>
                </tr>
                <tr>
                    <td>Documento 2</td>
                    <td><asp:TextBox ID="txtDocumento" runat="server"></asp:TextBox></td>
                </tr>
            </table>
        </td>
    </tr>
    <tr align="center">
        <td colspan="2"><asp:Button ID="btnGrabar" runat="server" Text="Grabar" /> &nbsp;&nbsp;
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" /></td>
    </tr>
</table>
</form>
</asp:Content>
