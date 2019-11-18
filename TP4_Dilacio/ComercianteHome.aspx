<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ComercianteHome.aspx.cs" Inherits="TP4_Dilacio.ComercianteHome" MasterPageFile="~/Site1.Master" %>

<asp:Content ID="ComHome" ContentPlaceHolderID="Cuerpo" runat="server">
    <section class="bg-inverse" id="SeleccionLugar">
        <div class="container">
            <div class="row">
                <div class="col-4">
                    <br />
                    <br />

                    <div class="card">
                        <div class="card-header text-white">Verifica tus datos</div>
                        <div class="card-body bg-white">
                            <div class="row">
                                <p class="card-title text-black-50" style="margin-left: 75px">Verifica los datos de tu comercio</p>
                            </div>
                            <div class="row">
                                <img src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS8jUnf9qPevu5wjmGrAzuCVSpOEJ1b5aVLWhp4x-oEaMmGxJvS&s" width="200" height="200" style="margin-left: 85px" />
                            </div>
                            <br />
                            <br />
                            <div class="row">

                                <asp:Button class="btn login_btn bg-warning w-auto" runat="server" Style="margin-left: 120px" ID="btn_ABM_datos" OnClick="btn_ABM_datos_Click" Text="Verificá" />

                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-4">
                    <br />
                    <br />
                    <div class="card">
                        <div class="card-header text-white">Gestioná tus canchas, ABM</div>
                        <div class="card-body bg-white">
                            <div class="row">
                                <p class="card-title text-black-50" style="margin-left: 75px">Gestioná tus canchas</p>
                            </div>
                            <div class="row">
                                <img src="https://image.flaticon.com/icons/png/512/404/404599.png" width="200" height="200" style="margin-left: 85px" />
                            </div>
                            <br />
                            <br />
                            <div class="row">

                                <asp:Button class="btn login_btn bg-warning w-auto" runat="server" Style="margin-left: 120px" ID="btnGestionCanchas" OnClick="btnGestionCanchas_Click" Text="Verificá" />

                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-4">
                    <br />
                    <br />
                    <div class="card">
                        <div class="card-header text-white">
                            Ver Reserva
                        </div>
                        <div class="card-body bg-white">
                            <div class="row">
                                <p class="card-title text-black-50" style="margin-left: 75px">Verifica las reservas</p>
                            </div>
                            <div class="row">
                                <img src="https://www.lojas-na.net/WebRoot/Store/Shops/SINFIC_002E_Lojas-na-Net_002E_061004/55F9/550F/F3B8/12BE/005F/25E6/6498/42A6/icon-calendario.png" width="200" height="200" style="margin-left: 85px" />
                            </div>
                            <br />
                            <br />

                            <div class="row">

                                <asp:Button class="btn login_btn bg-warning w-auto" runat="server" Style="margin-left: 120px" ID="btnIrReserva_click" OnClick="btnIrReserva_click_Click" Text="Ver reservar" />

                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </section>
</asp:Content>
