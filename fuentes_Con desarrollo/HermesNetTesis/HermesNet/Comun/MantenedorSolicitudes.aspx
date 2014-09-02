<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MantenedorSolicitudes.aspx.cs" Inherits="HermesNet.Comun.MantenedorSolicitudes" %>
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
    <h1 align="center">Mantenedor de Solicitudes</h1>
    <br />
    <form runat="server">
    <table align="center">
    <tr>
        <td>Rut Asegurado</td>
        <td>
            <asp:TextBox ID="txtRut" runat="server"></asp:TextBox> 
            &nbsp;-
            &nbsp;
            <asp:TextBox ID="txtDV" runat="server" Width="28px"></asp:TextBox>
            &nbsp;
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
            </td>
    </tr>
    <tr>
        <td>P&oacute;lizas Vigentes</td>
        <td><asp:DropDownList ID="ddlPolizas" runat="server">
            </asp:DropDownList> </td>
    </tr>
    </table>
    <br />
    <br />
    <table border="1px" align="center">
    <tr>
        <td>Tipo Solicitud</td>
        <td>P&oacute;liza</td>
        <td>Fecha Ingreso Solicitud</td>
        <td>Estado Solicitud</td>
        <td>Revisar</td>
    </tr>
    <tr>
        <td>Reembolso</td>
        <td>340004777</td>
        <td>22-06-2014</td>
        <td>En Proceso</td>
        <td><asp:Button ID="btnRevisar" runat="server" Text="Revisar" 
                onclick="btnRevisar_Click" /> </td>
    </tr>
    <tr>
        <td>Reembolso</td>
        <td>340004778</td>
        <td>01-06-2014</td>
        <td>Revisado</td>
        <td><asp:Button ID="btnRev" runat="server" Text="Revisar" onclick="btnRev_Click" /> </td>
    </tr>
    </table>
    </form>
</asp:Content>
