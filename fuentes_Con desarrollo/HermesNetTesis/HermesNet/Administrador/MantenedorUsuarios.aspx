<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MantenedorUsuarios.aspx.cs" Inherits="HermesNet.Administrador.MantenedorUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style>
		fieldset { padding:0; border:0; margin-top:25px; }
		.ui-dialog .ui-state-error { padding: .3em; }
		.validateTips { border: 1px solid transparent; padding: 0.3em; }
    </style>


    <script type="text/javascript">
        $(function () {
            var rutEliminar = "";
            $("#dialog").dialog({
                autoOpen: false,
                show: {
                    effect: "blind",
                    duration: 1000
                },
                hide: {
                    effect: "explode",
                    duration: 1000
                }
            });
            //Se agrego recien
            $("#dialogOK").dialog({
                autoOpen: false,
                show: {
                    effect: "blind",
                    duration: 1000
                },
                hide: {
                    effect: "explode",
                    duration: 1000
                }
            });
            //Se agrego recien

            //Inicio Dialogo que consulta sobre eliminar 
            $("#dialog-confirm").dialog({
                autoOpen: false,
                resizable: false,
                height: 200,
                modal: true,
                show: {
                    effect: "blind",
                    duration: 1000
                },
                hide: {
                    effect: "explode",
                    duration: 1000
                },
                buttons: {
                    "Borra": function () {
                        EliminarUserAjax();
                        $(this).dialog("close");
                    },
                    "Editar": function () {
                        $(this).dialog("close");
                    }
                }
            });
            //Fin Dialogo que consulta sobre eliminar

            //            function editarBorra(rut) {
            //                rutEliminar = rut;
            //                $("#dialog-confirm").dialog("open");
            //            }


            function EliminarUserAjax() {
                $('#div_carga').show();
                rutEliminar = $("#RespuestaOculta").val();
                $.ajax({
                    type: "POST",
                    url: "MantenedorUsuarios.aspx/BorrarUsuario",
                    data: JSON.stringify({ rutUsuario: rutEliminar }),
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (data, status) {
                        $('#div_carga').hide();
                        if (data.d == "OK") {
                            location.reload();
                        } else {
                            $('#MensajeError').val() = data.d;
                            $('#MensajeError').show();
                        }
                    },
                    error: function (XHR, errStatus, errorThrown) {
                        $('#div_carga').hide();
                        var err = JSON.parse(XHR.responseText);
                        errorMessage = err.Message;
                    }
                });
            }

        });


    function ReenviarPass(rut) {
        $('#div_carga').show();
        $.ajax({
            type: "POST",
            url: "MantenedorUsuarios.aspx/ReenviarPass",
            data: JSON.stringify({ rutUsuario: rut }),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data, status) {
                if (data.d == "OK") {
                    $('#div_carga').hide();
                    $("#dialogOK").dialog("open"); //Se agregó recien
                } else {
                    $('#div_carga').hide();
                    alert("Funciona pero no setea");
                }
            },
            error: function (XHR, errStatus, errorThrown) {
                $('#div_carga').hide();
                var err = JSON.parse(XHR.responseText);
                errorMessage = err.Message;
            }
        });
    }

    /*Función que cambia formato a los botones */
    $(function () {
        $("input[type=submit], input[type=button],button")
			.button()
			.click(function (event) {
			    //FrmLogin.submit();
			});
     });

    //Inicio Permite mensaje
    function ErrorRut() {
        $("#dialog").dialog({
            autoOpen: false,
            show: {
                effect: "blind",
                duration: 1000
            },
            hide: {
                effect: "explode",
                duration: 1000
            }
        });

        $("#dialog").dialog("open");
    }
    //Fin Permite mensaje

    function ValidaSoloNumeros(numero) {
        if (!/^([0-9])*$/.test(numero)) {
            document.getElementById("ErrorDiv").innerHTML = "* Ingrese solamente numeros en la casilla rut";
            //document.getElementById("MainContent_txtRutUsuario").value = "";
            document.getElementById("ctl00$MainContent$btnBuscar").disable = true;
        } else {
            document.getElementById("ErrorDiv").innerHTML = "";
            document.getElementById("MainContent_btnBuscar").disable = false;
        }
    }

    function editarBorra(rut) {
        //rutEliminar = rut;
        $("#RespuestaOculta").val(rut);
        $("#dialog-confirm").dialog("open");
    }

</script>
    <script src="../Scripts/ScriptPaginas/FormNuevoUsuario.js" type="text/javascript"></script>
    <script src="../Scripts/ScriptPaginas/ValidarRut.js" type="text/javascript"></script>

    <style type="text/css">
        .style1
        {
            width: 160px;
        }
        .style2
        {
            width: 175px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<!--Abre el dialogo de error-->
<div id="dialog" title="Error">
	<p id="MensajeError" runat="server"></p>
</div>

<div id="dialogOK" title="Éxito en la Acción">
	<p id="P1" runat="server">Usuario Creado,<br />se envió mail con contraseña</p>
</div>

<!--Abre el dialogo de error-->
<!--Va el dialogo de error rojo en div-->
<div id="ErrorDiv" style=" color:Red"></div>
<!--Va el dialogo de error rojo en div-->


    <form id="frmMantenedorUsuario" runat="server">
    <table style="width: 100%;">
        <tr>
            <td>
                
            </td>
            <td class="style1">
                Ingrese Rut de Usuario:
            </td>
            <td class="style2">
                <asp:TextBox ID="txtRutUsuario" runat="server" Width="106px" onkeypress="ValidaSoloNumeros(this.value);" ></asp:TextBox>
            &nbsp;-
                <asp:TextBox ID="txtDv" runat="server" MaxLength="1" Width="23px"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" 
                    onclick="btnBuscar_Click" style="margin-left: 14px" />
            </td>
            <td>
            <!-- Formulario para ingresar usuario nuevo -->
            <div id="dialog-form" title="Crear Nuevo Usuario">
	            <p class="validateTips">Formulario de Ingreso de nuevos Usuarios</p>

	            <fieldset>

                <table>
                    <tr>
                        <td><label for="name">Rut</label></td>
                        <td><input type="text" name="rut" id="rut" class="text ui-widget-content ui-corner-all" style=" width:100px" /> - &nbsp; <input type="text" name="dv" id="dv" class="text ui-widget-content ui-corner-all" style=" width:15px" maxlength="1" /></td>
                    </tr>
                    <tr>
                        <td><label for="name">Nombre</label></td>
                        <td><input type="text" name="nombre" id="nombre" class="text ui-widget-content ui-corner-all" /></td>
                    </tr>
                    <tr>
                        <td><label for="name">Apellido Paterno</label></td>
                        <td><input type="text" name="apellidoP" id="apellidoP" class="text ui-widget-content ui-corner-all" /></td>
                    </tr>
                    <tr>
                        <td><label for="name">Apellido Materno</label></td>
                        <td><input type="text" name="apellidoM" id="apellidoM" class="text ui-widget-content ui-corner-all" /></td>
                    </tr>
                    <tr>
                        <td><label for="email">Email</label></td>
                        <td><input type="text" name="email" id="email" value="" class="text ui-widget-content ui-corner-all" /></td>
                    </tr>
                    <tr>
                        <td><label for="Lista">Cargo Usuario</label></td>
                        <td>
                            <div id="dvListaCargo" runat = "server"></div>
                        </td>
                    </tr>
                    <tr>
                        <td><label for="name">UserName</label></td>
                        <td><input type="text" name="name" id="name" class="text ui-widget-content ui-corner-all" /></td>
                    </tr>
                    <tr>
                        <td><label for="password">Password</label></td>
                        <td><input type="password" name="password" id="password" value="" class="text ui-widget-content ui-corner-all" /></td>
                    </tr>
                    <tr>
                        <td><label for="Lista">Rol de Usuario</label></td>
                        <td>
                            <div id="dvRol" runat="server"></div>
                        </td>
                    </tr>
                </table>
	            </fieldset>
	            </div>
                <!--Fin del formulario para crear usuario -->
                <button id="CrearUsuario" type="button">Crear Usuario</button>
            </td>
            <td>
            </td>
        </tr>
    </table>
    <div id="tablaUsuario" runat="server"></div>

    <!-- Dialogo de Borrar o Editar-->
    <div id="dialog-confirm" title="Eliminar o Editar">
        <p><span class="ui-icon ui-icon-alert" style="float:left; margin:0 7px 20px 0;"></span>Presione el Botón "Borra" para eliminar el usuario o <br /> "Editar" en caso contrario, para salir presione la "x"</p> 
    </div>
    <!-- Dialogo de Borrar o Editar-->

    <input type="hidden" id="RespuestaOculta" name="RespuestaOculta" />
    </form>
</asp:Content>
