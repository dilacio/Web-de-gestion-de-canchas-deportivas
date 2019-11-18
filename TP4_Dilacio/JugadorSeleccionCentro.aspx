<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JugadorSeleccionCentro.aspx.cs" Inherits="TP4_Dilacio.JugadorSeleccionCentro" MasterPageFile="~/Site1.Master" %>


<asp:Content ID="Jugador" ContentPlaceHolderID="Cuerpo" runat="server">

    <section class="bg-inverse" id="SeleccionLugar">
        <div class="container">
            <hr /> <br />
             <div class="row">
                 <h3>Por favor seleccioná el tipo de deporte que queres realizar</h3>
             </div> 
            <div class="row">
                    <asp:DropDownList ID="ddActividad" DataTextField="Nombre" DataValueField="Nombre" runat="server" class="btn btn-toolbar bg-warning w-100 btn-raised"></asp:DropDownList>
            </div>
 
            <div class="row">
                <hr />
                <div class="col-3">
                      <h5 class="text-black-50">Provincia</h5>
                        <asp:DropDownList ID="ddProvincia" DataTextField="Nombre" DataValueField="Nombre" runat="server" class="btn bg-warning w-75 btn-raised" OnSelectedIndexChanged="ddProvincia_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                </div>
                <div class="col-3">
                      <h5 class="text-black-50">Ciudad</h5>
                        <asp:DropDownList ID="ddCiudad" DataTextField="Nombre" DataValueField="Nombre" runat="server" class="btn btn-toolbar dropdown-toggle-split bg-warning w-75 btn-raised"></asp:DropDownList>
                </div>
                 <div class="col-3">
                      <h5 class="text-black-50">Localidad</h5>
                        <asp:DropDownList ID="ddLocalidad" DataTextField="Nombre" DataValueField="Nombre" runat="server" class="btn btn-toolbar dropdown-toggle-split bg-warning w-75 btn-raised"></asp:DropDownList>
                </div>
                 <div class="col-3">
                      <h5 class="text-black-50">Barrio</h5>
                        <asp:DropDownList ID="ddBarrio" DataTextField="Nombre" DataValueField="Nombre" runat="server" class="btn btn-toolbar dropdown-toggle-split bg-warning w-75 btn-raised"  ></asp:DropDownList>
                </div>
               
                <div class="row">
                    <div class="col-12">
                        <input type="submit" value="Buscar" class="btn login_btn btn-raised" style="background-color:deepskyblue; margin-top:20px;width: 1135px" runat="server"  id="btnBuscar" name="btnLogin" onserverclick="btnBuscar_ServerClick" >
                    </div>
         
                    
                </div>

                <div class="col-12">
                    <br />
     

                    <h4>Seleccioná el lugar que queres</h4>
                    <asp:ListBox ID ="gvCentros" runat="server" CssClass="list-group-item list-group-item-secondary" Width ="1135px" Height="200px"  ></asp:ListBox>
                    <asp:GridView runat="server" ID="gvcentros2"></asp:GridView>

                    <input type="submit" value="Seleccionar" class="float-lg-none login_btn bg-warning" runat="server" id="btnCentro" name="btnCentro" onserverclick="btnCentro_ServerClick">
                
                </div>

            </div>
            <div class="row">
         
             <%--<iframe src="https://www.google.com/maps/embed/v1/place?key=AIzaSyA0s1a7phLN0iaD6-UE7m4qP-z21pH0eSc&q=Eiffel+Tower+Paris+France" width="1100" height="400" id="gmap_canvas" frameborder="0" style="border: 0" allowfullscreen></iframe> --%>
            </div>

        </div>
    </section>

</asp:Content>
