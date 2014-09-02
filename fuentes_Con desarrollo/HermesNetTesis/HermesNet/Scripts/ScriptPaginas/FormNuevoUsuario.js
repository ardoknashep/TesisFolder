$(function () {
    var respuesta = "",
        rut = $("#rut"),
        dv = $("#dv"),
        nombre = $("#nombre"),
        apellidoP = $("#apellidoP"),
        apellidoM = $("#apellidoM"),
        email = $("#email"),
        cargo = $("#cargo"),
        name = $("#name"),
		password = $("#password"),
        rol = $("#rol"), //De aquí hacia arriba recupera los valores de los controles
		allFields = $([]).add(rut).add(dv).add(nombre).add(apellidoP).add(apellidoM).add(email).add(cargo).add(name).add(password).add(rol).add(respuesta), //Aqui deben ir todos los controles que se recuperan en la parte de arriba
		tips = $(".validateTips");

    function updateTips(t) {
        tips
				.text(t)
				.addClass("ui-state-highlight");
        setTimeout(function () {
            tips.removeClass("ui-state-highlight", 1500);
        }, 500);
    }

    //Sirve para validar largo de datos
    //o lleva el valor del control, n lleva el identificador que se le da al control, min es la cantidad minima de caracteres, max es la cantidad maxima de caracteres  
    function checkLength(o, n, min, max) {
        if (o.val().length > max || o.val().length < min) {
            o.addClass("ui-state-error");
            updateTips("Largo de " + n + " debe ser entre " +
					min + " y " + max + ".");
            return false;
        } else {
            return true;
        }
    }

    //Valida caracteres validos dentro de un control
    //o lleva el valor del control, regexp lleva la validación de caracteres aceptables, n lleva el mensaje que se mostrará en caso de error 
    function checkRegexp(o, regexp, n) {
        if (!(regexp.test(o.val()))) {
            o.addClass("ui-state-error");
            updateTips(n);
            return false;
        } else {
            return true;
        }
    }


    function IngresarUsuario(rutUsuario, dv, nombre, apellidoP, apellidoM, mail, cargo, username, passwd, rol) {
        $.ajax({
            type: "POST",
            url: "MantenedorUsuarios.aspx/IngresarUsuario",
            async: false,
            data: JSON.stringify({ rutUsuario: rutUsuario,
                dv: dv,
                nombre: nombre,
                apellidoP: apellidoP,
                apellidoM: apellidoM,
                mail: mail,
                cargo: cargo,
                username: username,
                passwd: passwd,
                rol: rol
            }),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data, status) {
                respuesta = data.d;
                if (respuesta == 'OK') {
                    respuesta = true;
                } else {
                    updateTips(respuesta);
                    respuesta = false;
                }
            },
            failure: function (data, status) {
                //alert(data.d);
                return false;
            },
            error: function (XHR, errStatus, errorThrown) {
                var err = JSON.parse(XHR.responseText);
                errorMessage = err.Message;
                //alert(errorMessage);
                return false;
            }
        });
    }




    $("#dialog-form").dialog({
        autoOpen: false,
        height: 350,
        width: 350,
        modal: true,
        buttons: {
            "Crear Nuevo": function () {
                var bValid = true;
                var rutCompleto = "";
                rutCompleto = rut.val().replace(".", "") + "-" + dv.val();
                allFields.removeClass("ui-state-error");

                //Inicio Determinando largos de los caracteres
                bValid = bValid && checkLength(rut, "rut", 3, 20);
                bValid = bValid && checkLength(dv, "dv", 1, 1);
                bValid = bValid && checkLength(nombre, "nombre", 3, 100);
                bValid = bValid && checkLength(apellidoP, "Apellido Paterno", 3, 100);
                bValid = bValid && checkLength(apellidoM, "Apellido Materno", 3, 100);
                bValid = bValid && checkLength(email, "email", 6, 80);
                bValid = bValid && checkLength(name, "Username", 5, 15);
                bValid = bValid && checkLength(password, "password", 5, 16);

                if (!(VerificaRut(rutCompleto))) {
                    rut.addClass("ui-state-error");
                    updateTips("Rut no valido");
                    bValid = bValid && false;
                } else {
                    //updateTips("Rut no valido");
                    tips.removeClass("ui-state-highlight", 1500);
                    bValid = bValid && true;
                }

                //Inicio Determinando largos de los caracteres

                bValid = bValid && checkRegexp(name, /^[a-z]([0-9a-z_])+$/i, "Username debe contener carácteres a-z, 0-9, debe comenzar con una letra.");
                bValid = bValid && checkRegexp(email, /^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?$/i, "eg. ui@jquery.com");
                bValid = bValid && checkRegexp(password, /^([0-9a-zA-Z])+$/, "Password erronea, Ingrese carácteres : a-z 0-9");

                bValid = bValid && checkRegexp(rol, /^([0-9])+$/, "Seleccione un Rol");
                bValid = bValid && checkRegexp(cargo, /^([0-9])+$/, "Seleccione un cargo");


                if (bValid) {
                    IngresarUsuario(rut.val(), dv.val(), nombre.val(), apellidoP.val(), apellidoM.val(), email.val(), cargo.val(), name.val(), password.val(), rol.val());
                    if (respuesta) {
                        $(this).dialog("close");
                        location.reload();
                    }
                }
            },
            "Cancelar": function () {
                //estadoR = "";
                $(this).dialog("close");
            }
        },
        close: function () {
            //estadoR = "";
            allFields.val("").removeClass("ui-state-error");
        }
    });


    $("#CrearUsuario")
			.button()
			.click(function () {
			    updateTips("Formulario de Ingreso Usuario");
			    $("#dialog-form").dialog("open");
			});
});
