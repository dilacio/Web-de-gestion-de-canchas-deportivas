<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ComercianteAltaCentro.aspx.cs" Inherits="TP4_Dilacio.ComercianteAltaCentro" MasterPageFile="~/Site1.Master" %>

<asp:Content ID="ComAltCen" ContentPlaceHolderID ="Cuerpo" runat="server">
 
    <div class="img-fluid" style="background-image: url(../../Cancha.jpg); background-size: auto; position: absolute; top: 0; right: 0; bottom: 0; left: 0;">
        <div class="container">
            <div class="d-flex justify-content-center h-100 ">
                <div class="card">
                    <div class="card-header">
                        <h3>Registrar Centro</h3>
                        <div class="d-flex justify-content-end social_icon">
                            <span><i class="fab fa-facebook-square"></i></span>
                            <span><i class="fab fa-google-plus-square"></i></span>
                            <span><i class="fab fa-twitter-square"></i></span>
                        </div>
                    </div>
                    <div class="card-body" >
                            <div class="input-group form-group">
                                <div class="input-group-prepend">
                                    <span class="input-group-text"><i class="fas fa-user"></i></span>
                                </div>
                                <input type="text" id="txbNombre" name="txbNombreCentro" runat="server" class="form-control input-text" placeholder="Nombre del Centro" required>
                            </div>
                            <div class="input-group form-group">
                                <div class="input-group-prepend">
                                    <span class="input-group-text"><i class="fas fa-user"></i></span>
                                </div>
                                <input type="text" id="txbDireccion" name="Barrio" runat="server" class="form-control input-text" placeholder="Direccion" required>
                            </div>

                             <div class="input-group form-group">
                     
                                <asp:DropDownList ID="ddBarrio" DataTextField="Nombre" DataValueField="Nombre" style="width: 400px" runat="server" class="btn btn-raised float-left bg-warning"></asp:DropDownList>
                            </div>
                            
                           <div class="form-group">

                                <input type="submit" value="Registrar" style="margin-right:50px" class="btn btn-raised float-right bg-warning" runat="server" id="btnLogin" name="btnLogin" onserverclick="btnLogin_ServerClick" >
                            </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
