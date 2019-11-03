<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JugadorFinalizar.aspx.cs" Inherits="TP4_Dilacio.JugadorFinalizar" MasterPageFile="~/Site1.Master" %>


<asp:Content ID="JugFinalizar" ContentPlaceHolderID="Cuerpo" runat="server">

    <div class="card-body">
        <div class="row">
            <div class="col-12">
                <h1 style="margin-left: 500px">Reserva finalizada</h1>
                <p style="margin-left: 500px">En instantes te enviaremos un mail con la confirmacion de tu reserva</p>
                <p style="margin-left: 500px">Que disfrutes del juego</p>

                <asp:Button class="btn btn-raised bg-warning" runat="server" ID="btnConfirmar" OnClick="BtnConfirmar_Click" style="margin-left: 500px" Text="Finalizar" />
            </div>
        </div>
    </div>
</asp:Content>
