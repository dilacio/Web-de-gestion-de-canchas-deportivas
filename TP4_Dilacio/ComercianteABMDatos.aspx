﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ComercianteABMDatos.aspx.cs" MasterPageFile="~/Site1.Master" Inherits="TP4_Dilacio.ComercianteABMDatos" %>

<asp:Content ID="Com_ABMHead" ContentPlaceHolderID="head" runat="server">

    <!-- Form style -->
    <link rel="stylesheet" href="css/formstyle.css" type="text/css" />

</asp:Content>

<asp:Content ID="Comer_ABM" ContentPlaceHolderID="Cuerpo" runat="server">
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
                                    <div class="adam-button">Datos Personales</div>
                                </div>
                                <br />
                                <div class="row">
                                    <div class="col-md-6">
                                        <label class="label">Nombre</label>

                                        <asp:TextBox runat="server" ID="txbnombre" required="true" Enabled="false"></asp:TextBox>
                                    </div>
                                    <div class="col-md-6">
                                        <label class="label">Apellido</label>
                                        <asp:TextBox runat="server" ID="txbape" Text="" required="true" Enabled="false"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-12">
                                        <label class="label">Nombre del centro</label>
                                        <asp:TextBox runat="server" ID="txbCentroNombre" required="true"></asp:TextBox>

                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-6">
                                        <label class="label">Direccion del centro</label>
                                        <asp:TextBox runat="server" ID="txbDireccion" required="true"></asp:TextBox>

                                    </div>

                                    <div class="col-md-6">
                                        <label class="label">Correo electrónico</label>
                                        <asp:TextBox runat="server" ID="txbMail" required="true"></asp:TextBox>

                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-6">
                                        <input type="button" class="adam-button" onclick="history.back()" name="volver atrás" value="volver atrás">
                                    </div>
                                    <div class="col-md-6 align-content-md-center">
                                        <asp:Button class="adam-button" runat="server" ID="btnConfirmar" Text="Confirmar" OnClick="btnConfirmar_Click" />
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
