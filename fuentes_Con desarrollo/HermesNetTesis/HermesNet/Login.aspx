<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HermesNet.Login" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Bienvenido a Hermes</title>
    <link href="Styles/themes/start/jquery.ui.all.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/jqueryUI/jquery-1.10.2.js" type="text/javascript"></script>
    <script src="Scripts/jqueryUI/ui/jquery.ui.core.js" type="text/javascript"></script>
    <script src="Scripts/jqueryUI/ui/jquery.ui.widget.js" type="text/javascript"></script>
    <script src="Scripts/jqueryUI/ui/jquery.ui.button.js" type="text/javascript"></script>
    <style type="text/css">
        @import url('http://fonts.googleapis.com/css?family=Black+Ops+One');
        table{
            -moz-border-radius: 15px;
            background-color : #AFAAC6;
            border : 1px solid #000000;
            border-radius: 15px;
            font-family : Arial, Verdana, Helvetica, sans-serif;
            font-size : 12px;
            padding-left : 5px;
            padding-right : 5px;
            margin : 3px;
            }
            
       .title
        {
            padding: 0px;
            margin: 0px;
            font-size: 20px;
            text-align: center;
            font-family: 'Black Ops One';
            color: #0B2161;
        }
    </style>
    <script>
        function Alinear()
        {
            var alto = screen.height;
            var centro = 0;
            centro = alto / 4;
            alto = alto - centro;
            document.getElementById("Ltab").style.height = alto + "px";
        }
        $(function () {
            $("input[type=submit]")
			.button()
			.click(function (event) {
			    //event.preventDefault();
			    FrmLogin.submit();
			});
        });
    </script>
</head>
<body onload="Alinear()">
<center>
<br />
    <img src="images/benefits1.png" width="180px" height="120px" />
<br />
</center>
    <form id="FrmLogin" method="post">
    <div class="title">
                    <h1>
                        HermesNet
                    </h1>
    </div>
    <div id="Ltab">
       <table id="LoginTable" align="center" style=" position:absolute; left:40%; top:40%">
       <tr>
            <td>Usuario</td>
            <td>
                <input id="txtUsr" name="txtUsr" type="text" />
            </td>
       </tr>
       <tr>
            <td>Contrase&ntilde;a</td>
            <td>
                <input id="txtPasswd" name="txtPasswd" type="password" />
            </td>
       </tr>
       <tr>
            <td colspan="2">
            <br />
                <input id="btnIngresar" type="submit" value="Ingresar" />
            </td>
       </tr>
       </table> 
    </div>
    </form>
</body>
</html>
