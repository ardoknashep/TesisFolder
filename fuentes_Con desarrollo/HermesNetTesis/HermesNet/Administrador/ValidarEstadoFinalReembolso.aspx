<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ValidarEstadoFinalReembolso.aspx.cs" Inherits="HermesNet.Administrador.ValidarEstadoFinal" %>
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
<h1 align="center">Validar Estado Final Reembolso</h1>
    <br />
    <form runat="server">
    <table align="center">
    <tr>
        <td align="center"><asp:Button ID="btnAprobar" runat="server" Text="Aprobar" /></td> 
        <td align="center"><asp:Button ID="btnRechazar" runat="server" Text="Rechazar" /></td>
    </tr>
    
    <tr>
        <td>Comentarios
            <br />
        </td>
        <td>
            <br />
        <asp:TextBox ID="TextBox1" runat="server" Height="57px" TextMode="MultiLine" 
                Width="179px"></asp:TextBox> </td>
    </tr>
    </table>
    </form>
</asp:Content>
