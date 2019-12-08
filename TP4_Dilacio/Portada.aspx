<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Portada.aspx.cs" Inherits="TP4_Dilacio.HomeView" %>

<html>
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" href="https://unpkg.com/bootstrap-material-design@4.1.1/dist/css/bootstrap-material-design.min.css" integrity="sha384-wXznGJNEXNG1NFsbm0ugrLFMQPWswR3lds2VeinahP8N0zJw9VWSopbjv2x7WCvX" crossorigin="anonymous">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <link rel="shortcut icon" href="https://mdbootstrap.com/wp-content/themes/mdbootstrap4/favicon.ico">
    <link rel="stylesheet" href="Styles.css">
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>

    <link rel="stylesheet" href="css/Home.css" type="text/css" />

</head>
<body>
    <hr />
    <hr />
    <form runat="server">
        <div class="img-fluid" style="background-image: url(https://i.pinimg.com/originals/d3/83/95/d38395508b4f2eb38cfd2005a6d2b84d.jpg); background-size: cover; position: absolute; top: 0; right: 0; bottom: 0; left: 0;">
            <nav class="navbar navbar-expand-lg navbar-dark ">
                <div class="container">
                    <a class="navbar-brand" style="color:aliceblue">Match Point</a>
                    <div class="collapse navbar-collapse" id="probootstrap-nav">
                        <ul class="navbar-nav ml-auto">
                            <li class="nav-item probootstrap-cta probootstrap-seperator"><a href="HomeView.aspx" class="nav-link">Iniciar sesión</a></li>
                            <li class="nav-item probootstrap-cta"><a href="CrearCuenta.aspx" class="nav-link">Registrarse</a></li>
                        </ul>
                    </div>
                </div>
            </nav>
            <hr />
            <div class="container">
                <div class="row">
                    <div class="col-6">
                        <div class="card">
                            <div class="card-header">
                                <label style="color: aliceblue; font-size: 20px">Jugador</label>
                            </div>
                            <div class="card-body" style="color: aliceblue; font-size: 15px">
                                <div class="row">
                                    <img class="card-img-top align-content-center" src="https://www.freeiconspng.com/uploads/football-png-25.png" alt="image" style="width: 173px; margin-left: 90px">
                                </div>
                                <hr style="background-color: dimgray" />
                                <div class="row">
                                    <label style="margin-left: 20px; margin-top: 20px">Busca tu centro mas cercano</label>
                                    <label style="margin-left: 20px; margin-top: 20px">Selecciona la fecha que queres jugar</label>
                                    <label style="margin-left: 20px; margin-top: 20px">Reservá y Disfruta de la mejor experiencia</label>
                                </div>
                            </div>
                            <div class="card-footer">
                            </div>
                        </div>
                    </div>
                    <div class="col-6">
                        <div class="card">
                            <div class="card-header">
                                <label style="color: aliceblue; font-size: 20px">Comerciante</label>
                            </div>
                            <div class="card-body" style="color: aliceblue; font-size: 15px">
                                <div class="row">
                                    <img class="card-img-top align-content-center" src="https://media.giphy.com/media/7zfZspyvCgs4F4kiej/giphy.gif" alt="image" style="width: 150px; margin-left: 90px">
                                </div>
                                <hr style="background-color: dimgray" />
                                <div class="row">
                                    <label style="margin-left: 20px; margin-top: 20px">Incrementa tus ventas con nuestro servicio</label>
                                    <label style="margin-left: 20px; margin-top: 20px">Dejanos que te ayudemos con la gestion de tus reservas</label>
                                </div>
                            </div>
                            <div class="card-footer">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <section class="bg-light" id="JugadorInfo">
                <div class="container">
                    <div class="row">
                        <div class="col-lg-6 order-2 order-lg-1">
                            <h1>Si sos jugador</h1>
                            <hr />
                            <br />
                            <br />
                            <h4>Te brindamos la posibilidad de encontrar donde hacer el deporte que mas te gusta de la forma mas agil y rapida!</h4>

                        </div>
                        <div class="col-lg-6 order-1 order-lg-2">
                            <img src="https://cdn.pixabay.com/photo/2013/07/13/01/19/tennis-court-155517_960_720.png" alt="..." class="img-fluid">
                        </div>
                    </div>
                </div>
            </section>
            <section class="bg-inverse" id="VendedorInfo">
                <div class="container">
                    <div class="row">
                        <div class="col-lg-6 order-2 order-lg-1">
                            <h1>Si sos el Dueño de un centro de deporte</h1>
                            <hr />
                            <br />
                            <br />
                            <h4>Te brindamos la posibilidad de que tu cancha se llene de jugadores y puedas gestionar todo a traves de la web</h4>

                        </div>
                        <div class="col-lg-6 order-1 order-lg-2">
                            <img src="https://massweb.com.ar/wp-content/uploads/2015/05/18-ideas-para-aumentar-tus-ventas.gif" alt="..." class="img-fluid">
                        </div>
                    </div>
                </div>
            </section>
        </div>
    </form>
</body>
</html>
