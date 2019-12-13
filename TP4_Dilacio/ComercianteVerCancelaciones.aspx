<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ComercianteVerCancelaciones.aspx.cs" Inherits="TP4_Dilacio.ComercianteVerCancelaciones" MasterPageFile="~/Comerciante.Master" %>

<asp:Content ID="ComReservaCancHead" ContentPlaceHolderID="head" runat="server">

    <!-- Form style -->
    <link rel="stylesheet" href="css/formstyle.css" type="text/css" />
</asp:Content>
<asp:Content ContentPlaceHolderID="Cuerpo" runat="server" ID="ComVerCancelacion">
    <br />
    <div class="container">
        <div class="row">
            <div class="col-6">
                <div class="form-heading text-center">
                    <div class="adam-button" id="titulo" runat="server">Lista de cancelaciones por usuarios</div>
                </div>
                <asp:GridView ID="gvReservasCanceladas" runat="server" CssClass="table" AutoGenerateColumns="false" OnSelectedIndexChanged="gvReservasCanceladas_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField HeaderText="Nombre" DataField="Usuario.Nombre" />
                        <asp:BoundField HeaderText="Apellido" DataField="Usuario.Apellido" />
                        <asp:BoundField HeaderText="Cantidad" DataField="ID" />
                    </Columns>
                </asp:GridView>
            </div>
            <div class="col-6">
                <div class="row">
                    <div class="form-heading text-center">
                        <div class="adam-button" id="Div1" runat="server" style="width: 573px;background-color: darkblue">Usuarios</div>
                    </div>
                    <asp:ListBox AutoGenerateSelectButton="true" ID="gvDesbloqueados" DataValueField="IDUsuario"  DataTextField="NombreUsuario" runat="server" CssClass="list-group-item list-group-item-secondary" Width="635px" Height="200px"></asp:ListBox>
                    <asp:Button CssClass="adam-button2" Text="Bloquear" runat="server" ID="btnBloquear" OnClick="btnBloquear_Click"/>
                </div>
                <div class="row">
                     <div class="form-heading text-center">
                        <div class="adam-button" id="Div2" runat="server" style="width: 573px;background-color: maroon">Usuarios Bloqueados</div>
                    </div>
                    <asp:ListBox ID="gvBloqueados" runat="server" DataValueField="IDUsuario"  DataTextField="NombreUsuario" CssClass="list-group-item list-group-item-secondary" Width="635px" Height="200px"></asp:ListBox>
                    <asp:Button CssClass="adam-button2" Text="Desbloquear" runat="server" ID="btnDesBloquear" OnClick="btnDesBloquear_Click" />
                </div>
            </div>
        </div>
    </div>


</asp:Content>
