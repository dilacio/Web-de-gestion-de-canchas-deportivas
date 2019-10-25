<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JugadorHome.aspx.cs" MasterPageFile="~/Site1.Master" Inherits="TP4_Dilacio.JugadorHome" %>

<asp:Content ID="Jugador" ContentPlaceHolderID="Cuerpo" runat="server">

    <br />
    <hr />
    <section class="bg-inverse" id="SeleccionLugar">
        <div class="container">
            <div class="row">
                <div class="col-8">

                    <h2 class="text-center mt-0">Busca tu centro mas cercano</h2>

                    <div class="map-responsive">
                        <asp:DropDownList ID="ddProvincia" DataTextField="Nombre" DataValueField="Nombre" runat="server" class="btn btn-primary dropdown-toggle-split bg-warning w-auto"></asp:DropDownList>
                        <asp:DropDownList ID="ddCiudad" DataTextField="Nombre" DataValueField="Nombre" runat="server" class="btn btn-primary dropdown-toggle-split bg-warning w-auto"></asp:DropDownList>
                        <asp:DropDownList ID="ddLocalidad" DataTextField="Nombre" DataValueField="Nombre" runat="server" class="btn btn-primary dropdown-toggle-split bg-warning w-auto"></asp:DropDownList>
                        <asp:DropDownList ID="ddBarrio" DataTextField="Nombre" DataValueField="Nombre" runat="server" class="btn btn-primary dropdown-toggle-split bg-warning w-auto"></asp:DropDownList>
                        
                        <iframe src="https://www.google.com/maps/embed/v1/place?key=AIzaSyA0s1a7phLN0iaD6-UE7m4qP-z21pH0eSc&q=Eiffel+Tower+Paris+France" width="600" height="500" id="gmap_canvas" frameborder="0" style="border: 0" allowfullscreen></iframe>
                    </div>
                </div>
                <div class="col-4">
                    <br />
                    <br />
                    <br />

                    <asp:GridView ID ="gvCentros" runat="server" CssClass="table table-responsive bg-warning"></asp:GridView>

                
                </div>

            </div>

        </div>
    </section>

</asp:Content>
