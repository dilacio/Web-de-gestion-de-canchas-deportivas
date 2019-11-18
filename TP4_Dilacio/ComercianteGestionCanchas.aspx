<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ComercianteGestionCanchas.aspx.cs" Inherits="TP4_Dilacio.ComercianteGestionCanchas" MasterPageFile="~/Site1.Master" %>

<asp:Content ID="Com_GestionCanchas" ContentPlaceHolderID="head" runat="server">

    <!-- Form style -->
    <link rel="stylesheet" href="css/formstyle.css" type="text/css" />

</asp:Content>

<asp:Content ID="ComGestionCancha" ContentPlaceHolderID="Cuerpo" runat="server">
    <div class="container">

        <div class="content">
            <div class="row">

                <article class="col-md-12">
                    <!-- Start Subscribe Form -->
                    <div class="row">
                        <div class="col-md-11 offset-md-1">
                            <form method="post" name="booking" id="booking">

                                <hr />
                           
                                <div class="form-heading text-center">
                                    <div class="adam-button" style="background-color: blueviolet">Modifica los datos de tus canchas</div>
                                </div>
                                <div class="row">
                                    <div class="col-md-4">
                                        <div class="adam-button" style="background-color: blueviolet">Selccioná una cancha</div>
                                    </div>
                                    <div class="col-md-8">
                                        <asp:DropDownList runat="server" ID="ddCanchas" Width="650px" CssClass="adam-button" Style="background-color: blueviolet" OnSelectedIndexChanged="ddCanchas_SelectedIndexChanged" AutoPostBack="true" ></asp:DropDownList>
                                    </div>
                                </div>
                                <br />
                                <hr />
                                <div class="row">
                                    <div class="col-md-4">
                                        <label class="label">Abierto desde las: </label> 
                                        <input type="text" class='datepicker' required="required" runat="server" name="ingreso" id="txbHoraDesde" />
                                    </div>
                                    <div class="col-md-4">
                                        <label class="label">Hora de cierre</label>
                                        <input type="text" class='datepicker' required="required" runat="server" name="ingreso" id="txbHoraHasta" />
                                    </div>
                                    <div class="col-md-4">
                                        <label class="label">duracion de cada juego:</label>
                                        <input type="text" class='datepicker' required="required" runat="server" name="ingreso" id="txbDuracion" />
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-6">
                                        <asp:Button class="adam-button" runat="server" ID="btnActualizar" Text="Guardar" Style="background-color: blueviolet" Width="300px" OnClick="btnActualizar_Click" />
                                    </div>
                                    <div class="col-g">
                                                 <input type="button" class="adam-button" onclick="history.back()"  Style="background-color: blueviolet" Width="300px" name="volver atrás" value="volver atrás">
                                    </div>
                                </div>
  
                                <div class="form-heading text-center">
                                    <div class="adam-button" style="background-color: firebrick">Agregá canchas</div>
                                </div>
                                <br />
                                <div class="row">
                                    <div class="col-md-6">
                                        <label class="label">Nombre de la cancha </label>
                                        <input type="text" class='datepicker' runat="server" name="ingreso" id="txbNombreAgregar" />
                                    </div>
                                    <div class="col-md-6">
                                        <label class="label">La cancha es de: </label>
                                        <asp:DropDownList runat="server" ID="ddActividades" Width="450px" CssClass="adam-button" Style="background-color: firebrick"></asp:DropDownList>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-4">
                                        <label class="label">Abierto desde las: </label>
                                        <input type="text" class='datepicker' runat="server"  name="ingreso" id="txbDesdeAgregar" />
                                    </div>
                                    <div class="col-md-4">
                                        <label class="label">Hora de cierre</label>
                                        <input type="text" class='datepicker' runat="server" name="ingreso" id="txbHastaAgregar" />
                                    </div>
                                    <div class="col-md-4">
                                        <label class="label">duracion de cada juego:</label>
                                        <input type="text" class='datepicker' runat="server" name="ingreso" id="txbDuracionAgregar" />
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-6">
                                        <asp:Button class="adam-button" runat="server" ID="btnAgregar" Text="Guardar" Style="background-color: firebrick" Width="300px" OnClick="btnAgregar_Click" />
                                    </div>
                                    <div class="col-6">
                                                 <input type="button" class="adam-button" onclick="history.back()"  Style="background-color: firebrick" Width="300px" name="volver atrás" value="volver atrás">
                                    </div>
                                </div>
                                <br>
                            </form>
                        </div>
                    </div>


                </article>
                <div class="clearfix"></div>
            </div>
        </div>
    </div>
</asp:Content>
