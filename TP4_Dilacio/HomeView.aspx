<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeView.aspx.cs" Inherits="TP4_Dilacio.HomeView" MasterPageFile="~/Site1.Master" %>


<asp:Content ID="Home" ContentPlaceHolderID="Cuerpo" runat="server">

    <hr />
    <hr />
        <div class="img-fluid" style="background-image: url(../../Fondo12.jpg); background-size: cover; position: absolute; top: 0; right: 0; bottom: 0; left: 0;">
            <div class="container">
                <div class="d-flex justify-content-center h-100">
                    <div class="card">
                        <div class="card-header">
                            <h3>Iniciar Sesion</h3>
                            <div class="d-flex justify-content-end social_icon">
                                <span><i class="fab fa-facebook-square"></i></span>
                                <span><i class="fab fa-google-plus-square"></i></span>
                                <span><i class="fab fa-twitter-square"></i></span>
                            </div>
                        </div>
                        <div class="card-body">
                            <form>
                                <div class="input-group form-group">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text"><i class="fas fa-user"></i></span>
                                    </div>
                                    <input type="text" id="txbUser"  name="txbUser" runat="server" class="form-control input-text" placeholder="Nombre de usuario" onclick="validar();" >
                                    
                                </div>
                               
                                <div class="input-group form-group">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text"><i class="fas fa-key"></i></span>
                                    </div>
                                    <input type="password" id="txbPass" class="form-control input-text" placeholder="Contraseña" runat="server" onclick="Valida_Usuario();" >
                                </div>
                                <div class="row align-items-center remember">
                                    <input type="checkbox">Recordarme
				
                                </div>
                                <div class="form-group">
                                    
                                    <input type="submit" value="Login" class="btn  float-right login_btn" runat="server" id="btnLogin" name="btnLogin" onserverclick="Valida_Usuario">
                                </div>
                            </form>
                        </div>
                        <div class="card-footer">
                            <div class="d-flex justify-content-center links">
                                No tienes cuenta?<a href="CrearCuenta.aspx">Crear Cuenta</a>
                            </div>
                            <div class="d-flex justify-content-center">
                                <a href="#">Perdiste tu contraseña?</a>
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
                            <img src="https://cdn.pixabay.com/photo/2013/07/13/01/19/tennis-court-155517_960_720.png" alt="..." class="img-fluid"></div>
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
                            <img src="https://media3.giphy.com/media/7zfZspyvCgs4F4kiej/source.gif" alt="..." class="img-fluid"></div>
                    </div>
                </div>
            </section>

        </div>


</asp:Content>
