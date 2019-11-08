<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JugadorReservaOK.aspx.cs" Inherits="TP4_Dilacio.JugadorReseraOK" MasterPageFile="~/Site1.Master" %>


<asp:Content ID="ReservaOKHead" ContentPlaceHolderID="head" runat="server">

    <!-- Form style -->
    <link rel="stylesheet" href="css/formstyle.css" type="text/css" />

</asp:Content>

<asp:Content ID="ReservaOK" ContentPlaceHolderID="Cuerpo" runat="server">

    <div class="container">

        <div class="content">
            <div class="row">

                <article class="col-md-12">
                    <!-- Start Subscribe Form -->
                    <div class="row">
                        <div class="col-md-11 offset-md-1">
                            <form method="post" name="booking" id="booking">
                                <!-- Form Title -->
                                <div class="form-heading text-center">
                                    <div class="adam-button">Confirmacion de Reserva</div>
                                </div>
                                <div class="row">
                                    <div class="col-md-12">
                                        <label class="label">Vas a jugar al: </label>
                                        <asp:TextBox runat="server" ID="txbActividad" Text="" Enabled="false"></asp:TextBox>
                                    </div>
                                </div>
                                <!-- First & Last Name -->
                                <div class="row">
                                    <div class="col-md-6">
                                        <label class="label">Nombres</label>

                                        <asp:TextBox runat="server" ID="txbnombre" Text="" Enabled="false"></asp:TextBox>
                                    </div>
                                    <div class="col-md-6">
                                        <label class="label">Apellidos</label>
                                        <asp:TextBox runat="server" ID="txbape" Text="" Enabled="false"></asp:TextBox>
                                    </div>
                                </div>
                                <!-- Email & Phone  -->
                                <div class="row">
                                    <div class="col-md-6">
                                        <label class="label">Correo electrónico</label>
                                        <asp:TextBox runat="server" ID="txbemail" Text="" Enabled="false"></asp:TextBox>

                                    </div>
                                    <div class="col-md-6">
                                        <label class="label">Fecha de juego</label>
                                        <input type="text" class='datepicker' name="ingreso" id="ingreso" />
                                    </div>
                                </div>

                                <br>
                                <div class="row">
                                    <div class="col-md-12">
                                        <label class="label">Centro deportivo</label>
                                        <asp:TextBox runat="server" ID="txbCentro" Enabled="false"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="row">
                                    <div class="col-md-6">
                                        <input type="button" class="adam-button" onclick="history.back()" name="volver atrás" value="volver atrás">
                                    </div>
                                    <div class="col-md-6 align-content-md-center">
                                        <asp:Button class="adam-button" runat="server" ID="btnConfirmar" OnClick="BtnConfirmar_Click" Text="Confirmar" />
                                    </div>
                                </div>
                            </form>
                        </div>
                    </div>


                </article>
                <div class="clearfix"></div>
            </div>
        </div>
    </div>


</asp:Content>



