<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearCuenta.aspx.cs" MasterPageFile="~/Site1.Master" Inherits="TP4_Dilacio.CrearCuenta" %>


<asp:Content ID="CrearCuenta" ContentPlaceHolderID="Cuerpo" runat="server">

    <div class="img-fluid" style="background-image: url(../../Cancha.jpg); background-size: auto; position: absolute; top: 0; right: 0; bottom: 0; left: 0;">
        <div class="container">
            <div class="d-flex justify-content-center h-100 ">
                <div class="card">
                    <div class="card-header">
                        <h3>Registrarse</h3>
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
                                <input type="text" id="txbNombre" name="txbNombre" runat="server" class="form-control input-text" placeholder="Nombre" required>
                            </div>
                            <div class="input-group form-group">
                                <div class="input-group-prepend">
                                    <span class="input-group-text"><i class="fas fa-user"></i></span>
                                </div>
                                <input type="text" id="txbApellido" name="txbApellido" runat="server" class="form-control input-text" placeholder="Apellido" required>
                            </div>
                            <div class="input-group form-group">
                                <div class="input-group-prepend">
                                    <span class="input-group-text"><i class="fas fa-user"></i></span>
                                </div>
                                <input type="text" id="txbUser" name="txbUser" runat="server" class="form-control input-text" placeholder="Nombre de usuario" required>
                            </div>
                            <div class="input-group form-group">
                                <div class="input-group-prepend">
                                    <span class="input-group-text"><i class="fas fa-user"></i></span>
                                </div>
                                <input type="email" id="txbMail" name="txbMail" runat="server" class="form-control input-text" placeholder="mail@mail.com" required>
                            </div>

                            <div class="input-group form-group">
                                <div class="input-group-prepend">
                                    <span class="input-group-text"><i class="fas fa-key"></i></span>
                                </div>
                                <input type="password" id="txbPass" class="form-control input-text" placeholder="password" runat="server" required>
                            </div>

                            <div class="input-group form-group">
                                <div class="input-group-prepend">
                                    <span class="input-group-text"><i class="fas fa-key"></i></span>
                                </div>
                                <input type="password" id="txbRepetirPass" class="form-control input-text" placeholder="Repita el password" runat="server" required>
                            </div>

                            <asp:DropDownList ID="ddRole" DataTextField="Descripcion" DataValueField="Descripcion" runat="server" class="btn btn-raised float-left bg-warning"></asp:DropDownList>

                            <div class="form-group">

                                <input type="submit" value="Registrarse" style="margin-right:50px" class="btn btn-raised float-right bg-warning" runat="server" id="btnLogin" name="btnLogin"  onserverclick="btnLogin_ServerClick">
                            </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
