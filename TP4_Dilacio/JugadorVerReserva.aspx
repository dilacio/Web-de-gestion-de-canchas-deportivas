<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JugadorVerReserva.aspx.cs" Inherits="TP4_Dilacio.JugadorVerReserva" MasterPageFile="~/Site1.Master" %>

<asp:Content ID="JugVerReservaHead" ContentPlaceHolderID="head" runat="server">

    <!-- Form style -->
    <link rel="stylesheet" href="css/formstyle.css" type="text/css" />

</asp:Content>

<asp:Content ID="JugVerReserva" ContentPlaceHolderID="Cuerpo" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-12">
                <div class="form-heading text-center">
                    <div class="adam-button" id="titulo" runat="server">Reservas</div>
                </div>
                <label class="label"></label>
                <asp:TextBox runat="server" ID="txbActividad" Enabled="false"></asp:TextBox>

                <asp:ListBox ID ="gvReservas" runat="server" CssClass="list-group-item list-group-item-secondary" Width ="1135px" Height="200px"  ></asp:ListBox>
                <div class="row">
                    <input type="button" class="adam-button" onclick="history.back()" style="margin-left:400px; width:300px" name="volver atrás" value="volver atrás">
                </div>
            </div>
        </div>
    </div>

</asp:Content>
