<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JugadorReservaSeleccion.aspx.cs" Inherits="TP4_Dilacio.JugadorReservaSeleccion" %>


<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://www.jqueryscript.net/css/jquerysctipttop.css" rel="stylesheet" type="text/css">
    <link rel="stylesheet" href="css/calendar-style.css">
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.8.1/css/all.css" integrity="sha384-50oBUHEmvpQ+1lW4y57PTFmhCaXp0ML5d60M1M7uH2+nqUivzIebhndOJK28anvf" crossorigin="anonymous">

    <script src="https://code.jquery.com/jquery-3.4.1.min.js" integrity="sha384-vk5WoKIaW/vJyUAd9n/wmopsmNhiy+L2Z+SBxGYnUkunIxVxAv/UtMOhba/xskxh" crossorigin="anonymous"></script>
    <script src="js/calendar.js"></script>
    <link rel="stylesheet" href="css/formstyle.css" type="text/css" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
</head>
<body>
    <form id="Form1" runat="server">
        <nav class="navbar navbar-toggleable-md navbar-light bg-warning mt-0">
            <button class="navbar-toggler navbar-toggler-right" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <a class="navbar-brand">Match Point </a>
            <a class="navbar-brand" href="HomeView.aspx">Cerrar sesion </a>
            <div class="collapse navbar-collapse" id="navbarSupportedContent">
                <ul class="navbar-nav mr-auto">
                    <li class="nav-item active">
                        <a class="nav-link" href="HomeView.aspx">Home</a>
                    </li>
                </ul>
            </div>
        </nav>
        <div class="row">
            <div class="col-md-12" >
                <h5 style="margin-left: 500px">Podes elegir la cancha que queres jugar</h5>
                <asp:DropDownList runat="server" ID="ddCanchas" Width="950px" CssClass="adam-button" Style="background-color: firebrick;margin-top:0; margin-left: 220px" AutoPostBack="true" OnSelectedIndexChanged="ddCanchas_SelectedIndexChanged" ></asp:DropDownList>
                <hr />
            </div>
        </div>
        <div class="row">
            <div class="col-3">
                <h5>Seleccioná una fecha</h5>
                <div class="calendar">
                    <div class="calendar-footer">
                        <div class="next-prev">
                            <div class="btn prev-btn">prev</div>
                            <div class="btn next-btn">next</div>
                        </div>
                        <div class="options">
                            <div class="btn jump-today"><i class="far fa-dot-circle fa-sm"></i></div>
                            <div class="btn ok-btn" runat="server" id="btnOK" onclick="" style="background-color:blueviolet;color:aliceblue">Completar Fecha</div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-2">
                <h5>fecha seleccionada</h5>
                <asp:TextBox runat="server" ID="txbfecha" AutoPostBack="true" OnTextChanged="txbfecha_TextChanged" Width="200px"></asp:TextBox>
                <asp:Button CssClass="adam-button" runat="server" Text="Adelante" ID="btnAdelante" OnClick="btnAdelante_Click" />
            </div>
            <div class="col-5">
                <asp:GridView runat="server" ID="lbHorarios_Disponibles" CssClass="table" OnSelectedIndexChanged="lbHorarios_Disponibles_SelectedIndexChanged" AutoGenerateSelectButton="true">
                </asp:GridView>
            </div>
        </div>
        <div>
            <h5>© 2019 - Programación III</h5>
        </div>
    </form>

    <script>
        $('txbfecha').change(function () {
            '<%=Session["fecha_seleccionada"] = txbfecha.Text %>';
        });

        let c = $('.calendar');
        let calendar = new Calendar(c);
        let Fecha_Final = calendar.getSelectedDate().fullDate;
        console.log(calendar.getSelectedDate().day);
        console.log(c.find(0));
        c.find('.ok-btn').on('click', function () {
            //$.ajax({
            //    type: "POST",
            //    url: "/JugadorReservaSeleccion.aspx/GetAjax",
            //    data: '{date: "' + calendar.getSelectedDate().fullDate + '" }',
            //    contentType: "application/json; charset=utf-8",
            //    dataType: "json",
            //    success: function () {
            //        document.getElementById("txbfecha").value = calendar.getSelectedDate().fullDate;

            //    },
            //    error: function (err) {
            //        console.log(err);
            //    }
            //});
            document.getElementById("txbfecha").value = calendar.getSelectedDate().fullDate;


        });
    </script>
    <script type="text/javascript">

        var _gaq = _gaq || [];
        _gaq.push(['_setAccount', 'UA-36251023-1']);
        _gaq.push(['_setDomainName', 'jqueryscript.net']);
        _gaq.push(['_trackPageview']);

        (function () {
            var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true;
            ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';
            var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ga, s);
        })();

    </script>
</body>
</html>
