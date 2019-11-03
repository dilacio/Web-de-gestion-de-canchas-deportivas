using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TP4_Dilacio
{
    public partial class HomeView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }
        protected void Valida_Usuario(object sender, EventArgs e)
        {
            string User = txbUser.Value;
            string Pass = txbPass.Value;


            UsuarioNegocio UsNeg = new UsuarioNegocio();
            Usuario Usuario = new Usuario();

            Usuario= UsNeg.Valida_Credenciales(User,Pass);

            if(Usuario !=  null)
            {
                if(Usuario.Role.Descripcion == "Jugador")
                {
                    Session["User_Home"] = Usuario;

                    Response.Redirect("JugadorHome.aspx");
                }
                else
                {
                    Response.Redirect("JugadorSeleccionDiaHora.aspx");
                }
            }
            else
            {
                Response.Write("<script>alert('Usuario Incorrecto, por favor ingrese nuevamente sus credenciales');</script>");
            }
            
        }
  
    }
}