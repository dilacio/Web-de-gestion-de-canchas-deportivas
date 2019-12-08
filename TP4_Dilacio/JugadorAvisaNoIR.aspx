<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JugadorAvisaNoIR.aspx.cs" Inherits="TP4_Dilacio.JugadorAvisaNoIR" MasterPageFile="~/Site1.Master" %>

<asp:Content ContentPlaceHolderID="Cuerpo" ID="JugAvisaNoIR" runat="server">
    <div class="container">
        <div class="container">

            <div class="content">
                <div class="row">
                    <div class="col-8">
                        <h2>No puede dar de baja la reserva ya que no cumple el tiempo minimo de cancelacion</h2>
                        <br />
                        <hr />

                        <div class="row">
                            <h5>Desea Avisar que no va a asistir?</h5>
                        </div>
                        <div class="row">
                            <div class="col-6">
                                <input type="submit" value="No voy a ir,avisar" style="margin-right: 50px" class="btn btn-raised float-right bg-warning" runat="server" id="btnLogin" name="btnLogin" onserverclick="btnLogin_ServerClick">
                            </div>
                            <div class="col-6">
                                <input type="submit" value="Voy a ir" style="margin-right: 50px" class="btn btn-raised float-right bg-warning" runat="server" id="VoyAIr" name="btnLogin" onserverclick="VoyAIr_ServerClick">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
</asp:Content>
