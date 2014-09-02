<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrearEmpresaPoliza.aspx.cs" Inherits="HermesNet.Comun.CrearEmpresaPoliza" %>
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
<h2 align="center">Ingreso Empresa Poliza</h2>
<br />
<form runat="server">
<div id="dvPrueba" runat="server"></div>
<table border="1" align="center">
    <tr>
        <td>Rut:</td>
        <td><asp:TextBox ID="txtRut" runat="server"></asp:TextBox></td>
        <td>-<asp:TextBox ID="txtDV" runat="server" Width="29px"></asp:TextBox>
        &nbsp;<asp:Button ID="btnValidar" runat="server" Text="Validar" 
                onclick="btnValidar_Click" /></td>
    </tr>
    <tr>
        <td>Raz&oacute;n Social</td>
        <td colspan="2"><asp:TextBox ID="txtRazonSocial" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td>Direcci&oacute;n</td>
        <td colspan="2"><asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td>Regi&oacute;n</td>
        <td colspan="2"><asp:DropDownList ID="ddlRegion" runat="server" AutoPostBack="true" 
                onselectedindexchanged="ddlRegion_SelectedIndexChanged" DataTextField="Descripcion" DataValueField="Id_region" ></asp:DropDownList></td>
    </tr>
    <tr>
        <td>Comuna</td>
        <td><asp:DropDownList ID="ddlComuna" runat="server" ></asp:DropDownList></td>
    </tr>
    <tr>
        <td>Telefono</td>
        <td><asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td>E-mail</td>
        <td><asp:TextBox ID="txtMail" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" 
                onclick="btnIngresar_Click" /> &nbsp;&nbsp; 
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" 
                onclick="btnCancelar_Click" /></td>
    </tr>
</table>
</form>
</asp:Content>
