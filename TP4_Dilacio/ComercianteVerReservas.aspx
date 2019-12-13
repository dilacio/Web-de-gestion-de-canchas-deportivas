<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ComercianteVerReservas.aspx.cs" Inherits="TP4_Dilacio.ComercianteVerReservas" MasterPageFile="~/Comerciante.Master" %>

<asp:Content ID="ComVerReservaHead" ContentPlaceHolderID="head" runat="server">

    <!-- Form style -->
    <link rel="stylesheet" href="css/formstyle.css" type="text/css" />

</asp:Content>

<asp:Content ID ="ComVerReserva" ContentPlaceHolderID ="Cuerpo" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-12">
                <div class="form-heading text-center">
                    <div class="adam-button" id="titulo" runat="server">Reservas pendientes</div>
                </div>
                <label class="label"></label>
                <asp:TextBox runat="server" ID="txbActividad" Enabled="false"></asp:TextBox>
               

                <asp:GridView ID ="gvReservasHechas" runat="server" CssClass="table" AutoGenerateColumns="false" OnRowCommand="gvReservasHechas_RowCommand">
                    <Columns>
                        <asp:buttonfield ControlStyle-CssClass="adam-button2" buttontype="Button" CommandName="Select" headertext="Asistio?" text="marcar como asistido"/>
                        <asp:BoundField HeaderText="ID"  DataField="ID"   />
                        <asp:BoundField HeaderText="Fecha"  DataField="Fecha"  />
                        <asp:BoundField HeaderText="Centro"  DataField="Cancha.Centro.Nombre"/>
                        <asp:BoundField HeaderText="Cancha"  DataField="Cancha.Nombre"  />
                        <asp:BoundField HeaderText="Direccion"  DataField="Cancha.Centro.Direccion"/>
                        <asp:BoundField HeaderText="Desde las"  DataField="HoraDesde"  />
                        <asp:BoundField HeaderText="Hasta las"  DataField="HoraHasta"  />
                        <asp:BoundField HeaderText="Deporte"  DataField="Actividad.Nombre"/>
                        <asp:BoundField HeaderText="Deporte"  DataField="Estado.Descripcion"/>
                    </Columns>
                </asp:GridView>
                
                <div class="row">
                    <input type="button" class="adam-button" onclick="history.back()" style="margin-left:400px; width:300px" name="volver atrás" value="volver atrás">
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-12">
                <div class="form-heading text-center">
                    <div class="adam-button" id="Div1" runat="server">Reservas asistidas</div>
                </div>
                <label class="label"></label>
                <asp:TextBox runat="server" ID="TextBox1" Enabled="false"></asp:TextBox>
               

                <asp:GridView ID ="gvReservasAsistidas" runat="server" CssClass="table" AutoGenerateColumns="false" OnRowCommand="gvReservasHechas_RowCommand">
                    <Columns>
                        <asp:BoundField HeaderText="ID"  DataField="ID"   />
                        <asp:BoundField HeaderText="Fecha"  DataField="Fecha"  />
                        <asp:BoundField HeaderText="Centro"  DataField="Cancha.Centro.Nombre"/>
                        <asp:BoundField HeaderText="Cancha"  DataField="Cancha.Nombre"  />
                        <asp:BoundField HeaderText="Direccion"  DataField="Cancha.Centro.Direccion"/>
                        <asp:BoundField HeaderText="Desde las"  DataField="HoraDesde"  />
                        <asp:BoundField HeaderText="Hasta las"  DataField="HoraHasta"  />
                        <asp:BoundField HeaderText="Deporte"  DataField="Actividad.Nombre"/>
                        <asp:BoundField HeaderText="Deporte"  DataField="Estado.Descripcion"/>
                    </Columns>
                </asp:GridView>
                
                <div class="row">
                    <input type="button" class="adam-button" onclick="history.back()" style="margin-left:400px; width:300px" name="volver atrás" value="volver atrás">
                </div>
            </div>
        </div>
    </div>

</asp:Content>
