<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrearPoliza.aspx.cs" Inherits="HermesNet.Comun.CrearPoliza" %>
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<form runat="server">
<h1 align="center">Crear Nueva P&oacute;liza</h1>
<br />
<table border="1px" align="center">
<tr>
    <td>Seleccione Empresa Contratante</td>
    <td><asp:DropDownList ID="ddlEsaContratante" runat="server">
        </asp:DropDownList> &nbsp;
    <asp:Button ID="btnFiliales" runat="server" Text="Buscar Filiales" /> </td>
</tr>
<tr>
    <td>Filiales Asociadas</td>
    <td><asp:DropDownList ID="ddlFiliales" runat="server">
        </asp:DropDownList> </td>
</tr>
<tr>
    <td>Utilizar&aacute; Empresa P&oacute;liza</td>
    <td>Si<asp:RadioButton ID="rbSiEsaP" runat="server" />
    No<asp:RadioButton ID="rbNoEsaP" runat="server" />
    </td>
</tr>
<tr>
    <td>Empresa P&oacute;liza</td>
    <td><asp:DropDownList ID="ddlEsaPoliza" runat="server" >
        </asp:DropDownList> </td>
</tr>
<tr>
    <td>Seleccione Aseguradora</td>
    <td><asp:DropDownList ID="ddlAseguradoras" runat="server">
        </asp:DropDownList> </td>
</tr>
<tr>
    <td>Ingrese N° P&oacute;liza</td>
    <td><asp:TextBox ID="txtNPoliza" runat="server"></asp:TextBox></td>
</tr>
<tr>
    <td>Tipo Seguro</td>
    <td><asp:DropDownList ID="ddlTipoSeguro" runat="server">
        </asp:DropDownList> </td>
</tr>
<tr>
    <td>Vigente</td>
    <td>Si<asp:RadioButton ID="rbSi" runat="server" />
    No<asp:RadioButton ID="rbNo" runat="server" /> </td>
</tr>
<tr>
    <td>Fecha Inicio Vigencia</td>
    <td><asp:TextBox ID="txtInicioVigencia" runat="server"></asp:TextBox> </td>
</tr>
<tr>
    <td>Fecha Fin Vigencia</td>
    <td><asp:TextBox ID="txtFinVigencia" runat="server"></asp:TextBox> </td>
</tr>
<tr>
    <td colspan="2">
        <br />
        &nbsp;
        <asp:Button ID="btnGuardar" runat="server" Text="Guardar P&oacute;liza" /> 
        &nbsp;
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
        <br />
        &nbsp;
    </td>
</tr>
</table>
</form>
</asp:Content>
