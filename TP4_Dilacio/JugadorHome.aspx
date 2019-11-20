<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JugadorHome.aspx.cs" MasterPageFile="~/Site1.Master" Inherits="TP4_Dilacio.JugadorHome" %>


<asp:Content ID="Jugador" ContentPlaceHolderID="Cuerpo" runat="server">

    <section class="bg-inverse" id="SeleccionLugar">
        <div class="container">
            <div class="row">
                <div class="col-6">
                    <br />
                    <br />

                    <div class="card">
                        <div class="card-header text-white">
                            Reservá
                        </div>
                        <div class="card-body bg-white">
                            <div class="row">
                                <p class="card-title text-black-50" style="margin-left: 65px">Reserva tu lugar para hacer deportes</p>
                            </div>
                            <br />
                            <div class="row">
                                <img src="https://licencias.serviciosmerlo.net/images/turno.png" width="200" height="200" style="margin-left: 75px" />
                            </div>
                            <br />
                            <br />
                            <div class="row">

                                <asp:Button class="btn login_btn bg-warning w-auto" runat="server" Style="margin-left: 100px" ID="btn_ComenzarResereva" OnClick="btnIrComenzarReserva_click" Text="Reservar" />

                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-6">
                    <br />
                    <br />
                    <div class="card">
                        <div class="card-header text-white">
                            Ver Reserva
                        </div>
                        <div class="card-body bg-white">
                            <div class="row">
                                <p class="card-title text-black-50" style="margin-left: 75px">Revisa tu reserva</p>
                            </div>
                            <br />
                            <div class="row">
                                <img src="https://www.allegiantair.com/sites/default/files/reservations_ticketing.png" width="200" height="200" style="margin-left: 75px" />
                            </div>
                            <br />
                            <br />
                            <div class="row">

                                <asp:Button class="btn login_btn bg-warning w-auto" runat="server" Style="margin-left: 100px" ID="Button1" OnClick="btnIrReserva_click" Text="Ver reservar" />

                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-4">
                </div>
                <div class="col-4">
                </div>
            </div>

        </div>
    </section>

</asp:Content>
