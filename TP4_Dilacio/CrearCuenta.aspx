<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearCuenta.aspx.cs" MasterPageFile="~/Site1.Master" Inherits="TP4_Dilacio.CrearCuenta" %>


<asp:Content ID="CrearCuenta" ContentPlaceHolderID="Cuerpo" runat="server">

    <div class="img-fluid" style="background-image: url(../../Cancha.jpg); background-size: auto; position: absolute; top: 0; right: 0; bottom: 0; left: 0;">
        <div class="container">
            <div class="d-flex justify-content-center h-100">
                <div class="card">
                    <div class="card-header">
                        <h3>Registrarse</h3>
                        <div class="d-flex justify-content-end social_icon">
                            <span><i class="fab fa-facebook-square"></i></span>
                            <span><i class="fab fa-google-plus-square"></i></span>
                            <span><i class="fab fa-twitter-square"></i></span>
                        </div>
                    </div>
                    <div class="card-body">
                        <form>
                            <div class="input-group form-group">
                                <div class="input-group-prepend">
                                    <span class="input-group-text"><i class="fas fa-user"></i></span>
                                </div>
                                <input type="text" id="txbUser" name="txbUser" runat="server" class="form-control input-text" placeholder="Nombre de usuario">
                            </div>
                            <div class="input-group form-group">
                                <div class="input-group-prepend">
                                    <span class="input-group-text"><i class="fas fa-user"></i></span>
                                </div>
                                <input type="email" id="txbMail" name="txbMail" runat="server" class="form-control input-text" placeholder="mail@mail.com">
                            </div>

                            <div class="input-group form-group">
                                <div class="input-group-prepend">
                                    <span class="input-group-text"><i class="fas fa-key"></i></span>
                                </div>
                                <input type="password" id="txbPass" class="form-control input-text" placeholder="password" runat="server">
                            </div>

                            <div class="input-group form-group">
                                <div class="input-group-prepend">
                                    <span class="input-group-text"><i class="fas fa-key"></i></span>
                                </div>
                                <input type="password" id="txbRepetirPass" class="form-control input-text" placeholder="Repita el password" runat="server">
                            </div>

                            <asp:DropDownList ID="ddRole" DataTextField="Descripcion" DataValueField="Descripcion" runat="server" class="btn btn-primary dropdown-toggle-split bg-warning w-auto"></asp:DropDownList>

                            <div class="form-group">

                                <input type="submit" value="Registrarse" class="btn float-right login_btn" runat="server" id="btnLogin" name="btnLogin" style="width: auto" onserverclick="btnLogin_ServerClick">

                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
