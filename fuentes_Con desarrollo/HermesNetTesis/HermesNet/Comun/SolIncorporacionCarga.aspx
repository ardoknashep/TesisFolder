<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SolIncorporacionCarga.aspx.cs" Inherits="HermesNet.Comun.SolIncorporacionCarga" %>
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
    <h1 align="center">Creaci&oacute;n Solicitud Incorporaci&oacute;n Carga</h1>
    <br />
    <table border="1px" align="center">
    <tr>
        <td>Empresas Contratantes</td>
        <td><asp:DropDownList ID="ddlEsaContratante" runat="server">
            </asp:DropDownList> 
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar Filiales" />
        </td>
    </tr>
    <tr>
        <td>Filiales</td>
        <td><asp:DropDownList ID="ddlFiliales" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>Rut Asegurado</td>
        <td><asp:TextBox ID="txtRut" runat="server"></asp:TextBox>
        &nbsp;-
        &nbsp;
            <asp:TextBox ID="txtDV" runat="server" Width="28px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>P&oacute;lizas Vigentes</td>
        <td><asp:DropDownList ID="ddlPolizas" runat="server">
            </asp:DropDownList> </td>
    </tr>
    <tr>
        <td>Rut Carga</td>
        <td><asp:TextBox ID="txtRutCarga" runat="server"></asp:TextBox>
            &nbsp;-
            &nbsp;
            <asp:TextBox ID="txtDVCarga" runat="server" Width="28px"></asp:TextBox>
            &nbsp;
            <asp:Button ID="btnValida" runat="server" Text="Validar" />
        </td>
    </tr>
    <tr>
        <td>Nombre Carga</td>
        <td><asp:TextBox ID="txtNombreCarga" runat="server"></asp:TextBox> </td>
    </tr>
    <tr>
        <td>Apellido Paterno</td>
        <td><asp:TextBox ID="txtApPaterno" runat="server"></asp:TextBox> </td>
    </tr>
    <tr>
        <td>Apellido Materno</td>
        <td><asp:TextBox ID="txtApMaterno" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td>Fecha de Nacimiento</td>
        <td><asp:TextBox ID="txtFecNac" runat="server"></asp:TextBox> </td>
    </tr>
    <tr>
        <td>G&eacute;nero</td>
        <td>
            Femenino<asp:RadioButton ID="rbFemenino" runat="server" /> 
            Masculino<asp:RadioButton ID="rbMasculino" runat="server" />
        </td>
    </tr>
    <tr>
        <td>Parentesco</td>
        <td><asp:DropDownList ID="ddlParentesco" runat="server">
            </asp:DropDownList></td>
    </tr>
    <tr>
        <td align="center" colspan="2"> 
            Documento 1<asp:CheckBox ID="CheckBox1" runat="server" /> 
            <br />
            Documento 2<asp:CheckBox ID="CheckBox2" runat="server" />
        </td>
    </tr>
    <tr>
        <td align="center" colspan="2"> 
            <br />
            &nbsp;
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" />
            &nbsp;
            <asp:Button ID="btnCancelat" runat="server" Text="Cancelar" />
            <br />
            &nbsp;
            </td>
    </tr>
    </table>
    </form>
</asp:Content>
